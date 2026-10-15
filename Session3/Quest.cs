namespace Session03
{
    public class Quest
    {
        public string Title { get; }
        public Monster Target { get; }
        public int RewardGold { get; }
        public Player? TakenBy { get; private set; }
        public bool IsCompleted { get; private set; }

        public Quest(string title, Monster target, int rewardGold)
        { Title = title; Target = target; RewardGold = rewardGold; }

        public void Accept(Player p)
        {
            TakenBy = p;
        }

        public void TryComplete()
        {
            if (TakenBy == null)
            {
                return;
            }
            if (Target.IsAlive())
            {
                return;
            }
            if (IsCompleted)
            {
                return;
            }

            TakenBy.AddGold(RewardGold);
            IsCompleted = true;
        }
    }
}
