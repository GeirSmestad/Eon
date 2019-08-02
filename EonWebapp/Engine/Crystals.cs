using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EonWebapp.Engine
{
    public class Crystals
    {
        public int Yellow { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        public int Pink { get; set; }

        public bool ContainsAmount(Crystals amount)
        {
            return
                this.Yellow >= amount.Yellow &&
                this.Green >= amount.Green &&
                this.Blue >= amount.Blue &&
                this.Pink >= amount.Pink;
        }

        public bool ContainsMoreThanEightCrystals()
        {
            return Yellow + Green + Blue + Pink > 8;
        }

        public Crystals AddAmountTo(Crystals amountToAdd)
        {
            return new Crystals()
            {
                Yellow = this.Yellow + amountToAdd.Yellow,
                Green = this.Green + amountToAdd.Green,
                Blue = this.Blue + amountToAdd.Blue,
                Pink = this.Pink + amountToAdd.Pink
            };
        }

        public Crystals RemoveAmountFrom(Crystals amountToRemove)
        {
            if (!this.ContainsAmount(amountToRemove))
            {
                throw new InvalidOperationException("Not sufficient crystals to remove specified amount");
            }

            return new Crystals()
            {
                Yellow = this.Yellow - amountToRemove.Yellow,
                Green = this.Green - amountToRemove.Green,
                Blue = this.Blue - amountToRemove.Blue,
                Pink = this.Pink - amountToRemove.Pink
            };
        }
    }
}
