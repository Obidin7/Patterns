using Autofac;
using ObserverDeclaratory;
using System.Collections;
using System.Reflection;

var builder = new ContainerBuilder();
var assembly = Assembly.GetExecutingAssembly();

// register publish interfaces
builder.RegisterAssemblyTypes(assembly)
  .AsClosedTypesOf(typeof(ISend<>))
  .SingleInstance();

// register subscribers
builder.RegisterAssemblyTypes(assembly)
  .Where(t =>
    t.GetInterfaces()
      .Any(i =>
        i.IsGenericType &&
        i.GetGenericTypeDefinition() == typeof(IHandle<>)))
  .OnActivated(act =>
  {
      var instanceType = act.Instance.GetType();
      var interfaces = instanceType.GetInterfaces();
      foreach (var i in interfaces)
      {
          if (i.IsGenericType
        && i.GetGenericTypeDefinition() == typeof(IHandle<>))
          {
              var arg0 = i.GetGenericArguments()[0];
              var senderType = typeof(ISend<>).MakeGenericType(arg0);
              var allSenderTypes =
          typeof(IEnumerable<>).MakeGenericType(senderType);
              var allServices = act.Context.Resolve(allSenderTypes);
              foreach (var service in (IEnumerable)allServices)
              {
                  var eventInfo = service.GetType().GetEvent("Sender");
                  var handleMethod = instanceType.GetMethod("Handle");
                  var handler = Delegate.CreateDelegate(
              eventInfo.EventHandlerType, null, handleMethod);
                  eventInfo.AddEventHandler(service, handler);
              }
          }
      }
  })
  .SingleInstance()
  .AsSelf();

var container = builder.Build();

var car = container.Resolve<Car>();
var carLog = container.Resolve<CarLog>();

car.UpdateMaxSpeed(140);
car.UpdateMaxSpeed(220);