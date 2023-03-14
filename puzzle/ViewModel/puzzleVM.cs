using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puzzle.ViewModel
{
    internal partial class puzzleVM : ObservableObject
    {
        public puzzleVM() 
        {
            button1 = "White";
            button2 = "White";
            button3 = "White";
            button4 = "White";
            button5 = "White";
            button6 = "White";
            button7 = "White";
            button8 = "White";
            button9 = "White";
            timerStarted = false;
        }

        [ObservableProperty]
        private string button1;

        [ObservableProperty] 
        private string button2;

        [ObservableProperty] 
        private string button3;

        [ObservableProperty] 
        private string button4;

        [ObservableProperty] 
        private string button5;

        [ObservableProperty] 
        private string button6;

        [ObservableProperty] 
        private string button7;

        [ObservableProperty] 
        private string button8;

        [ObservableProperty] 
        private string button9;

        [ObservableProperty]
        private bool timerStarted;

        [ObservableProperty]
        private TimeOnly startTime;

        [ObservableProperty]
        private TimeOnly endTime;

        [ObservableProperty]
        private string currentTime;

        [RelayCommand]
        public void check()
        {
            if(Button1 == "Green" && Button2 == "Green" && Button3 == "Green" && Button4 == "Green" && Button5 == "Green" && Button6 == "Green" && Button7 == "Green" && Button8 == "Green" && Button9 == "Green")
            {
                EndTime = TimeOnly.FromDateTime(DateTime.Now);
                CurrentTime = (EndTime - StartTime).ToString();
                TimerStarted = false;
                Button1 = "White";
                Button2 = "White";
                Button3 = "White";
                Button4 = "White";
                Button5 = "White";
                Button6 = "White";
                Button7 = "White";
                Button8 = "White";
                Button9 = "White";
            }
        }

        [RelayCommand]
        public void onClick(string buttonClicked)
        {
            if(!TimerStarted) 
            {
                StartTime = TimeOnly.FromDateTime(DateTime.Now);
                TimerStarted = true;
            }
            switch (buttonClicked) 
            {
                case "1":
                    if (Button1 == "White")
                        Button1 = "Green";
                    else
                        Button1 = "White";

                    if (Button2 == "White")
                        Button2 = "Green";
                    else
                        Button2 = "White";

                    if (Button4 == "White")
                        Button4 = "Green";
                    else
                        Button4 = "White";
                    break;
                case "2":
                    if (Button1 == "White")
                        Button1 = "Green";
                    else
                        Button1 = "White";

                    if (Button2 == "White")
                        Button2 = "Green";
                    else
                        Button2 = "White";

                    if (Button3 == "White")
                        Button3 = "Green";
                    else
                        Button3 = "White";

                    if (Button5 == "White")
                        Button5 = "Green";
                    else
                        Button5 = "White";
                    break; 
                case "3":
                    if (Button3 == "White")
                        Button3 = "Green";
                    else
                        Button3 = "White";

                    if (Button2 == "White")
                        Button2 = "Green";
                    else
                        Button2 = "White";

                    if (Button6 == "White")
                        Button6 = "Green";
                    else
                        Button6 = "White";

                    break;
                case "4":
                    if (Button1 == "White")
                        Button1 = "Green";
                    else
                        Button1 = "White";

                    if (Button4 == "White")
                        Button4 = "Green";
                    else
                        Button4 = "White";

                    if (Button7 == "White")
                        Button7 = "Green";
                    else
                        Button7 = "White";

                    if (Button5 == "White")
                        Button5 = "Green";
                    else
                        Button5 = "White";
                    break;
                case "5":
                    if (Button2 == "White")
                        Button2 = "Green";
                    else
                        Button2 = "White";

                    if (Button4 == "White")
                        Button4 = "Green";
                    else
                        Button4 = "White";

                    if (Button6 == "White")
                        Button6 = "Green";
                    else
                        Button6 = "White";

                    if (Button5 == "White")
                        Button5 = "Green";
                    else
                        Button5 = "White";

                    if (Button8 == "White")
                        Button8 = "Green";
                    else
                        Button8 = "White";
                    break;
                case "6":
                    if (Button6 == "White")
                        Button6 = "Green";
                    else
                        Button6 = "White";

                    if (Button3 == "White")
                        Button3 = "Green";
                    else
                        Button3 = "White";

                    if (Button5 == "White")
                        Button5 = "Green";
                    else
                        Button5 = "White";

                    if (Button9 == "White")
                        Button9 = "Green";
                    else
                        Button9 = "White";
                    break;
                case "7":
                    if (Button4 == "White")
                        Button4 = "Green";
                    else
                        Button4 = "White";

                    if (Button7 == "White")
                        Button7 = "Green";
                    else
                        Button7 = "White";

                    if (Button8 == "White")
                        Button8 = "Green";
                    else
                        Button8 = "White";
                    break;
                case "8":
                    if (Button8 == "White")
                        Button8 = "Green";
                    else
                        Button8 = "White";

                    if (Button5 == "White")
                        Button5 = "Green";
                    else
                        Button5 = "White";

                    if (Button7 == "White")
                        Button7 = "Green";
                    else
                        Button7 = "White";

                    if (Button9 == "White")
                        Button9 = "Green";
                    else
                        Button9 = "White";
                    break;
                case "9":
                    if (Button6 == "White")
                        Button6 = "Green";
                    else
                        Button6 = "White";

                    if (Button8 == "White")
                        Button8 = "Green";
                    else
                        Button8 = "White";

                    if (Button9 == "White")
                        Button9 = "Green";
                    else
                        Button9 = "White";
                    break;
            }
        }

    }
}
