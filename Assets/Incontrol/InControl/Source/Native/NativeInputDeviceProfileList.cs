using System;
using UnityEngine;


namespace InControl
{
	public class NativeInputDeviceProfileList : ScriptableObject
	{
		public static string[] Profiles = new string[] 
		{
			"InControl.NativeProfile.AfterglowPrismaticXboxOneControllerMacProfile",
			"InControl.NativeProfile.BETAOPControllerMacProfile",
			"InControl.NativeProfile.BatarangControllerMacProfile",
			"InControl.NativeProfile.BigBenControllerMacProfile",
			"InControl.NativeProfile.EASportsControllerMacProfile",
			"InControl.NativeProfile.GameStopControllerMacProfile",
			"InControl.NativeProfile.GuitarHeroControllerMacProfile",
			"InControl.NativeProfile.HoriRealArcadeProEXPremiumVLXMacProfile",
			"InControl.NativeProfile.HoriBlueSoloControllerMacProfile",
			"InControl.NativeProfile.HoriControllerMacProfile",
			"InControl.NativeProfile.HoriDOA4ArcadeStickMacProfile",
			"InControl.NativeProfile.HoriEX2ControllerMacProfile",
			"InControl.NativeProfile.HoriFightStickMacProfile",
			"InControl.NativeProfile.HoriFightingStickEX2MacProfile",
			"InControl.NativeProfile.HoriFightingStickVXMacProfile",
			"InControl.NativeProfile.HoriPadEX2TurboControllerMacProfile",
			"InControl.NativeProfile.HoriPadEXTurboControllerMacProfile",
			"InControl.NativeProfile.HoriRealArcadeProEXMacProfile",
			"InControl.NativeProfile.HoriRealArcadeProEXSEMacProfile",
			"InControl.NativeProfile.HoriRealArcadeProHayabusaMacProfile",
			"InControl.NativeProfile.HoriRealArcadeProVXSAMacProfile",
			"InControl.NativeProfile.HoriXbox360GemPadExMacProfile",
			"InControl.NativeProfile.HoriXboxOneControllerMacProfile",
			"InControl.NativeProfile.IonDrumRockerMacProfile",
			"InControl.NativeProfile.JoytekXbox360ControllerMacProfile",
			"InControl.NativeProfile.KonamiDancePadMacProfile",
			"InControl.NativeProfile.LogitechChillStreamControllerMacProfile",
			"InControl.NativeProfile.LogitechControllerMacProfile",
			"InControl.NativeProfile.LogitechF310ControllerMacProfile",
			"InControl.NativeProfile.LogitechF510ControllerMacProfile",
			"InControl.NativeProfile.LogitechF710ControllerMacProfile",
			"InControl.NativeProfile.LogitechG920RacingWheelMacProfile",
			"InControl.NativeProfile.MLGControllerMacProfile",
			"InControl.NativeProfile.MVCTEStickMacProfile",
			"InControl.NativeProfile.MadCatzArcadeStickMacProfile",
			"InControl.NativeProfile.MadCatzBrawlStickMacProfile",
			"InControl.NativeProfile.MadCatzCODControllerMacProfile",
			"InControl.NativeProfile.MadCatzControllerMacProfile",
			"InControl.NativeProfile.MadCatzFPSProMacProfile",
			"InControl.NativeProfile.MadCatzFightPadControllerMacProfile",
			"InControl.NativeProfile.MadCatzFightPadMacProfile",
			"InControl.NativeProfile.MadCatzFightPadNeoMacProfile",
			"InControl.NativeProfile.MadCatzFightPadSCMacProfile",
			"InControl.NativeProfile.MadCatzFightPadTE2MacProfile",
			"InControl.NativeProfile.MadCatzMicroConControllerMacProfile",
			"InControl.NativeProfile.MadCatzMicroControllerMacProfile",
			"InControl.NativeProfile.MadCatzPortableDrumMacProfile",
			"InControl.NativeProfile.MadCatzProControllerMacProfile",
			"InControl.NativeProfile.MadCatzSF4FightStickRound2TEMacProfile",
			"InControl.NativeProfile.MadCatzSF4FightStickSEMacProfile",
			"InControl.NativeProfile.MadCatzSF4FightStickTEMacProfile",
			"InControl.NativeProfile.MadCatzSSF4ChunLiFightStickTEMacProfile",
			"InControl.NativeProfile.MadCatzSSF4FightStickTEMacProfile",
			"InControl.NativeProfile.MadCatzSaitekAV8R02MacProfile",
			"InControl.NativeProfile.MatCatzControllerMacProfile",
			"InControl.NativeProfile.MicrosoftXbox360ControllerMacProfile",
			"InControl.NativeProfile.MicrosoftXboxControllerMacProfile",
			"InControl.NativeProfile.MicrosoftXboxOneControllerMacProfile",
			"InControl.NativeProfile.MicrosoftXboxOneEliteControllerMacProfile",
			"InControl.NativeProfile.MortalKombatXbox360ControllerMacProfile",
			"InControl.NativeProfile.NaconGC100XFControllerMacProfile",
			"InControl.NativeProfile.PDPAfterglowControllerMacProfile",
			"InControl.NativeProfile.PDPMarvelControllerMacProfile",
			"InControl.NativeProfile.PDPTronControllerMacProfile",
			"InControl.NativeProfile.PDPVersusControllerMacProfile",
			"InControl.NativeProfile.PDPXboxOneControllerMacProfile",
			"InControl.NativeProfile.PowerAAirflowControllerMacProfile",
			"InControl.NativeProfile.PowerAMiniControllerMacProfile",
			"InControl.NativeProfile.PowerAMiniProExControllerMacProfile",
			"InControl.NativeProfile.PowerAMiniXboxOneControllerMacProfile",
			"InControl.NativeProfile.PowerASpectraIlluminatedControllerMacProfile",
			"InControl.NativeProfile.ProEXXbox360ControllerMacProfile",
			"InControl.NativeProfile.ProEXXboxOneControllerMacProfile",
			"InControl.NativeProfile.QanbaFightStickPlusMacProfile",
			"InControl.NativeProfile.RazerAtroxArcadeStickMacProfile",
			"InControl.NativeProfile.RazerOnzaControllerMacProfile",
			"InControl.NativeProfile.RazerOnzaTEControllerMacProfile",
			"InControl.NativeProfile.RazerSabertoothEliteControllerMacProfile",
			"InControl.NativeProfile.RazerStrikeControllerMacProfile",
			"InControl.NativeProfile.RazerWildcatControllerMacProfile",
			"InControl.NativeProfile.RedOctaneControllerMacProfile",
			"InControl.NativeProfile.RockBandDrumsMacProfile",
			"InControl.NativeProfile.RockBandGuitarMacProfile",
			"InControl.NativeProfile.RockCandyControllerMacProfile",
			"InControl.NativeProfile.RockCandyXbox360ControllerMacProfile",
			"InControl.NativeProfile.RockCandyXboxOneControllerMacProfile",
			"InControl.NativeProfile.RockCandyXboxOneGamePadMacProfile",
			"InControl.NativeProfile.SaitekXbox360ControllerMacProfile",
			"InControl.NativeProfile.TSZPelicanControllerMacProfile",
			"InControl.NativeProfile.ThrustmasterFerrari458RacingWheelMacProfile",
			"InControl.NativeProfile.ThrustmasterGPXControllerMacProfile",
			"InControl.NativeProfile.TrustPredatorJoystickMacProfile",
			"InControl.NativeProfile.BuffaloClassicMacProfile",
			"InControl.NativeProfile.LogitechF310ModeDMacProfile",
			"InControl.NativeProfile.LogitechF510ModeDMacProfile",
			"InControl.NativeProfile.LogitechF710ModeDMacProfile",
			"InControl.NativeProfile.PlayStation3MacProfile",
			"InControl.NativeProfile.PlayStation4MacProfile",
			"InControl.NativeProfile.Xbox360DriverMacProfile",
			"InControl.NativeProfile.XboxOneDriverMacProfile",
			"InControl.NativeProfile.AfterglowXbox360WindowsNativeProfile",
			"InControl.NativeProfile.AirFloPS3WindowsNativeProfile",
			"InControl.NativeProfile.BuffaloClassicWindowsNativeProfile",
			"InControl.NativeProfile.LogitechF310ModeDWindowsNativeProfile",
			"InControl.NativeProfile.LogitechF310ModeXWindowsNativeProfile",
			"InControl.NativeProfile.LogitechF510ModeDWindowsNativeProfile",
			"InControl.NativeProfile.LogitechF510ModeXWindowsNativeProfile",
			"InControl.NativeProfile.LogitechF710ModeDWindowsNativeProfile",
			"InControl.NativeProfile.LogitechF710ModeXWindowsNativeProfile",
			"InControl.NativeProfile.NVidiaShieldWindowsNativeProfile",
			"InControl.NativeProfile.PlayStation4WindowsNativeProfile",
			"InControl.NativeProfile.RazerServalWindowsNativeProfile",
			"InControl.NativeProfile.SteamWindowsNativeProfile",
			"InControl.NativeProfile.XInputWindowsNativeProfile",
			"InControl.NativeProfile.Xbox360WiredWindowsNativeProfile",
			"InControl.NativeProfile.Xbox360WirelessWindowsNativeProfile",
			"InControl.NativeProfile.XboxOneEliteWindowsNativeProfile",
			"InControl.NativeProfile.XboxOneWindows10NativeProfile",
			"InControl.NativeProfile.XboxOneWindowsNativeProfile",
		};
	}
}