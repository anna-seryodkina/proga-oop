using System;

namespace lab1
{
    class Train : Vehicle
    {
        public int length;

        public Train()
        {
            this.length = 2;
        }

        public Train(int length)
        {
            this.length = length;
        }

        public override void Go()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }


}
