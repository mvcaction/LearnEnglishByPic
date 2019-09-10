using LearnEnglishByPic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearnEnglishByPic
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public int counter = 1;

        List<ImageButton> ListImageButton = new List<ImageButton>();
        public MainPage()
        {
            InitializeComponent();



        }

        public void OnItemSelected(object sender, EventArgs args)
        {
            ImageButton ib = new ImageButton();
            var holder = sender;
            ib =(Xamarin.Forms.ImageButton) holder;
            var name = ib.Source;

        }

        async void OnNextButton(object sender, EventArgs args)
        {
            counter = (counter < 8) ? (counter + 1) : 1;


            string name = string.Format("a{0}.jpg", counter.ToString());
            ImagePreviwer.Source = name;
            if (counter==1)
            {
                ImagePreviwer.SetValue(IsVisibleProperty, false);
                PreviuseButton.SetValue(IsVisibleProperty, false);
                NextButton.SetValue(IsVisibleProperty, false);
                ExamGrid.SetValue(IsVisibleProperty,true);

            }

        }

        async void OnPrevioseButton(object sender, EventArgs args)
        {

        }

        async void SelectOne(object sender, EventArgs args)
        {
            ImagePreviwer.SetValue(IsVisibleProperty, true);
            PreviuseButton.SetValue(IsVisibleProperty, true);
            NextButton.SetValue(IsVisibleProperty, true);

            SelectGrid.SetValue(IsVisibleProperty, false);



        }
        public void SelectTwo(object sender, EventArgs args) { }
        public void SelectThree(object sender, EventArgs args) { }
        public void SelectFour(object sender, EventArgs args) { }
        public void SelectFive(object sender, EventArgs args) { }
        public void Selectsix(object sender, EventArgs args) { }
        public void SelectSeven(object sender, EventArgs args) { }
        public void SelectEight(object sender, EventArgs args) { }
        public void SelectNine(object sender, EventArgs args) { }
        public void SelectTen(object sender, EventArgs args) { }
        public void SelectEleven(object sender, EventArgs args) { }
        public void SelectTwelve(object sender, EventArgs args) { }
        public void SelectThirteen(object sender, EventArgs args) { }
        public void SelectFourteen(object sender, EventArgs args) { }
        public void SelectFifteen(object sender, EventArgs args) { }
        public void SelectSixteen(object sender, EventArgs args) { }
        public void SelectSeventeen(object sender, EventArgs args) { }
        public void SelectEighteen(object sender, EventArgs args) { }
        public void SelectNineteen(object sender, EventArgs args) { }
        public void SelectTwenty(object sender, EventArgs args) { }


    }
}
