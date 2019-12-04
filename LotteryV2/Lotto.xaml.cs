using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Lottery_Interface.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lotto : Page
    {
        public Lotto()
        {
            this.InitializeComponent();
        }
             
      
            
        }
    }


/*int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

int temp = 0;

for (int write = 0; write < arr.Length; write++) {
    for (int sort = 0; sort < arr.Length - 1; sort++) {
        if (arr[sort] > arr[sort + 1]) {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");

Console.ReadKey();*/
