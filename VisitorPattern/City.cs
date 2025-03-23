using System.Collections;

namespace VisitorPattern;

public class City
{
    private readonly ArrayList elements = [];

    public void Add(Element element)
    {
        elements.Add(element);
    }

    public void Remove(Element element)
    {
        elements.Remove(element);
    }

    public void Accept(Visitor visitor)
    {
        foreach (Element element in elements)
        {
            element.Accept(visitor);
        }
    }
}
