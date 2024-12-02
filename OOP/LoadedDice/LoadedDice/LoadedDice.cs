namespace LoadedDice
{
    internal class LoadedDice : Dice
    {
        //field
        private int _fixedResult;

        //constructors  (use base reffering to the parent class)
        public LoadedDice() : base() 
        {
            _fixedResult = 6;
        }

        public LoadedDice(int faces) : base(faces)
        {
            _fixedResult = faces;
        }

        public LoadedDice(int faces, int fixedResult) : base(faces)
        {
            _fixedResult = fixedResult;
        }

        //Method overiding
        public override void Throw()
        {
            Result = _fixedResult;
        }
    }
}
