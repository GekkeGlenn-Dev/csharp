using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dogRaceApp
{
    class Guy
    {
        public string Name { get; set; }
        public int Cash { get; set; }
        public RadioButton MyRadioButton { get; set; }
        public Label MyLabel { get; set; }
        public int Amount { get; set; }
        private Bet MyBet = new Bet();

        public void UpdateLabels()
        {
            MyBet.Bettor = this;
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = string.Format("{0}, Geld: € {1},-",this.Name, this.Cash);
        }

        public bool PlaceBet(int Amount, int Dog)
        {

            if (Cash >= Amount)
            {
                MyBet.Amount += Amount;
                Cash -= Amount;
                MyBet.Dog = Dog;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            MyBet.PayOut(Winner);
        }
    }
}
