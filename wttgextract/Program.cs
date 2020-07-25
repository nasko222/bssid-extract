/*
 * Created by SharpDevelop.
 * User: nasko222
 * Date: 21-Jan-20
 * Time: 9:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace wttgextract
{
	public static class Program
	{	
		public enum WiFiNames
		{
			TP_LINK_8907_5G,
			D59709,
			SSWIFI,
			DA3CHICKZ,
			Khaled,
			UAPPY_FI,
			Ethical_Hacker,
			MaxiumBlack,
			SnuffBox,
			YDidIOrderThisWater,
			Bring_Beer_to_504,
			doody,
			FIter,
			SuddenLink990,
			Ataua,
			FBI_Survellance_Van,
			swsecure,
			DOSNET,
			Hidden_Network,
			PHATCLOUD5,
			TellMyWifiLoveHer,
			RideThisCrazyWave,
			FreeWifiNoVirus,
			mycci7471,
			tedata,
			WIFIAF1A5D,
			ali,
			DonaldsWifi,
			SENDemo,
			Big_Dave_Network,
			JonesLaw,
			WINSLOWS,
			DDW35363,
			TC8717T10,
			Chanyia,
			PWF1382445,
			DevShareTWO,
			NetflxnChillByMyself,
			WIRELESSNET2,
			DrAdelDink,
			KPN_Fon,
			SilenceOfTheLANS,
			FreeWifi7899
		}
		
		public static void Main(string[] args)
		{
			string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string theFile = System.IO.File.ReadAllText(appDataFolder + @"\..\LocalLow\Reflect Studios\Welcome to the Game II\WTTG2.gd");
			string[] bssids = new String[32 + 8 + 2 + 1];
			string myEnum = string.Empty;
			theFile = Regex.Replace(theFile, @"[^0-9a-zA-Z, :]+", " ");
			theFile = Regex.Replace(theFile, @"(?<=^|\s)(?![A-Z0-9:]{14}|[A-Z0-9]{12}$(?:\s|$))\S+(?=\s|$)", "");
			theFile = Regex.Replace(theFile, " ", "");
			int j = 0;
			for (int i = 0; i <= 42; i++)
			{
				bssids[i] = theFile.Substring(j, 14);
				j += 14;
				myEnum = (Enum.GetName(typeof(WiFiNames), i));
				bssids[i] = myEnum + " - " + bssids[i];
				Console.WriteLine(bssids[i]);
			}
			Console.Title = "WTTG2 WiFi Extractor by nasko222";
			Console.SetWindowSize(48, 45);
			Console.SetWindowPosition(0, 0);
			Console.ReadKey();
		}
	}
}