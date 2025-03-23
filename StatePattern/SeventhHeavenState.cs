namespace StatePattern
{
    internal class SeventhHeavenState : State
    {
        internal SeventhHeavenState()
        {
            Console.WriteLine("The owner is in seventh heaven:");
            Exult();
        }

        protected override void ChangeState(Owner owner, Profit profitLevel)
        {
            switch (profitLevel)
            {
                case Profit.Loss:
                    {
                        owner.State = new WorryState();
                        break;
                    }
                case Profit.Gain:
                    {
                        owner.State = new SeventhHeavenState();
                        break;
                    }
            }
        }

        private static void Exult() => Console.WriteLine("Exults over the gain.");
    }
}
