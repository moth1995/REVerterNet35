using System;
using System.Drawing;
using System.Windows.Forms;

namespace Verter
{
	public partial class Verter : Form
	{

		private readonly frmWEPES frmWEPES;

		private readonly decimal decCBAttackMax;

		private readonly decimal decCBAttackMin;

		private readonly decimal decCBDefenseMax;

		private readonly decimal decCBDefenseMin;

		private readonly decimal decCBBodyBalanceMax;

		private readonly decimal decCBBodyBalanceMin;

		private readonly decimal decCBStaminaMax;

		private readonly decimal decCBStaminaMin;

		private readonly decimal decCBTopSpeedMax;

		private readonly decimal decCBTopSpeedMin;

		private readonly decimal decCBAccelerationMax;

		private readonly decimal decCBAccelerationMin;

		private readonly decimal decCBResponseMax;

		private readonly decimal decCBResponseMin;

		private readonly decimal decCBAgilityMax;

		private readonly decimal decCBAgilityMin;

		private readonly decimal decCBDribblePrecisionMax;

		private readonly decimal decCBDribblePrecisionMin;

		private readonly decimal decCBDribbleSpeedMax;

		private readonly decimal decCBDribbleSpeedMin;

		private readonly decimal decCBShortPassPrecisionMax;

		private readonly decimal decCBShortPassPrecisionMin;

		private readonly decimal decCBShortPassSpeedMax;

		private readonly decimal decCBShortPassSpeedMin;

		private readonly decimal decCBLongPassPrecisionMax;

		private readonly decimal decCBLongPassPrecisionMin;

		private readonly decimal decCBLongPassSpeedMax;

		private readonly decimal decCBLongPassSpeedMin;

		private readonly decimal decCBShotPrecisionMax;

		private readonly decimal decCBShotPrecisionMin;

		private readonly decimal decCBShotPowerMax;

		private readonly decimal decCBShotPowerMin;

		private readonly decimal decCBShotTechniqueMax;

		private readonly decimal decCBShotTechniqueMin;

		private readonly decimal decCBFreeKickPrecisionMax;

		private readonly decimal decCBFreeKickPrecisionMin;

		private readonly decimal decCBBendMax;

		private readonly decimal decCBBendMin;

		private readonly decimal decCBHeadingMax;

		private readonly decimal decCBHeadingMin;

		private readonly decimal decCBJumpMax;

		private readonly decimal decCBJumpMin;

		private readonly decimal decCBTechniqueMax;

		private readonly decimal decCBTechniqueMin;

		private readonly decimal decCBAggressivenessMax;

		private readonly decimal decCBAggressivenessMin;

		private readonly decimal decCBMentalityMax;

		private readonly decimal decCBMentalityMin;

		private readonly decimal decCBCooperationMax;

		private readonly decimal decCBCooperationMin;

		private readonly decimal decCBStarPlayer;

		private readonly decimal decSBAttackMax;

		private readonly decimal decSBAttackMin;

		private readonly decimal decSBDefenseMax;

		private readonly decimal decSBDefenseMin;

		private readonly decimal decSBBodyBalanceMax;

		private readonly decimal decSBBodyBalanceMin;

		private readonly decimal decSBStaminaMax;

		private readonly decimal decSBStaminaMin;

		private readonly decimal decSBTopSpeedMax;

		private readonly decimal decSBTopSpeedMin;

		private readonly decimal decSBAccelerationMax;

		private readonly decimal decSBAccelerationMin;

		private readonly decimal decSBResponseMax;

		private readonly decimal decSBResponseMin;

		private readonly decimal decSBAgilityMax;

		private readonly decimal decSBAgilityMin;

		private readonly decimal decSBDribblePrecisionMax;

		private readonly decimal decSBDribblePrecisionMin;

		private readonly decimal decSBDribbleSpeedMax;

		private readonly decimal decSBDribbleSpeedMin;

		private readonly decimal decSBShortPassPrecisionMax;

		private readonly decimal decSBShortPassPrecisionMin;

		private readonly decimal decSBShortPassSpeedMax;

		private readonly decimal decSBShortPassSpeedMin;

		private readonly decimal decSBLongPassPrecisionMax;

		private readonly decimal decSBLongPassPrecisionMin;

		private readonly decimal decSBLongPassSpeedMax;

		private readonly decimal decSBLongPassSpeedMin;

		private readonly decimal decSBShotPrecisionMax;

		private readonly decimal decSBShotPrecisionMin;

		private readonly decimal decSBShotPowerMax;

		private readonly decimal decSBShotPowerMin;

		private readonly decimal decSBShotTechniqueMax;

		private readonly decimal decSBShotTechniqueMin;

		private readonly decimal decSBFreeKickPrecisionMax;

		private readonly decimal decSBFreeKickPrecisionMin;

		private readonly decimal decSBBendMax;

		private readonly decimal decSBBendMin;

		private readonly decimal decSBHeadingMax;

		private readonly decimal decSBHeadingMin;

		private readonly decimal decSBJumpMax;

		private readonly decimal decSBJumpMin;

		private readonly decimal decSBTechniqueMax;

		private readonly decimal decSBTechniqueMin;

		private readonly decimal decSBAggressivenessMax;

		private readonly decimal decSBAggressivenessMin;

		private readonly decimal decSBMentalityMax;

		private readonly decimal decSBMentalityMin;

		private readonly decimal decSBCooperationMax;

		private readonly decimal decSBCooperationMin;

		private readonly decimal decSBStarPlayer;

		private readonly decimal decDMFAttackMax;

		private readonly decimal decDMFAttackMin;

		private readonly decimal decDMFDefenseMax;

		private readonly decimal decDMFDefenseMin;

		private readonly decimal decDMFBodyBalanceMax;

		private readonly decimal decDMFBodyBalanceMin;

		private readonly decimal decDMFStaminaMax;

		private readonly decimal decDMFStaminaMin;

		private readonly decimal decDMFTopSpeedMax;

		private readonly decimal decDMFTopSpeedMin;

		private readonly decimal decDMFAccelerationMax;

		private readonly decimal decDMFAccelerationMin;

		private readonly decimal decDMFResponseMax;

		private readonly decimal decDMFResponseMin;

		private readonly decimal decDMFAgilityMax;

		private readonly decimal decDMFAgilityMin;

		private readonly decimal decDMFDribblePrecisionMax;

		private readonly decimal decDMFDribblePrecisionMin;

		private readonly decimal decDMFDribbleSpeedMax;

		private readonly decimal decDMFDribbleSpeedMin;

		private readonly decimal decDMFShortPassPrecisionMax;

		private readonly decimal decDMFShortPassPrecisionMin;

		private readonly decimal decDMFShortPassSpeedMax;

		private readonly decimal decDMFShortPassSpeedMin;

		private readonly decimal decDMFLongPassPrecisionMax;

		private readonly decimal decDMFLongPassPrecisionMin;

		private readonly decimal decDMFLongPassSpeedMax;

		private readonly decimal decDMFLongPassSpeedMin;

		private readonly decimal decDMFShotPrecisionMax;

		private readonly decimal decDMFShotPrecisionMin;

		private readonly decimal decDMFShotPowerMax;

		private readonly decimal decDMFShotPowerMin;

		private readonly decimal decDMFShotTechniqueMax;

		private readonly decimal decDMFShotTechniqueMin;

		private readonly decimal decDMFFreeKickPrecisionMax;

		private readonly decimal decDMFFreeKickPrecisionMin;

		private readonly decimal decDMFBendMax;

		private readonly decimal decDMFBendMin;

		private readonly decimal decDMFHeadingMax;

		private readonly decimal decDMFHeadingMin;

		private readonly decimal decDMFJumpMax;

		private readonly decimal decDMFJumpMin;

		private readonly decimal decDMFTechniqueMax;

		private readonly decimal decDMFTechniqueMin;

		private readonly decimal decDMFAggressivenessMax;

		private readonly decimal decDMFAggressivenessMin;

		private readonly decimal decDMFMentalityMax;

		private readonly decimal decDMFMentalityMin;

		private readonly decimal decDMFCooperationMax;

		private readonly decimal decDMFCooperationMin;

		private readonly decimal decDMFStarPlayer;

		private readonly decimal decSMFAttackMax;

		private readonly decimal decSMFAttackMin;

		private readonly decimal decSMFDefenseMax;

		private readonly decimal decSMFDefenseMin;

		private readonly decimal decSMFBodyBalanceMax;

		private readonly decimal decSMFBodyBalanceMin;

		private readonly decimal decSMFStaminaMax;

		private readonly decimal decSMFStaminaMin;

		private readonly decimal decSMFTopSpeedMax;

		private readonly decimal decSMFTopSpeedMin;

		private readonly decimal decSMFAccelerationMax;

		private readonly decimal decSMFAccelerationMin;

		private readonly decimal decSMFResponseMax;

		private readonly decimal decSMFResponseMin;

		private readonly decimal decSMFAgilityMax;

		private readonly decimal decSMFAgilityMin;

		private readonly decimal decSMFDribblePrecisionMax;

		private readonly decimal decSMFDribblePrecisionMin;

		private readonly decimal decSMFDribbleSpeedMax;

		private readonly decimal decSMFDribbleSpeedMin;

		private readonly decimal decSMFShortPassPrecisionMax;

		private readonly decimal decSMFShortPassPrecisionMin;

		private readonly decimal decSMFShortPassSpeedMax;

		private readonly decimal decSMFShortPassSpeedMin;

		private readonly decimal decSMFLongPassPrecisionMax;

		private readonly decimal decSMFLongPassPrecisionMin;

		private readonly decimal decSMFLongPassSpeedMax;

		private readonly decimal decSMFLongPassSpeedMin;

		private readonly decimal decSMFShotPrecisionMax;

		private readonly decimal decSMFShotPrecisionMin;

		private readonly decimal decSMFShotPowerMax;

		private readonly decimal decSMFShotPowerMin;

		private readonly decimal decSMFShotTechniqueMax;

		private readonly decimal decSMFShotTechniqueMin;

		private readonly decimal decSMFFreeKickPrecisionMax;

		private readonly decimal decSMFFreeKickPrecisionMin;

		private readonly decimal decSMFBendMax;

		private readonly decimal decSMFBendMin;

		private readonly decimal decSMFHeadingMax;

		private readonly decimal decSMFHeadingMin;

		private readonly decimal decSMFJumpMax;

		private readonly decimal decSMFJumpMin;

		private readonly decimal decSMFTechniqueMax;

		private readonly decimal decSMFTechniqueMin;

		private readonly decimal decSMFAggressivenessMax;

		private readonly decimal decSMFAggressivenessMin;

		private readonly decimal decSMFMentalityMax;

		private readonly decimal decSMFMentalityMin;

		private readonly decimal decSMFCooperationMax;

		private readonly decimal decSMFCooperationMin;

		private readonly decimal decSMFStarPlayer;

		private readonly decimal decOMFAttackMax;

		private readonly decimal decOMFAttackMin;

		private readonly decimal decOMFDefenseMax;

		private readonly decimal decOMFDefenseMin;

		private readonly decimal decOMFBodyBalanceMax;

		private readonly decimal decOMFBodyBalanceMin;

		private readonly decimal decOMFStaminaMax;

		private readonly decimal decOMFStaminaMin;

		private readonly decimal decOMFTopSpeedMax;

		private readonly decimal decOMFTopSpeedMin;

		private readonly decimal decOMFAccelerationMax;

		private readonly decimal decOMFAccelerationMin;

		private readonly decimal decOMFResponseMax;

		private readonly decimal decOMFResponseMin;

		private readonly decimal decOMFAgilityMax;

		private readonly decimal decOMFAgilityMin;

		private readonly decimal decOMFDribblePrecisionMax;

		private readonly decimal decOMFDribblePrecisionMin;

		private readonly decimal decOMFDribbleSpeedMax;

		private readonly decimal decOMFDribbleSpeedMin;

		private readonly decimal decOMFShortPassPrecisionMax;

		private readonly decimal decOMFShortPassPrecisionMin;

		private readonly decimal decOMFShortPassSpeedMax;

		private readonly decimal decOMFShortPassSpeedMin;

		private readonly decimal decOMFLongPassPrecisionMax;

		private readonly decimal decOMFLongPassPrecisionMin;

		private readonly decimal decOMFLongPassSpeedMax;

		private readonly decimal decOMFLongPassSpeedMin;

		private readonly decimal decOMFShotPrecisionMax;

		private readonly decimal decOMFShotPrecisionMin;

		private readonly decimal decOMFShotPowerMax;

		private readonly decimal decOMFShotPowerMin;

		private readonly decimal decOMFShotTechniqueMax;

		private readonly decimal decOMFShotTechniqueMin;

		private readonly decimal decOMFFreeKickPrecisionMax;

		private readonly decimal decOMFFreeKickPrecisionMin;

		private readonly decimal decOMFBendMax;

		private readonly decimal decOMFBendMin;

		private readonly decimal decOMFHeadingMax;

		private readonly decimal decOMFHeadingMin;

		private readonly decimal decOMFJumpMax;

		private readonly decimal decOMFJumpMin;

		private readonly decimal decOMFTechniqueMax;

		private readonly decimal decOMFTechniqueMin;

		private readonly decimal decOMFAggressivenessMax;

		private readonly decimal decOMFAggressivenessMin;

		private readonly decimal decOMFMentalityMax;

		private readonly decimal decOMFMentalityMin;

		private readonly decimal decOMFCooperationMax;

		private readonly decimal decOMFCooperationMin;

		private readonly decimal decOMFStarPlayer;

		private readonly decimal decWFAttackMax;

		private readonly decimal decWFAttackMin;

		private readonly decimal decWFDefenseMax;

		private readonly decimal decWFDefenseMin;

		private readonly decimal decWFBodyBalanceMax;

		private readonly decimal decWFBodyBalanceMin;

		private readonly decimal decWFStaminaMax;

		private readonly decimal decWFStaminaMin;

		private readonly decimal decWFTopSpeedMax;

		private readonly decimal decWFTopSpeedMin;

		private readonly decimal decWFAccelerationMax;

		private readonly decimal decWFAccelerationMin;

		private readonly decimal decWFResponseMax;

		private readonly decimal decWFResponseMin;

		private readonly decimal decWFAgilityMax;

		private readonly decimal decWFAgilityMin;

		private readonly decimal decWFDribblePrecisionMax;

		private readonly decimal decWFDribblePrecisionMin;

		private readonly decimal decWFDribbleSpeedMax;

		private readonly decimal decWFDribbleSpeedMin;

		private readonly decimal decWFShortPassPrecisionMax;

		private readonly decimal decWFShortPassPrecisionMin;

		private readonly decimal decWFShortPassSpeedMax;

		private readonly decimal decWFShortPassSpeedMin;

		private readonly decimal decWFLongPassPrecisionMax;

		private readonly decimal decWFLongPassPrecisionMin;

		private readonly decimal decWFLongPassSpeedMax;

		private readonly decimal decWFLongPassSpeedMin;

		private readonly decimal decWFShotPrecisionMax;

		private readonly decimal decWFShotPrecisionMin;

		private readonly decimal decWFShotPowerMax;

		private readonly decimal decWFShotPowerMin;

		private readonly decimal decWFShotTechniqueMax;

		private readonly decimal decWFShotTechniqueMin;

		private readonly decimal decWFFreeKickPrecisionMax;

		private readonly decimal decWFFreeKickPrecisionMin;

		private readonly decimal decWFBendMax;

		private readonly decimal decWFBendMin;

		private readonly decimal decWFHeadingMax;

		private readonly decimal decWFHeadingMin;

		private readonly decimal decWFJumpMax;

		private readonly decimal decWFJumpMin;

		private readonly decimal decWFTechniqueMax;

		private readonly decimal decWFTechniqueMin;

		private readonly decimal decWFAggressivenessMax;

		private readonly decimal decWFAggressivenessMin;

		private readonly decimal decWFMentalityMax;

		private readonly decimal decWFMentalityMin;

		private readonly decimal decWFCooperationMax;

		private readonly decimal decWFCooperationMin;

		private readonly decimal decWFStarPlayer;

		private readonly decimal decSTCFAttackMax;

		private readonly decimal decSTCFAttackMin;

		private readonly decimal decSTCFDefenseMax;

		private readonly decimal decSTCFDefenseMin;

		private readonly decimal decSTCFBodyBalanceMax;

		private readonly decimal decSTCFBodyBalanceMin;

		private readonly decimal decSTCFStaminaMax;

		private readonly decimal decSTCFStaminaMin;

		private readonly decimal decSTCFTopSpeedMax;

		private readonly decimal decSTCFTopSpeedMin;

		private readonly decimal decSTCFAccelerationMax;

		private readonly decimal decSTCFAccelerationMin;

		private readonly decimal decSTCFResponseMax;

		private readonly decimal decSTCFResponseMin;

		private readonly decimal decSTCFAgilityMax;

		private readonly decimal decSTCFAgilityMin;

		private readonly decimal decSTCFDribblePrecisionMax;

		private readonly decimal decSTCFDribblePrecisionMin;

		private readonly decimal decSTCFDribbleSpeedMax;

		private readonly decimal decSTCFDribbleSpeedMin;

		private readonly decimal decSTCFShortPassPrecisionMax;

		private readonly decimal decSTCFShortPassPrecisionMin;

		private readonly decimal decSTCFShortPassSpeedMax;

		private readonly decimal decSTCFShortPassSpeedMin;

		private readonly decimal decSTCFLongPassPrecisionMax;

		private readonly decimal decSTCFLongPassPrecisionMin;

		private readonly decimal decSTCFLongPassSpeedMax;

		private readonly decimal decSTCFLongPassSpeedMin;

		private readonly decimal decSTCFShotPrecisionMax;

		private readonly decimal decSTCFShotPrecisionMin;

		private readonly decimal decSTCFShotPowerMax;

		private readonly decimal decSTCFShotPowerMin;

		private readonly decimal decSTCFShotTechniqueMax;

		private readonly decimal decSTCFShotTechniqueMin;

		private readonly decimal decSTCFFreeKickPrecisionMax;

		private readonly decimal decSTCFFreeKickPrecisionMin;

		private readonly decimal decSTCFBendMax;

		private readonly decimal decSTCFBendMin;

		private readonly decimal decSTCFHeadingMax;

		private readonly decimal decSTCFHeadingMin;

		private readonly decimal decSTCFJumpMax;

		private readonly decimal decSTCFJumpMin;

		private readonly decimal decSTCFTechniqueMax;

		private readonly decimal decSTCFTechniqueMin;

		private readonly decimal decSTCFAggressivenessMax;

		private readonly decimal decSTCFAggressivenessMin;

		private readonly decimal decSTCFMentalityMax;

		private readonly decimal decSTCFMentalityMin;

		private readonly decimal decSTCFCooperationMax;

		private readonly decimal decSTCFCooperationMin;

		private readonly decimal decSTCFStarPlayer;

		[STAThread]
		public static void Main()
		{
			Application.Run(new Verter());
		}

		public Verter()
		{
			frmWEPES = new frmWEPES();
			decCBAttackMax = 76m;
			decCBAttackMin = 32m;
			decCBDefenseMax = 97m;
			decCBDefenseMin = 58m;
			decCBBodyBalanceMax = 98m;
			decCBBodyBalanceMin = 56m;
			decCBStaminaMax = 90m;
			decCBStaminaMin = 48m;
			decCBTopSpeedMax = 89m;
			decCBTopSpeedMin = 44m;
			decCBAccelerationMax = 88m;
			decCBAccelerationMin = 42m;
			decCBResponseMax = 93m;
			decCBResponseMin = 51m;
			decCBAgilityMax = 84m;
			decCBAgilityMin = 45m;
			decCBDribblePrecisionMax = 84m;
			decCBDribblePrecisionMin = 43m;
			decCBDribbleSpeedMax = 83m;
			decCBDribbleSpeedMin = 44m;
			decCBShortPassPrecisionMax = 84m;
			decCBShortPassPrecisionMin = 42m;
			decCBShortPassSpeedMax = 81m;
			decCBShortPassSpeedMin = 48m;
			decCBLongPassPrecisionMax = 93m;
			decCBLongPassPrecisionMin = 51m;
			decCBLongPassSpeedMax = 88m;
			decCBLongPassSpeedMin = 52m;
			decCBShotPrecisionMax = 76m;
			decCBShotPrecisionMin = 41m;
			decCBShotPowerMax = 91m;
			decCBShotPowerMin = 59m;
			decCBShotTechniqueMax = 82m;
			decCBShotTechniqueMin = 54m;
			decCBFreeKickPrecisionMax = 88m;
			decCBFreeKickPrecisionMin = 39m;
			decCBBendMax = 85m;
			decCBBendMin = 37m;
			decCBHeadingMax = 94m;
			decCBHeadingMin = 50m;
			decCBJumpMax = 95m;
			decCBJumpMin = 48m;
			decCBTechniqueMax = 90m;
			decCBTechniqueMin = 48m;
			decCBAggressivenessMax = 84m;
			decCBAggressivenessMin = 42m;
			decCBMentalityMax = 88m;
			decCBMentalityMin = 52m;
			decCBCooperationMax = 88m;
			decCBCooperationMin = 51m;
			decCBStarPlayer = 12m;
			decSBAttackMax = 86m;
			decSBAttackMin = 50m;
			decSBDefenseMax = 88m;
			decSBDefenseMin = 51m;
			decSBBodyBalanceMax = 93m;
			decSBBodyBalanceMin = 49m;
			decSBStaminaMax = 96m;
			decSBStaminaMin = 50m;
			decSBTopSpeedMax = 93m;
			decSBTopSpeedMin = 54m;
			decSBAccelerationMax = 93m;
			decSBAccelerationMin = 45m;
			decSBResponseMax = 85m;
			decSBResponseMin = 56m;
			decSBAgilityMax = 88m;
			decSBAgilityMin = 50m;
			decSBDribblePrecisionMax = 91m;
			decSBDribblePrecisionMin = 61m;
			decSBDribbleSpeedMax = 91m;
			decSBDribbleSpeedMin = 58m;
			decSBShortPassPrecisionMax = 85m;
			decSBShortPassPrecisionMin = 54m;
			decSBShortPassSpeedMax = 85m;
			decSBShortPassSpeedMin = 54m;
			decSBLongPassPrecisionMax = 91m;
			decSBLongPassPrecisionMin = 56m;
			decSBLongPassSpeedMax = 91m;
			decSBLongPassSpeedMin = 56m;
			decSBShotPrecisionMax = 81m;
			decSBShotPrecisionMin = 52m;
			decSBShotPowerMax = 96m;
			decSBShotPowerMin = 60m;
			decSBShotTechniqueMax = 84m;
			decSBShotTechniqueMin = 55m;
			decSBFreeKickPrecisionMax = 91m;
			decSBFreeKickPrecisionMin = 46m;
			decSBBendMax = 90m;
			decSBBendMin = 44m;
			decSBHeadingMax = 85m;
			decSBHeadingMin = 52m;
			decSBJumpMax = 92m;
			decSBJumpMin = 47m;
			decSBTechniqueMax = 88m;
			decSBTechniqueMin = 56m;
			decSBAggressivenessMax = 88m;
			decSBAggressivenessMin = 53m;
			decSBMentalityMax = 84m;
			decSBMentalityMin = 57m;
			decSBCooperationMax = 86m;
			decSBCooperationMin = 54m;
			decSBStarPlayer = 12.5m;
			decDMFAttackMax = 85m;
			decDMFAttackMin = 50m;
			decDMFDefenseMax = 89m;
			decDMFDefenseMin = 57m;
			decDMFBodyBalanceMax = 95m;
			decDMFBodyBalanceMin = 54m;
			decDMFStaminaMax = 96m;
			decDMFStaminaMin = 53m;
			decDMFTopSpeedMax = 90m;
			decDMFTopSpeedMin = 51m;
			decDMFAccelerationMax = 86m;
			decDMFAccelerationMin = 45m;
			decDMFResponseMax = 88m;
			decDMFResponseMin = 55m;
			decDMFAgilityMax = 86m;
			decDMFAgilityMin = 51m;
			decDMFDribblePrecisionMax = 88m;
			decDMFDribblePrecisionMin = 54m;
			decDMFDribbleSpeedMax = 82m;
			decDMFDribbleSpeedMin = 53m;
			decDMFShortPassPrecisionMax = 94m;
			decDMFShortPassPrecisionMin = 53m;
			decDMFShortPassSpeedMax = 85m;
			decDMFShortPassSpeedMin = 53m;
			decDMFLongPassPrecisionMax = 95m;
			decDMFLongPassPrecisionMin = 56m;
			decDMFLongPassSpeedMax = 91m;
			decDMFLongPassSpeedMin = 54m;
			decDMFShotPrecisionMax = 85m;
			decDMFShotPrecisionMin = 49m;
			decDMFShotPowerMax = 95m;
			decDMFShotPowerMin = 60m;
			decDMFShotTechniqueMax = 89m;
			decDMFShotTechniqueMin = 56m;
			decDMFFreeKickPrecisionMax = 90m;
			decDMFFreeKickPrecisionMin = 47m;
			decDMFBendMax = 85m;
			decDMFBendMin = 44m;
			decDMFHeadingMax = 91m;
			decDMFHeadingMin = 53m;
			decDMFJumpMax = 92m;
			decDMFJumpMin = 48m;
			decDMFTechniqueMax = 92m;
			decDMFTechniqueMin = 57m;
			decDMFAggressivenessMax = 83m;
			decDMFAggressivenessMin = 49m;
			decDMFMentalityMax = 93m;
			decDMFMentalityMin = 54m;
			decDMFCooperationMax = 92m;
			decDMFCooperationMin = 52m;
			decDMFStarPlayer = 13m;
			decSMFAttackMax = 89m;
			decSMFAttackMin = 57m;
			decSMFDefenseMax = 78m;
			decSMFDefenseMin = 38m;
			decSMFBodyBalanceMax = 90m;
			decSMFBodyBalanceMin = 50m;
			decSMFStaminaMax = 94m;
			decSMFStaminaMin = 50m;
			decSMFTopSpeedMax = 95m;
			decSMFTopSpeedMin = 53m;
			decSMFAccelerationMax = 94m;
			decSMFAccelerationMin = 50m;
			decSMFResponseMax = 87m;
			decSMFResponseMin = 56m;
			decSMFAgilityMax = 91m;
			decSMFAgilityMin = 51m;
			decSMFDribblePrecisionMax = 95m;
			decSMFDribblePrecisionMin = 60m;
			decSMFDribbleSpeedMax = 90m;
			decSMFDribbleSpeedMin = 60m;
			decSMFShortPassPrecisionMax = 90m;
			decSMFShortPassPrecisionMin = 56m;
			decSMFShortPassSpeedMax = 87m;
			decSMFShortPassSpeedMin = 54m;
			decSMFLongPassPrecisionMax = 93m;
			decSMFLongPassPrecisionMin = 59m;
			decSMFLongPassSpeedMax = 94m;
			decSMFLongPassSpeedMin = 57m;
			decSMFShotPrecisionMax = 87m;
			decSMFShotPrecisionMin = 52m;
			decSMFShotPowerMax = 93m;
			decSMFShotPowerMin = 64m;
			decSMFShotTechniqueMax = 84m;
			decSMFShotTechniqueMin = 56m;
			decSMFFreeKickPrecisionMax = 94m;
			decSMFFreeKickPrecisionMin = 49m;
			decSMFBendMax = 93m;
			decSMFBendMin = 46m;
			decSMFHeadingMax = 82m;
			decSMFHeadingMin = 50m;
			decSMFJumpMax = 89m;
			decSMFJumpMin = 48m;
			decSMFTechniqueMax = 91m;
			decSMFTechniqueMin = 59m;
			decSMFAggressivenessMax = 89m;
			decSMFAggressivenessMin = 56m;
			decSMFMentalityMax = 86m;
			decSMFMentalityMin = 58m;
			decSMFCooperationMax = 89m;
			decSMFCooperationMin = 53m;
			decSMFStarPlayer = 12.75m;
			decOMFAttackMax = 91m;
			decOMFAttackMin = 62m;
			decOMFDefenseMax = 75m;
			decOMFDefenseMin = 34m;
			decOMFBodyBalanceMax = 93m;
			decOMFBodyBalanceMin = 53m;
			decOMFStaminaMax = 92m;
			decOMFStaminaMin = 54m;
			decOMFTopSpeedMax = 89m;
			decOMFTopSpeedMin = 54m;
			decOMFAccelerationMax = 93m;
			decOMFAccelerationMin = 52m;
			decOMFResponseMax = 88m;
			decOMFResponseMin = 58m;
			decOMFAgilityMax = 91m;
			decOMFAgilityMin = 53m;
			decOMFDribblePrecisionMax = 98m;
			decOMFDribblePrecisionMin = 63m;
			decOMFDribbleSpeedMax = 90m;
			decOMFDribbleSpeedMin = 58m;
			decOMFShortPassPrecisionMax = 97m;
			decOMFShortPassPrecisionMin = 60m;
			decOMFShortPassSpeedMax = 87m;
			decOMFShortPassSpeedMin = 58m;
			decOMFLongPassPrecisionMax = 95m;
			decOMFLongPassPrecisionMin = 63m;
			decOMFLongPassSpeedMax = 90m;
			decOMFLongPassSpeedMin = 59m;
			decOMFShotPrecisionMax = 91m;
			decOMFShotPrecisionMin = 59m;
			decOMFShotPowerMax = 93m;
			decOMFShotPowerMin = 63m;
			decOMFShotTechniqueMax = 92m;
			decOMFShotTechniqueMin = 58m;
			decOMFFreeKickPrecisionMax = 95m;
			decOMFFreeKickPrecisionMin = 53m;
			decOMFBendMax = 95m;
			decOMFBendMin = 50m;
			decOMFHeadingMax = 85m;
			decOMFHeadingMin = 55m;
			decOMFJumpMax = 88m;
			decOMFJumpMin = 49m;
			decOMFTechniqueMax = 97m;
			decOMFTechniqueMin = 60m;
			decOMFAggressivenessMax = 90m;
			decOMFAggressivenessMin = 55m;
			decOMFMentalityMax = 87m;
			decOMFMentalityMin = 57m;
			decOMFCooperationMax = 90m;
			decOMFCooperationMin = 54m;
			decOMFStarPlayer = 13m;
			decWFAttackMax = 89m;
			decWFAttackMin = 70m;
			decWFDefenseMax = 61m;
			decWFDefenseMin = 33m;
			decWFBodyBalanceMax = 85m;
			decWFBodyBalanceMin = 53m;
			decWFStaminaMax = 90m;
			decWFStaminaMin = 59m;
			decWFTopSpeedMax = 95m;
			decWFTopSpeedMin = 66m;
			decWFAccelerationMax = 93m;
			decWFAccelerationMin = 63m;
			decWFResponseMax = 91m;
			decWFResponseMin = 64m;
			decWFAgilityMax = 90m;
			decWFAgilityMin = 64m;
			decWFDribblePrecisionMax = 94m;
			decWFDribblePrecisionMin = 70m;
			decWFDribbleSpeedMax = 93m;
			decWFDribbleSpeedMin = 71m;
			decWFShortPassPrecisionMax = 89m;
			decWFShortPassPrecisionMin = 62m;
			decWFShortPassSpeedMax = 84m;
			decWFShortPassSpeedMin = 62m;
			decWFLongPassPrecisionMax = 90m;
			decWFLongPassPrecisionMin = 65m;
			decWFLongPassSpeedMax = 87m;
			decWFLongPassSpeedMin = 64m;
			decWFShotPrecisionMax = 88m;
			decWFShotPrecisionMin = 64m;
			decWFShotPowerMax = 90m;
			decWFShotPowerMin = 70m;
			decWFShotTechniqueMax = 87m;
			decWFShotTechniqueMin = 61m;
			decWFFreeKickPrecisionMax = 87m;
			decWFFreeKickPrecisionMin = 53m;
			decWFBendMax = 85m;
			decWFBendMin = 56m;
			decWFHeadingMax = 81m;
			decWFHeadingMin = 60m;
			decWFJumpMax = 83m;
			decWFJumpMin = 52m;
			decWFTechniqueMax = 91m;
			decWFTechniqueMin = 69m;
			decWFAggressivenessMax = 92m;
			decWFAggressivenessMin = 66m;
			decWFMentalityMax = 77m;
			decWFMentalityMin = 61m;
			decWFCooperationMax = 81m;
			decWFCooperationMin = 56m;
			decWFStarPlayer = 12.75m;
			decSTCFAttackMax = 97m;
			decSTCFAttackMin = 68m;
			decSTCFDefenseMax = 67m;
			decSTCFDefenseMin = 27m;
			decSTCFBodyBalanceMax = 97m;
			decSTCFBodyBalanceMin = 50m;
			decSTCFStaminaMax = 92m;
			decSTCFStaminaMin = 50m;
			decSTCFTopSpeedMax = 96m;
			decSTCFTopSpeedMin = 54m;
			decSTCFAccelerationMax = 97m;
			decSTCFAccelerationMin = 50m;
			decSTCFResponseMax = 96m;
			decSTCFResponseMin = 61m;
			decSTCFAgilityMax = 96m;
			decSTCFAgilityMin = 52m;
			decSTCFDribblePrecisionMax = 95m;
			decSTCFDribblePrecisionMin = 59m;
			decSTCFDribbleSpeedMax = 94m;
			decSTCFDribbleSpeedMin = 57m;
			decSTCFShortPassPrecisionMax = 92m;
			decSTCFShortPassPrecisionMin = 54m;
			decSTCFShortPassSpeedMax = 87m;
			decSTCFShortPassSpeedMin = 54m;
			decSTCFLongPassPrecisionMax = 90m;
			decSTCFLongPassPrecisionMin = 55m;
			decSTCFLongPassSpeedMax = 89m;
			decSTCFLongPassSpeedMin = 54m;
			decSTCFShotPrecisionMax = 97m;
			decSTCFShotPrecisionMin = 60m;
			decSTCFShotPowerMax = 97m;
			decSTCFShotPowerMin = 61m;
			decSTCFShotTechniqueMax = 98m;
			decSTCFShotTechniqueMin = 59m;
			decSTCFFreeKickPrecisionMax = 94m;
			decSTCFFreeKickPrecisionMin = 46m;
			decSTCFBendMax = 95m;
			decSTCFBendMin = 42m;
			decSTCFHeadingMax = 97m;
			decSTCFHeadingMin = 58m;
			decSTCFJumpMax = 95m;
			decSTCFJumpMin = 50m;
			decSTCFTechniqueMax = 99m;
			decSTCFTechniqueMin = 58m;
			decSTCFAggressivenessMax = 95m;
			decSTCFAggressivenessMin = 59m;
			decSTCFMentalityMax = 91m;
			decSTCFMentalityMin = 57m;
			decSTCFCooperationMax = 90m;
			decSTCFCooperationMin = 51m;
			decSTCFStarPlayer = 13.5m;
			InitializeComponent();
		}
		private void Verter_Load(object sender, EventArgs e)
		{
			cmbPosition.SelectedIndex = 0;
			cmbCorners.SelectedIndex = 9;
			cmbCrossing.SelectedIndex = 9;
			cmbDribbling.SelectedIndex = 9;
			cmbFinishing.SelectedIndex = 9;
			cmbFirstTouch.SelectedIndex = 9;
			cmbFreeKicks.SelectedIndex = 9;
			cmbHeading.SelectedIndex = 9;
			cmbLongShots.SelectedIndex = 9;
			cmbLongThrows.SelectedIndex = 9;
			cmbMarking.SelectedIndex = 9;
			cmbPassing.SelectedIndex = 9;
			cmbPenaltyTaking.SelectedIndex = 9;
			cmbTackling.SelectedIndex = 9;
			cmbTechnique.SelectedIndex = 9;
			cmbAggression.SelectedIndex = 9;
			cmbAnticipation.SelectedIndex = 9;
			cmbBravery.SelectedIndex = 9;
			cmbComposure.SelectedIndex = 9;
			cmbConcentration.SelectedIndex = 9;
			cmbCreativity.SelectedIndex = 9;
			cmbDecisions.SelectedIndex = 9;
			cmbDetermination.SelectedIndex = 9;
			cmbFlair.SelectedIndex = 9;
			cmbInfluence.SelectedIndex = 9;
			cmbOffTheBall.SelectedIndex = 9;
			cmbPositioning.SelectedIndex = 9;
			cmbTeamwork.SelectedIndex = 9;
			cmbWorkRate.SelectedIndex = 9;
			cmbAcceleration.SelectedIndex = 9;
			cmbAgility.SelectedIndex = 9;
			cmbBalance.SelectedIndex = 9;
			cmbJumping.SelectedIndex = 9;
			cmbNaturalFitness.SelectedIndex = 9;
			cmbPace.SelectedIndex = 9;
			cmbStamina.SelectedIndex = 9;
			cmbStrength.SelectedIndex = 9;
			cmbPreferredFoot.SelectedIndex = 0;
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			checked
			{
				decimal fmStatsOverall = (decimal)((cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbHeading.SelectedIndex + cmbLongShots.SelectedIndex + cmbLongThrows.SelectedIndex + cmbMarking.SelectedIndex + cmbPassing.SelectedIndex + cmbPenaltyTaking.SelectedIndex + cmbTackling.SelectedIndex + cmbTechnique.SelectedIndex + cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbCreativity.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbFlair.SelectedIndex + cmbInfluence.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPositioning.SelectedIndex + cmbTeamwork.SelectedIndex + cmbWorkRate.SelectedIndex + cmbAcceleration.SelectedIndex + cmbAgility.SelectedIndex + cmbBalance.SelectedIndex + cmbJumping.SelectedIndex + cmbNaturalFitness.SelectedIndex + cmbPace.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + 36) / 36.0);
				int condition = (int)Math.Round(5.0 * ((double)(cmbNaturalFitness.SelectedIndex + 1) * 0.4) / 8.0 + 3.0);
				if (condition > 7)
				{
					frmWEPES.lblStabilityOfCondition.ForeColor = Color.Red;
					frmWEPES.lblStabilityOfCondition.Text = 8.ToString();
				}
				else if (condition > 6)
				{
					frmWEPES.lblStabilityOfCondition.ForeColor = Color.Orange;
					frmWEPES.lblStabilityOfCondition.Text = 7.ToString();
				}
				else
				{
					frmWEPES.lblStabilityOfCondition.ForeColor = Color.Empty;
					frmWEPES.lblStabilityOfCondition.Text = condition.ToString();
				}
				int consistency = (int)Math.Round(5.0 * ((double)(cmbComposure.SelectedIndex + cmbDetermination.SelectedIndex + 2) / 2.0 * 0.4) / 8.0 + 3.0);
				if (consistency > 7)
				{
					frmWEPES.lblStabilityOfPlay.ForeColor = Color.Red;
					frmWEPES.lblStabilityOfPlay.Text = 8.ToString();
				}
				else if (consistency > 6)
				{
					frmWEPES.lblStabilityOfPlay.ForeColor = Color.Orange;
					frmWEPES.lblStabilityOfPlay.Text = 7.ToString();
				}
				else
				{
					frmWEPES.lblStabilityOfPlay.ForeColor = Color.Empty;
					frmWEPES.lblStabilityOfPlay.Text = consistency.ToString();
				}
				if ((cmbPreferredFoot.SelectedIndex == 0) | (cmbPreferredFoot.SelectedIndex == 2))
				{
					if (cmbTechnique.SelectedIndex < 14)
					{
						frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Empty;
						frmWEPES.lblSecondFootFrequency.ForeColor = Color.Empty;
						frmWEPES.lblSecondFootAccuracy.Text = 5.ToString();
						frmWEPES.lblSecondFootFrequency.Text = 5.ToString();
					}
					else
					{
						frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Empty;
						frmWEPES.lblSecondFootFrequency.ForeColor = Color.Empty;
						frmWEPES.lblSecondFootAccuracy.Text = 6.ToString();
						frmWEPES.lblSecondFootFrequency.Text = 6.ToString();
					}
				}
				else if ((cmbPreferredFoot.SelectedIndex == 1) | (cmbPreferredFoot.SelectedIndex == 3))
				{
					if (cmbTechnique.SelectedIndex < 14)
					{
						frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Empty;
						frmWEPES.lblSecondFootFrequency.ForeColor = Color.Empty;
						frmWEPES.lblSecondFootAccuracy.Text = 3.ToString();
						frmWEPES.lblSecondFootFrequency.Text = 3.ToString();
					}
					else
					{
						frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Empty;
						frmWEPES.lblSecondFootFrequency.ForeColor = Color.Empty;
						frmWEPES.lblSecondFootAccuracy.Text = 4.ToString();
						frmWEPES.lblSecondFootFrequency.Text = 4.ToString();
					}
				}
				else if (cmbTechnique.SelectedIndex < 14)
				{
					frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Red;
					frmWEPES.lblSecondFootAccuracy.Text = 7.ToString();
					frmWEPES.lblSecondFootFrequency.ForeColor = Color.Red;
					frmWEPES.lblSecondFootFrequency.Text = 7.ToString();
				}
				else
				{
					frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Red;
					frmWEPES.lblSecondFootAccuracy.Text = 8.ToString();
					frmWEPES.lblSecondFootFrequency.ForeColor = Color.Red;
					frmWEPES.lblSecondFootFrequency.Text = 8.ToString();
				}
				int balance = 0;
				int stamina = 0;
				int topSpeed = 0;
				int acceleration = 0;
				int agility = 0;
				int jump = 0;
				int attack = 0;
				int defence = 0;
				int response = 0;
				int dribbleAccuracy = 0;
				int dribbleSpeed = 0;
				int shortPassAccuracy = 0;
				int shortPassSpeed = 0;
				int longPassAccuracy = 0;
				int longPassSpeed = 0;
				int shotAccuracy = 0;
				int shotPower = 0;
				int shotTechnique = 0;
				int freeKickAccuracy = 0;
				int curling = 0;
				int header = 0;
				int technique = 0;
				int aggression = 0;
				int mentality = 0;
				int teamwork = 0;
				if (cmbPosition.SelectedIndex == 0)
				{
					balance = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBBodyBalanceMax, decCBBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBBodyBalanceMin));
					stamina = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBStaminaMax, decCBStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBStaminaMin));
					topSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBTopSpeedMax, decCBTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBTopSpeedMin));
					acceleration = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAccelerationMax, decCBAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBAccelerationMin));
					agility = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAgilityMax, decCBAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBAgilityMin));
					jump = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBJumpMax, decCBJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBJumpMin));
					if (decimal.Compare(fmStatsOverall, decCBStarPlayer) >= 0)
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAttackMax, decCBAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decCBAttackMin));
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDefenseMax, decCBDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decCBDefenseMin));
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBResponseMax, decCBResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBResponseMin));
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDribblePrecisionMax, decCBDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBDribblePrecisionMin));
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDribbleSpeedMax, decCBDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decCBDribbleSpeedMin));
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShortPassPrecisionMax, decCBShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBShortPassPrecisionMin));
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShortPassSpeedMax, decCBShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShortPassSpeedMin));
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBLongPassPrecisionMax, decCBLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBLongPassPrecisionMin));
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBLongPassSpeedMax, decCBLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBLongPassSpeedMin));
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotPrecisionMax, decCBShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBShotPrecisionMin));
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotPowerMax, decCBShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShotPowerMin));
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotTechniqueMax, decCBShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShotTechniqueMin));
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBFreeKickPrecisionMax, decCBFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBFreeKickPrecisionMin));
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBBendMax, decCBBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBBendMin));
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBHeadingMax, decCBHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBHeadingMin));
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBTechniqueMax, decCBTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBTechniqueMin));
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAggressivenessMax, decCBAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBAggressivenessMin));
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBMentalityMax, decCBMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decCBMentalityMin));
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBCooperationMax, decCBCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBCooperationMin));
					}
					else
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAttackMax, decCBAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decCBAttackMin) - 5.0);
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDefenseMax, decCBDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decCBDefenseMin) - 5.0);
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBResponseMax, decCBResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBResponseMin) - 5.0);
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDribblePrecisionMax, decCBDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBDribblePrecisionMin) - 5.0);
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDribbleSpeedMax, decCBDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decCBDribbleSpeedMin) - 5.0);
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShortPassPrecisionMax, decCBShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBShortPassPrecisionMin) - 5.0);
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShortPassSpeedMax, decCBShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShortPassSpeedMin) - 5.0);
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBLongPassPrecisionMax, decCBLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBLongPassPrecisionMin) - 5.0);
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBLongPassSpeedMax, decCBLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBLongPassSpeedMin) - 5.0);
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotPrecisionMax, decCBShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBShotPrecisionMin) - 5.0);
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotPowerMax, decCBShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShotPowerMin) - 5.0);
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotTechniqueMax, decCBShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShotTechniqueMin) - 5.0);
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBFreeKickPrecisionMax, decCBFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBFreeKickPrecisionMin) - 5.0);
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBBendMax, decCBBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBBendMin) - 5.0);
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBHeadingMax, decCBHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBHeadingMin) - 5.0);
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBTechniqueMax, decCBTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBTechniqueMin) - 5.0);
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAggressivenessMax, decCBAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBAggressivenessMin) - 5.0);
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBMentalityMax, decCBMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decCBMentalityMin) - 5.0);
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBCooperationMax, decCBCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBCooperationMin) - 5.0);
					}
				}
				if (cmbPosition.SelectedIndex == 1)
				{
					balance = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBBodyBalanceMax, decSBBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBBodyBalanceMin));
					stamina = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBStaminaMax, decSBStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBStaminaMin));
					topSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBTopSpeedMax, decSBTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBTopSpeedMin));
					agility = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAgilityMax, decSBAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBAgilityMin));
					acceleration = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAccelerationMax, decSBAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBAccelerationMin));
					jump = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBJumpMax, decSBJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBJumpMin));
					if (decimal.Compare(fmStatsOverall, decSBStarPlayer) >= 0)
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAttackMax, decSBAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSBAttackMin));
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDefenseMax, decSBDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSBDefenseMin));
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBResponseMax, decSBResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBResponseMin));
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDribblePrecisionMax, decSBDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBDribblePrecisionMin));
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDribbleSpeedMax, decSBDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSBDribbleSpeedMin));
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShortPassPrecisionMax, decSBShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBShortPassPrecisionMin));
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShortPassSpeedMax, decSBShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShortPassSpeedMin));
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBLongPassPrecisionMax, decSBLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBLongPassPrecisionMin));
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBLongPassSpeedMax, decSBLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBLongPassSpeedMin));
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotPrecisionMax, decSBShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBShotPrecisionMin));
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotPowerMax, decSBShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShotPowerMin));
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotTechniqueMax, decSBShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShotTechniqueMin));
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBFreeKickPrecisionMax, decSBFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBFreeKickPrecisionMin));
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBBendMax, decSBBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBBendMin));
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBHeadingMax, decSBHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBHeadingMin));
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBTechniqueMax, decSBTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBTechniqueMin));
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAggressivenessMax, decSBAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBAggressivenessMin));
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBMentalityMax, decSBMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSBMentalityMin));
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBCooperationMax, decSBCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBCooperationMin));
					}
					else
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAttackMax, decSBAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSBAttackMin) - 5.0);
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDefenseMax, decSBDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSBDefenseMin) - 5.0);
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBResponseMax, decSBResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBResponseMin) - 5.0);
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDribblePrecisionMax, decSBDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBDribblePrecisionMin) - 5.0);
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDribbleSpeedMax, decSBDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSBDribbleSpeedMin) - 5.0);
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShortPassPrecisionMax, decSBShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBShortPassPrecisionMin) - 5.0);
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShortPassSpeedMax, decSBShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShortPassSpeedMin) - 5.0);
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBLongPassPrecisionMax, decSBLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBLongPassPrecisionMin) - 5.0);
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBLongPassSpeedMax, decSBLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBLongPassSpeedMin) - 5.0);
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotPrecisionMax, decSBShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBShotPrecisionMin) - 5.0);
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotPowerMax, decSBShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShotPowerMin) - 5.0);
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotTechniqueMax, decSBShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShotTechniqueMin) - 5.0);
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBFreeKickPrecisionMax, decSBFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBFreeKickPrecisionMin) - 5.0);
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBBendMax, decSBBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBBendMin) - 5.0);
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBHeadingMax, decSBHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBHeadingMin) - 5.0);
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBTechniqueMax, decSBTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBTechniqueMin) - 5.0);
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAggressivenessMax, decSBAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBAggressivenessMin) - 5.0);
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBMentalityMax, decSBMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSBMentalityMin) - 5.0);
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBCooperationMax, decSBCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBCooperationMin) - 5.0);
					}
				}
				if (cmbPosition.SelectedIndex == 2)
				{
					balance = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFBodyBalanceMax, decDMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBodyBalanceMin));
					stamina = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFStaminaMax, decDMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFStaminaMin));
					topSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFTopSpeedMax, decDMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTopSpeedMin));
					acceleration = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAccelerationMax, decDMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAccelerationMin));
					agility = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAgilityMax, decDMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAgilityMin));
					jump = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFJumpMax, decDMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFJumpMin));
					if (decimal.Compare(fmStatsOverall, decDMFStarPlayer) >= 0)
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAttackMax, decDMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFAttackMin));
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDefenseMax, decDMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDefenseMin));
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFResponseMax, decDMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFResponseMin));
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDribblePrecisionMax, decDMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFDribblePrecisionMin));
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDribbleSpeedMax, decDMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDribbleSpeedMin));
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShortPassPrecisionMax, decDMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShortPassPrecisionMin));
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShortPassSpeedMax, decDMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShortPassSpeedMin));
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFLongPassPrecisionMax, decDMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFLongPassPrecisionMin));
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFLongPassSpeedMax, decDMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFLongPassSpeedMin));
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotPrecisionMax, decDMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShotPrecisionMin));
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotPowerMax, decDMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotPowerMin));
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotTechniqueMax, decDMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotTechniqueMin));
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFFreeKickPrecisionMax, decDMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFFreeKickPrecisionMin));
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFBendMax, decDMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBendMin));
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFHeadingMax, decDMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFHeadingMin));
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFTechniqueMax, decDMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTechniqueMin));
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAggressivenessMax, decDMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAggressivenessMin));
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFMentalityMax, decDMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFMentalityMin));
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFCooperationMax, decDMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFCooperationMin));
					}
					else
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAttackMax, decDMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFAttackMin) - 5.0);
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDefenseMax, decDMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDefenseMin) - 5.0);
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFResponseMax, decDMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFResponseMin) - 5.0);
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDribblePrecisionMax, decDMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFDribblePrecisionMin) - 5.0);
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDribbleSpeedMax, decDMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDribbleSpeedMin) - 5.0);
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShortPassPrecisionMax, decDMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShortPassPrecisionMin) - 5.0);
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShortPassSpeedMax, decDMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShortPassSpeedMin) - 5.0);
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFLongPassPrecisionMax, decDMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFLongPassPrecisionMin) - 5.0);
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFLongPassSpeedMax, decDMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFLongPassSpeedMin) - 5.0);
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotPrecisionMax, decDMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShotPrecisionMin) - 5.0);
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotPowerMax, decDMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotPowerMin) - 5.0);
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotTechniqueMax, decDMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotTechniqueMin) - 5.0);
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFFreeKickPrecisionMax, decDMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFFreeKickPrecisionMin) - 5.0);
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFBendMax, decDMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBendMin) - 5.0);
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFHeadingMax, decDMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFHeadingMin) - 5.0);
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFTechniqueMax, decDMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTechniqueMin) - 5.0);
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAggressivenessMax, decDMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAggressivenessMin) - 5.0);
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFMentalityMax, decDMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFMentalityMin) - 5.0);
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFCooperationMax, decDMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFCooperationMin) - 5.0);
					}
				}
				if (cmbPosition.SelectedIndex == 3)
				{
					balance = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFBodyBalanceMax, decDMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBodyBalanceMin) + (Convert.ToDouble(decimal.Subtract(decSMFBodyBalanceMax, decSMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBodyBalanceMin)) + (Convert.ToDouble(decimal.Subtract(decOMFBodyBalanceMax, decOMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBodyBalanceMin))) / 3.0);
					stamina = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFStaminaMax, decDMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFStaminaMin) + (Convert.ToDouble(decimal.Subtract(decSMFStaminaMax, decSMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFStaminaMin)) + (Convert.ToDouble(decimal.Subtract(decOMFStaminaMax, decOMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFStaminaMin))) / 3.0);
					topSpeed = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFTopSpeedMax, decDMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTopSpeedMin) + (Convert.ToDouble(decimal.Subtract(decSMFTopSpeedMax, decSMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTopSpeedMin)) + (Convert.ToDouble(decimal.Subtract(decOMFTopSpeedMax, decOMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTopSpeedMin))) / 3.0);
					acceleration = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAccelerationMax, decDMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAccelerationMin) + (Convert.ToDouble(decimal.Subtract(decSMFAccelerationMax, decSMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAccelerationMin)) + (Convert.ToDouble(decimal.Subtract(decOMFAccelerationMax, decOMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAccelerationMin))) / 3.0);
					agility = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAgilityMax, decDMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAgilityMin) + (Convert.ToDouble(decimal.Subtract(decSMFAgilityMax, decSMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAgilityMin)) + (Convert.ToDouble(decimal.Subtract(decOMFAgilityMax, decOMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAgilityMin))) / 3.0);
					jump = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFJumpMax, decDMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFJumpMin) + (Convert.ToDouble(decimal.Subtract(decSMFJumpMax, decSMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFJumpMin)) + (Convert.ToDouble(decimal.Subtract(decOMFJumpMax, decOMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFJumpMin))) / 3.0);
					if (decimal.Compare(fmStatsOverall, decimal.Divide(decimal.Add(decimal.Add(decDMFStarPlayer, decSMFStarPlayer), decOMFStarPlayer), 3m)) >= 0)
					{
						attack = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAttackMax, decDMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFAttackMin) + (Convert.ToDouble(decimal.Subtract(decSMFAttackMax, decSMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFAttackMin)) + (Convert.ToDouble(decimal.Subtract(decOMFAttackMax, decOMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFAttackMin))) / 3.0);
						defence = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDefenseMax, decDMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDefenseMin) + (Convert.ToDouble(decimal.Subtract(decSMFDefenseMax, decSMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDefenseMin)) + (Convert.ToDouble(decimal.Subtract(decOMFDefenseMax, decOMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDefenseMin))) / 3.0);
						response = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFResponseMax, decDMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFResponseMin) + (Convert.ToDouble(decimal.Subtract(decSMFResponseMax, decSMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFResponseMin)) + (Convert.ToDouble(decimal.Subtract(decOMFResponseMax, decOMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFResponseMin))) / 3.0);
						dribbleAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDribblePrecisionMax, decDMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFDribblePrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFDribblePrecisionMax, decSMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFDribblePrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFDribblePrecisionMax, decOMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFDribblePrecisionMin))) / 3.0);
						dribbleSpeed = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDribbleSpeedMax, decDMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDribbleSpeedMin) + (Convert.ToDouble(decimal.Subtract(decSMFDribbleSpeedMax, decSMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDribbleSpeedMin)) + (Convert.ToDouble(decimal.Subtract(decOMFDribbleSpeedMax, decOMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDribbleSpeedMin))) / 3.0);
						shortPassAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShortPassPrecisionMax, decDMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShortPassPrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFShortPassPrecisionMax, decSMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShortPassPrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShortPassPrecisionMax, decOMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShortPassPrecisionMin))) / 3.0);
						shortPassSpeed = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShortPassSpeedMax, decDMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShortPassSpeedMin) + (Convert.ToDouble(decimal.Subtract(decSMFShortPassSpeedMax, decSMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShortPassSpeedMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShortPassSpeedMax, decOMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShortPassSpeedMin))) / 3.0);
						longPassAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFLongPassPrecisionMax, decDMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFLongPassPrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFLongPassPrecisionMax, decSMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFLongPassPrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFLongPassPrecisionMax, decOMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFLongPassPrecisionMin))) / 3.0);
						longPassSpeed = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFLongPassSpeedMax, decDMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFLongPassSpeedMin) + (Convert.ToDouble(decimal.Subtract(decSMFLongPassSpeedMax, decSMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFLongPassSpeedMin)) + (Convert.ToDouble(decimal.Subtract(decOMFLongPassSpeedMax, decOMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFLongPassSpeedMin))) / 3.0);
						shotAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotPrecisionMax, decDMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShotPrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFShotPrecisionMax, decSMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShotPrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShotPrecisionMax, decOMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShotPrecisionMin))) / 3.0);
						shotPower = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotPowerMax, decDMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotPowerMin) + (Convert.ToDouble(decimal.Subtract(decSMFShotPowerMax, decSMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotPowerMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShotPowerMax, decOMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotPowerMin))) / 3.0);
						shotTechnique = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotTechniqueMax, decDMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotTechniqueMin) + (Convert.ToDouble(decimal.Subtract(decSMFShotTechniqueMax, decSMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotTechniqueMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShotTechniqueMax, decOMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotTechniqueMin))) / 3.0);
						freeKickAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFFreeKickPrecisionMax, decDMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFFreeKickPrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFFreeKickPrecisionMax, decSMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFFreeKickPrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFFreeKickPrecisionMax, decOMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFFreeKickPrecisionMin))) / 3.0);
						curling = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFBendMax, decDMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBendMin) + (Convert.ToDouble(decimal.Subtract(decSMFBendMax, decSMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBendMin)) + (Convert.ToDouble(decimal.Subtract(decOMFBendMax, decOMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBendMin))) / 3.0);
						header = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFHeadingMax, decDMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFHeadingMin) + (Convert.ToDouble(decimal.Subtract(decSMFHeadingMax, decSMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFHeadingMin)) + (Convert.ToDouble(decimal.Subtract(decOMFHeadingMax, decOMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFHeadingMin))) / 3.0);
						technique = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFTechniqueMax, decDMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTechniqueMin) + (Convert.ToDouble(decimal.Subtract(decSMFTechniqueMax, decSMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTechniqueMin)) + (Convert.ToDouble(decimal.Subtract(decOMFTechniqueMax, decOMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTechniqueMin))) / 3.0);
						aggression = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAggressivenessMax, decDMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAggressivenessMin) + (Convert.ToDouble(decimal.Subtract(decSMFAggressivenessMax, decSMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAggressivenessMin)) + (Convert.ToDouble(decimal.Subtract(decOMFAggressivenessMax, decOMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAggressivenessMin))) / 3.0);
						mentality = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFMentalityMax, decDMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFMentalityMin) + (Convert.ToDouble(decimal.Subtract(decSMFMentalityMax, decSMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFMentalityMin)) + (Convert.ToDouble(decimal.Subtract(decOMFMentalityMax, decOMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFMentalityMin))) / 3.0);
						teamwork = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFCooperationMax, decDMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFCooperationMin) + (Convert.ToDouble(decimal.Subtract(decSMFCooperationMax, decSMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFCooperationMin)) + (Convert.ToDouble(decimal.Subtract(decOMFCooperationMax, decOMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFCooperationMin))) / 3.0);
					}
					else
					{
						attack = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAttackMax, decDMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFAttackMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFAttackMax, decSMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFAttackMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFAttackMax, decOMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFAttackMin) - 5.0)) / 3.0);
						defence = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDefenseMax, decDMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDefenseMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFDefenseMax, decSMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDefenseMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFDefenseMax, decOMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDefenseMin) - 5.0)) / 3.0);
						response = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFResponseMax, decDMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFResponseMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFResponseMax, decSMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFResponseMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFResponseMax, decOMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFResponseMin) - 5.0)) / 3.0);
						dribbleAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDribblePrecisionMax, decDMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFDribblePrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFDribblePrecisionMax, decSMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFDribblePrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFDribblePrecisionMax, decOMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFDribblePrecisionMin) - 5.0)) / 3.0);
						dribbleSpeed = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDribbleSpeedMax, decDMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDribbleSpeedMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFDribbleSpeedMax, decSMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDribbleSpeedMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFDribbleSpeedMax, decOMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDribbleSpeedMin) - 5.0)) / 3.0);
						shortPassAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShortPassPrecisionMax, decDMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShortPassPrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShortPassPrecisionMax, decSMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShortPassPrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShortPassPrecisionMax, decOMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShortPassPrecisionMin) - 5.0)) / 3.0);
						shortPassSpeed = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShortPassSpeedMax, decDMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShortPassSpeedMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShortPassSpeedMax, decSMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShortPassSpeedMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShortPassSpeedMax, decOMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShortPassSpeedMin) - 5.0)) / 3.0);
						longPassAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFLongPassPrecisionMax, decDMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFLongPassPrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFLongPassPrecisionMax, decSMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFLongPassPrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFLongPassPrecisionMax, decOMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFLongPassPrecisionMin) - 5.0)) / 3.0);
						longPassSpeed = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFLongPassSpeedMax, decDMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFLongPassSpeedMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFLongPassSpeedMax, decSMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFLongPassSpeedMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFLongPassSpeedMax, decOMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFLongPassSpeedMin) - 5.0)) / 3.0);
						shotAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotPrecisionMax, decDMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShotPrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShotPrecisionMax, decSMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShotPrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShotPrecisionMax, decOMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShotPrecisionMin) - 5.0)) / 3.0);
						shotPower = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotPowerMax, decDMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotPowerMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShotPowerMax, decSMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotPowerMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShotPowerMax, decOMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotPowerMin) - 5.0)) / 3.0);
						shotTechnique = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotTechniqueMax, decDMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotTechniqueMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShotTechniqueMax, decSMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotTechniqueMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShotTechniqueMax, decOMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotTechniqueMin) - 5.0)) / 3.0);
						freeKickAccuracy = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFFreeKickPrecisionMax, decDMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFFreeKickPrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFFreeKickPrecisionMax, decSMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFFreeKickPrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFFreeKickPrecisionMax, decOMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFFreeKickPrecisionMin) - 5.0)) / 3.0);
						curling = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFBendMax, decDMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBendMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFBendMax, decSMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBendMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFBendMax, decOMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBendMin) - 5.0)) / 3.0);
						header = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFHeadingMax, decDMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFHeadingMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFHeadingMax, decSMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFHeadingMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFHeadingMax, decOMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFHeadingMin) - 5.0)) / 3.0);
						technique = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFTechniqueMax, decDMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTechniqueMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFTechniqueMax, decSMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTechniqueMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFTechniqueMax, decOMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTechniqueMin) - 5.0)) / 3.0);
						aggression = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAggressivenessMax, decDMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAggressivenessMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFAggressivenessMax, decSMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAggressivenessMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFAggressivenessMax, decOMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAggressivenessMin) - 5.0)) / 3.0);
						mentality = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFMentalityMax, decDMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFMentalityMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFMentalityMax, decSMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFMentalityMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFMentalityMax, decOMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFMentalityMin) - 5.0)) / 3.0);
						teamwork = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFCooperationMax, decDMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFCooperationMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFCooperationMax, decSMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFCooperationMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFCooperationMax, decOMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFCooperationMin) - 5.0)) / 3.0);
					}
				}
				if (cmbPosition.SelectedIndex == 4)
				{
					balance = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFBodyBalanceMax, decSMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBodyBalanceMin));
					stamina = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFStaminaMax, decSMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFStaminaMin));
					topSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFTopSpeedMax, decSMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTopSpeedMin));
					acceleration = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAccelerationMax, decSMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAccelerationMin));
					agility = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAgilityMax, decSMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAgilityMin));
					jump = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFJumpMax, decSMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFJumpMin));
					if (decimal.Compare(fmStatsOverall, decSMFStarPlayer) >= 0)
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAttackMax, decSMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFAttackMin));
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDefenseMax, decSMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDefenseMin));
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFResponseMax, decSMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFResponseMin));
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDribblePrecisionMax, decSMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFDribblePrecisionMin));
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDribbleSpeedMax, decSMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDribbleSpeedMin));
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShortPassPrecisionMax, decSMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShortPassPrecisionMin));
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShortPassSpeedMax, decSMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShortPassSpeedMin));
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFLongPassPrecisionMax, decSMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFLongPassPrecisionMin));
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFLongPassSpeedMax, decSMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFLongPassSpeedMin));
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotPrecisionMax, decSMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShotPrecisionMin));
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotPowerMax, decSMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotPowerMin));
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotTechniqueMax, decSMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotTechniqueMin));
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFFreeKickPrecisionMax, decSMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFFreeKickPrecisionMin));
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFBendMax, decSMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBendMin));
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFHeadingMax, decSMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFHeadingMin));
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFTechniqueMax, decSMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTechniqueMin));
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAggressivenessMax, decSMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAggressivenessMin));
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFMentalityMax, decSMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFMentalityMin));
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFCooperationMax, decSMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFCooperationMin));
					}
					else
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAttackMax, decSMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFAttackMin) - 5.0);
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDefenseMax, decSMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDefenseMin) - 5.0);
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFResponseMax, decSMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFResponseMin) - 5.0);
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDribblePrecisionMax, decSMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFDribblePrecisionMin) - 5.0);
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDribbleSpeedMax, decSMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDribbleSpeedMin) - 5.0);
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShortPassPrecisionMax, decSMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShortPassPrecisionMin) - 5.0);
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShortPassSpeedMax, decSMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShortPassSpeedMin) - 5.0);
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFLongPassPrecisionMax, decSMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFLongPassPrecisionMin) - 5.0);
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFLongPassSpeedMax, decSMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFLongPassSpeedMin) - 5.0);
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotPrecisionMax, decSMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShotPrecisionMin) - 5.0);
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotPowerMax, decSMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotPowerMin) - 5.0);
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotTechniqueMax, decSMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotTechniqueMin) - 5.0);
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFFreeKickPrecisionMax, decSMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFFreeKickPrecisionMin) - 5.0);
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFBendMax, decSMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBendMin) - 5.0);
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFHeadingMax, decSMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFHeadingMin) - 5.0);
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFTechniqueMax, decSMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTechniqueMin) - 5.0);
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAggressivenessMax, decSMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAggressivenessMin) - 5.0);
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFMentalityMax, decSMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFMentalityMin) - 5.0);
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFCooperationMax, decSMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFCooperationMin) - 5.0);
					}
				}
				if (cmbPosition.SelectedIndex == 5)
				{
					balance = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFBodyBalanceMax, decOMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBodyBalanceMin));
					stamina = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFStaminaMax, decOMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFStaminaMin));
					topSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFTopSpeedMax, decOMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTopSpeedMin));
					acceleration = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAccelerationMax, decOMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAccelerationMin));
					agility = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAgilityMax, decOMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAgilityMin));
					jump = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFJumpMax, decOMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFJumpMin));
					if (decimal.Compare(fmStatsOverall, decOMFStarPlayer) >= 0)
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAttackMax, decOMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFAttackMin));
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDefenseMax, decOMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDefenseMin));
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFResponseMax, decOMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFResponseMin));
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDribblePrecisionMax, decOMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFDribblePrecisionMin));
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDribbleSpeedMax, decOMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDribbleSpeedMin));
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShortPassPrecisionMax, decOMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShortPassPrecisionMin));
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShortPassSpeedMax, decOMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShortPassSpeedMin));
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFLongPassPrecisionMax, decOMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFLongPassPrecisionMin));
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFLongPassSpeedMax, decOMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFLongPassSpeedMin));
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotPrecisionMax, decOMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShotPrecisionMin));
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotPowerMax, decOMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotPowerMin));
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotTechniqueMax, decOMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotTechniqueMin));
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFFreeKickPrecisionMax, decOMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFFreeKickPrecisionMin));
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFBendMax, decOMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBendMin));
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFHeadingMax, decOMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFHeadingMin));
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFTechniqueMax, decOMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTechniqueMin));
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAggressivenessMax, decOMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAggressivenessMin));
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFMentalityMax, decOMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFMentalityMin));
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFCooperationMax, decOMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFCooperationMin));
					}
					else
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAttackMax, decOMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFAttackMin) - 5.0);
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDefenseMax, decOMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDefenseMin) - 5.0);
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFResponseMax, decOMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFResponseMin) - 5.0);
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDribblePrecisionMax, decOMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFDribblePrecisionMin) - 5.0);
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDribbleSpeedMax, decOMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDribbleSpeedMin) - 5.0);
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShortPassPrecisionMax, decOMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShortPassPrecisionMin) - 5.0);
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShortPassSpeedMax, decOMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShortPassSpeedMin) - 5.0);
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFLongPassPrecisionMax, decOMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFLongPassPrecisionMin) - 5.0);
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFLongPassSpeedMax, decOMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFLongPassSpeedMin) - 5.0);
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotPrecisionMax, decOMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShotPrecisionMin) - 5.0);
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotPowerMax, decOMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotPowerMin) - 5.0);
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotTechniqueMax, decOMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotTechniqueMin) - 5.0);
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFFreeKickPrecisionMax, decOMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFFreeKickPrecisionMin) - 5.0);
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFBendMax, decOMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBendMin) - 5.0);
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFHeadingMax, decOMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFHeadingMin) - 5.0);
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFTechniqueMax, decOMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTechniqueMin) - 5.0);
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAggressivenessMax, decOMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAggressivenessMin) - 5.0);
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFMentalityMax, decOMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFMentalityMin) - 5.0);
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFCooperationMax, decOMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFCooperationMin) - 5.0);
					}
				}
				if (cmbPosition.SelectedIndex == 6)
				{
					balance = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFBodyBalanceMax, decWFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFBodyBalanceMin));
					stamina = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFStaminaMax, decWFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFStaminaMin));
					topSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFTopSpeedMax, decWFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFTopSpeedMin));
					acceleration = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAccelerationMax, decWFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFAccelerationMin));
					agility = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAgilityMax, decWFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFAgilityMin));
					jump = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFJumpMax, decWFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFJumpMin));
					if (decimal.Compare(fmStatsOverall, decWFStarPlayer) >= 0)
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAttackMax, decWFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decWFAttackMin));
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDefenseMax, decWFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decWFDefenseMin));
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFResponseMax, decWFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFResponseMin));
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDribblePrecisionMax, decWFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFDribblePrecisionMin));
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDribbleSpeedMax, decWFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decWFDribbleSpeedMin));
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShortPassPrecisionMax, decWFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFShortPassPrecisionMin));
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShortPassSpeedMax, decWFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShortPassSpeedMin));
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFLongPassPrecisionMax, decWFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFLongPassPrecisionMin));
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFLongPassSpeedMax, decWFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFLongPassSpeedMin));
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotPrecisionMax, decWFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFShotPrecisionMin));
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotPowerMax, decWFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShotPowerMin));
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotTechniqueMax, decWFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShotTechniqueMin));
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFFreeKickPrecisionMax, decWFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFFreeKickPrecisionMin));
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFBendMax, decWFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFBendMin));
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFHeadingMax, decWFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFHeadingMin));
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFTechniqueMax, decWFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFTechniqueMin));
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAggressivenessMax, decWFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFAggressivenessMin));
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFMentalityMax, decWFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decWFMentalityMin));
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFCooperationMax, decWFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFCooperationMin));
					}
					else
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAttackMax, decWFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decWFAttackMin) - 5.0);
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDefenseMax, decWFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decWFDefenseMin) - 5.0);
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFResponseMax, decWFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFResponseMin) - 5.0);
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDribblePrecisionMax, decWFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFDribblePrecisionMin) - 5.0);
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDribbleSpeedMax, decWFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decWFDribbleSpeedMin) - 5.0);
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShortPassPrecisionMax, decWFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFShortPassPrecisionMin) - 5.0);
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShortPassSpeedMax, decWFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShortPassSpeedMin) - 5.0);
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFLongPassPrecisionMax, decWFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFLongPassPrecisionMin) - 5.0);
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFLongPassSpeedMax, decWFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFLongPassSpeedMin) - 5.0);
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotPrecisionMax, decWFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFShotPrecisionMin) - 5.0);
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotPowerMax, decWFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShotPowerMin) - 5.0);
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotTechniqueMax, decWFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShotTechniqueMin) - 5.0);
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFFreeKickPrecisionMax, decWFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFFreeKickPrecisionMin) - 5.0);
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFBendMax, decWFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFBendMin) - 5.0);
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFHeadingMax, decWFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFHeadingMin) - 5.0);
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFTechniqueMax, decWFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFTechniqueMin) - 5.0);
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAggressivenessMax, decWFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFAggressivenessMin) - 5.0);
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFMentalityMax, decWFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decWFMentalityMin) - 5.0);
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFCooperationMax, decWFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFCooperationMin) - 5.0);
					}
				}
				if (cmbPosition.SelectedIndex == 7)
				{
					balance = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFBodyBalanceMax, decSTCFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFBodyBalanceMin));
					stamina = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFStaminaMax, decSTCFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFStaminaMin));
					topSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFTopSpeedMax, decSTCFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFTopSpeedMin));
					acceleration = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAccelerationMax, decSTCFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFAccelerationMin));
					agility = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAgilityMax, decSTCFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFAgilityMin));
					jump = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFJumpMax, decSTCFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFJumpMin));
					if (decimal.Compare(fmStatsOverall, decSTCFStarPlayer) >= 0)
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAttackMax, decSTCFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFAttackMin));
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDefenseMax, decSTCFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFDefenseMin));
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFResponseMax, decSTCFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFResponseMin));
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDribblePrecisionMax, decSTCFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFDribblePrecisionMin));
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDribbleSpeedMax, decSTCFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFDribbleSpeedMin));
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShortPassPrecisionMax, decSTCFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFShortPassPrecisionMin));
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShortPassSpeedMax, decSTCFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShortPassSpeedMin));
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFLongPassPrecisionMax, decSTCFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFLongPassPrecisionMin));
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFLongPassSpeedMax, decSTCFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFLongPassSpeedMin));
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotPrecisionMax, decSTCFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFShotPrecisionMin));
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotPowerMax, decSTCFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShotPowerMin));
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotTechniqueMax, decSTCFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShotTechniqueMin));
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFFreeKickPrecisionMax, decSTCFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFFreeKickPrecisionMin));
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFBendMax, decSTCFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFBendMin));
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFHeadingMax, decSTCFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFHeadingMin));
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFTechniqueMax, decSTCFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFTechniqueMin));
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAggressivenessMax, decSTCFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFAggressivenessMin));
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFMentalityMax, decSTCFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFMentalityMin));
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFCooperationMax, decSTCFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFCooperationMin));
					}
					else
					{
						attack = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAttackMax, decSTCFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFAttackMin) - 5.0);
						defence = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDefenseMax, decSTCFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFDefenseMin) - 5.0);
						response = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFResponseMax, decSTCFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFResponseMin) - 5.0);
						dribbleAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDribblePrecisionMax, decSTCFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFDribblePrecisionMin) - 5.0);
						dribbleSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDribbleSpeedMax, decSTCFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFDribbleSpeedMin) - 5.0);
						shortPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShortPassPrecisionMax, decSTCFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFShortPassPrecisionMin) - 5.0);
						shortPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShortPassSpeedMax, decSTCFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShortPassSpeedMin) - 5.0);
						longPassAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFLongPassPrecisionMax, decSTCFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFLongPassPrecisionMin) - 5.0);
						longPassSpeed = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFLongPassSpeedMax, decSTCFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFLongPassSpeedMin) - 5.0);
						shotAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotPrecisionMax, decSTCFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFShotPrecisionMin) - 5.0);
						shotPower = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotPowerMax, decSTCFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShotPowerMin) - 5.0);
						shotTechnique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotTechniqueMax, decSTCFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShotTechniqueMin) - 5.0);
						freeKickAccuracy = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFFreeKickPrecisionMax, decSTCFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFFreeKickPrecisionMin) - 5.0);
						curling = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFBendMax, decSTCFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFBendMin) - 5.0);
						header = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFHeadingMax, decSTCFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFHeadingMin) - 5.0);
						technique = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFTechniqueMax, decSTCFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFTechniqueMin) - 5.0);
						aggression = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAggressivenessMax, decSTCFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFAggressivenessMin) - 5.0);
						mentality = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFMentalityMax, decSTCFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFMentalityMin) - 5.0);
						teamwork = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFCooperationMax, decSTCFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFCooperationMin) - 5.0);
					}
				}
				if (cmbPosition.SelectedIndex == 0)
				{
					frmWEPES.lblPosition.Text = "CB";
				}
				else if (cmbPosition.SelectedIndex == 1)
				{
					frmWEPES.lblPosition.Text = "SB";
				}
				else if (cmbPosition.SelectedIndex == 2)
				{
					frmWEPES.lblPosition.Text = "DMF";
				}
				else if (cmbPosition.SelectedIndex == 3)
				{
					frmWEPES.lblPosition.Text = "CMF";
				}
				else if (cmbPosition.SelectedIndex == 4)
				{
					frmWEPES.lblPosition.Text = "SMF";
				}
				else if (cmbPosition.SelectedIndex == 5)
				{
					frmWEPES.lblPosition.Text = "OMF";
				}
				else if (cmbPosition.SelectedIndex == 6)
				{
					frmWEPES.lblPosition.Text = "WF";
				}
				else
				{
					frmWEPES.lblPosition.Text = "ST/CF";
				}
				if (cmbPreferredFoot.SelectedIndex == 0)
				{
					frmWEPES.lblPreferredFoot.Text = "Right";
				}
				else if (cmbPreferredFoot.SelectedIndex == 1)
				{
					frmWEPES.lblPreferredFoot.Text = "Right";
				}
				else if (cmbPreferredFoot.SelectedIndex == 2)
				{
					frmWEPES.lblPreferredFoot.Text = "Left";
				}
				else if (cmbPreferredFoot.SelectedIndex == 3)
				{
					frmWEPES.lblPreferredFoot.Text = "Left";
				}
				else
				{
					frmWEPES.lblPreferredFoot.Text = "Either";
				}
				if (attack >= 95)
				{
					frmWEPES.lblAttack.ForeColor = Color.Red;
				}
				else if (attack >= 90)
				{
					frmWEPES.lblAttack.ForeColor = Color.Orange;
				}
				else if (attack >= 80)
				{
					frmWEPES.lblAttack.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblAttack.ForeColor = Color.Empty;
				}
				frmWEPES.lblAttack.Text = attack.ToString();
				if (defence >= 95)
				{
					frmWEPES.lblDefense.ForeColor = Color.Red;
				}
				else if (defence >= 90)
				{
					frmWEPES.lblDefense.ForeColor = Color.Orange;
				}
				else if (defence >= 80)
				{
					frmWEPES.lblDefense.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblDefense.ForeColor = Color.Empty;
				}
				frmWEPES.lblDefense.Text = defence.ToString();
				if (balance >= 95)
				{
					frmWEPES.lblBodyBalance.ForeColor = Color.Red;
				}
				else if (balance >= 90)
				{
					frmWEPES.lblBodyBalance.ForeColor = Color.Orange;
				}
				else if (balance >= 80)
				{
					frmWEPES.lblBodyBalance.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblBodyBalance.ForeColor = Color.Empty;
				}
				frmWEPES.lblBodyBalance.Text = balance.ToString();
				if (stamina >= 95)
				{
					frmWEPES.lblStamina.ForeColor = Color.Red;
				}
				else if (stamina >= 90)
				{
					frmWEPES.lblStamina.ForeColor = Color.Orange;
				}
				else if (stamina >= 80)
				{
					frmWEPES.lblStamina.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblStamina.ForeColor = Color.Empty;
				}
				frmWEPES.lblStamina.Text = stamina.ToString();
				if (topSpeed >= 95)
				{
					frmWEPES.lblTopSpeed.ForeColor = Color.Red;
				}
				else if (topSpeed >= 90)
				{
					frmWEPES.lblTopSpeed.ForeColor = Color.Orange;
				}
				else if (topSpeed >= 80)
				{
					frmWEPES.lblTopSpeed.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblTopSpeed.ForeColor = Color.Empty;
				}
				frmWEPES.lblTopSpeed.Text = topSpeed.ToString();
				if (acceleration >= 95)
				{
					frmWEPES.lblAcceleration.ForeColor = Color.Red;
				}
				else if (acceleration >= 90)
				{
					frmWEPES.lblAcceleration.ForeColor = Color.Orange;
				}
				else if (acceleration >= 80)
				{
					frmWEPES.lblAcceleration.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblAcceleration.ForeColor = Color.Empty;
				}
				frmWEPES.lblAcceleration.Text = acceleration.ToString();
				if (response >= 95)
				{
					frmWEPES.lblResponse.ForeColor = Color.Red;
				}
				else if (response >= 90)
				{
					frmWEPES.lblResponse.ForeColor = Color.Orange;
				}
				else if (response >= 80)
				{
					frmWEPES.lblResponse.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblResponse.ForeColor = Color.Empty;
				}
				frmWEPES.lblResponse.Text = response.ToString();
				if (agility >= 95)
				{
					frmWEPES.lblAgility.ForeColor = Color.Red;
				}
				else if (agility >= 90)
				{
					frmWEPES.lblAgility.ForeColor = Color.Orange;
				}
				else if (agility >= 80)
				{
					frmWEPES.lblAgility.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblAgility.ForeColor = Color.Empty;
				}
				frmWEPES.lblAgility.Text = agility.ToString();
				if (dribbleAccuracy >= 95)
				{
					frmWEPES.lblDribblePrecision.ForeColor = Color.Red;
				}
				else if (dribbleAccuracy >= 90)
				{
					frmWEPES.lblDribblePrecision.ForeColor = Color.Orange;
				}
				else if (dribbleAccuracy >= 80)
				{
					frmWEPES.lblDribblePrecision.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblDribblePrecision.ForeColor = Color.Empty;
				}
				frmWEPES.lblDribblePrecision.Text = dribbleAccuracy.ToString();
				if (dribbleSpeed >= 95)
				{
					frmWEPES.lblDribbleSpeed.ForeColor = Color.Red;
				}
				else if (dribbleSpeed >= 90)
				{
					frmWEPES.lblDribbleSpeed.ForeColor = Color.Orange;
				}
				else if (dribbleSpeed >= 80)
				{
					frmWEPES.lblDribbleSpeed.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblDribbleSpeed.ForeColor = Color.Empty;
				}
				frmWEPES.lblDribbleSpeed.Text = dribbleSpeed.ToString();
				if (shortPassAccuracy >= 95)
				{
					frmWEPES.lblShortPassPrecision.ForeColor = Color.Red;
				}
				else if (shortPassAccuracy >= 90)
				{
					frmWEPES.lblShortPassPrecision.ForeColor = Color.Orange;
				}
				else if (shortPassAccuracy >= 80)
				{
					frmWEPES.lblShortPassPrecision.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblShortPassPrecision.ForeColor = Color.Empty;
				}
				frmWEPES.lblShortPassPrecision.Text = shortPassAccuracy.ToString();
				if (shortPassSpeed >= 95)
				{
					frmWEPES.lblShortPassSpeed.ForeColor = Color.Red;
				}
				else if (shortPassSpeed >= 90)
				{
					frmWEPES.lblShortPassSpeed.ForeColor = Color.Orange;
				}
				else if (shortPassSpeed >= 80)
				{
					frmWEPES.lblShortPassSpeed.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblShortPassSpeed.ForeColor = Color.Empty;
				}
				frmWEPES.lblShortPassSpeed.Text = shortPassSpeed.ToString();
				if (longPassAccuracy >= 95)
				{
					frmWEPES.lblLongPassPrecision.ForeColor = Color.Red;
				}
				else if (longPassAccuracy >= 90)
				{
					frmWEPES.lblLongPassPrecision.ForeColor = Color.Orange;
				}
				else if (longPassAccuracy >= 80)
				{
					frmWEPES.lblLongPassPrecision.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblLongPassPrecision.ForeColor = Color.Empty;
				}
				frmWEPES.lblLongPassPrecision.Text = longPassAccuracy.ToString();
				if (longPassSpeed >= 95)
				{
					frmWEPES.lblLongPassSpeed.ForeColor = Color.Red;
				}
				else if (longPassSpeed >= 90)
				{
					frmWEPES.lblLongPassSpeed.ForeColor = Color.Orange;
				}
				else if (longPassSpeed >= 80)
				{
					frmWEPES.lblLongPassSpeed.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblLongPassSpeed.ForeColor = Color.Empty;
				}
				frmWEPES.lblLongPassSpeed.Text = longPassSpeed.ToString();
				if (shotAccuracy >= 95)
				{
					frmWEPES.lblShotPrecision.ForeColor = Color.Red;
				}
				else if (shotAccuracy >= 90)
				{
					frmWEPES.lblShotPrecision.ForeColor = Color.Orange;
				}
				else if (shotAccuracy >= 80)
				{
					frmWEPES.lblShotPrecision.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblShotPrecision.ForeColor = Color.Empty;
				}
				frmWEPES.lblShotPrecision.Text = shotAccuracy.ToString();
				if (shotPower >= 95)
				{
					frmWEPES.lblShotPower.ForeColor = Color.Red;
				}
				else if (shotPower >= 90)
				{
					frmWEPES.lblShotPower.ForeColor = Color.Orange;
				}
				else if (shotPower >= 80)
				{
					frmWEPES.lblShotPower.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblShotPower.ForeColor = Color.Empty;
				}
				frmWEPES.lblShotPower.Text = shotPower.ToString();
				if (shotTechnique >= 95)
				{
					frmWEPES.lblShotTechnique.ForeColor = Color.Red;
				}
				else if (shotTechnique >= 90)
				{
					frmWEPES.lblShotTechnique.ForeColor = Color.Orange;
				}
				else if (shotTechnique >= 80)
				{
					frmWEPES.lblShotTechnique.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblShotTechnique.ForeColor = Color.Empty;
				}
				frmWEPES.lblShotTechnique.Text = shotTechnique.ToString();
				if (freeKickAccuracy >= 95)
				{
					frmWEPES.lblFreeKickPrecision.ForeColor = Color.Red;
				}
				else if (freeKickAccuracy >= 90)
				{
					frmWEPES.lblFreeKickPrecision.ForeColor = Color.Orange;
				}
				else if (freeKickAccuracy >= 80)
				{
					frmWEPES.lblFreeKickPrecision.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblFreeKickPrecision.ForeColor = Color.Empty;
				}
				frmWEPES.lblFreeKickPrecision.Text = freeKickAccuracy.ToString();
				if (curling >= 95)
				{
					frmWEPES.lblBend.ForeColor = Color.Red;
				}
				else if (curling >= 90)
				{
					frmWEPES.lblBend.ForeColor = Color.Orange;
				}
				else if (curling >= 80)
				{
					frmWEPES.lblBend.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblBend.ForeColor = Color.Empty;
				}
				frmWEPES.lblBend.Text = curling.ToString();
				if (header >= 95)
				{
					frmWEPES.lblHeading.ForeColor = Color.Red;
				}
				else if (header >= 90)
				{
					frmWEPES.lblHeading.ForeColor = Color.Orange;
				}
				else if (header >= 80)
				{
					frmWEPES.lblHeading.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblHeading.ForeColor = Color.Empty;
				}
				frmWEPES.lblHeading.Text = header.ToString();
				if (jump >= 95)
				{
					frmWEPES.lblJump.ForeColor = Color.Red;
				}
				else if (jump >= 90)
				{
					frmWEPES.lblJump.ForeColor = Color.Orange;
				}
				else if (jump >= 80)
				{
					frmWEPES.lblJump.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblJump.ForeColor = Color.Empty;
				}
				frmWEPES.lblJump.Text = jump.ToString();
				if (technique >= 95)
				{
					frmWEPES.lblTechnique.ForeColor = Color.Red;
				}
				else if (technique >= 90)
				{
					frmWEPES.lblTechnique.ForeColor = Color.Orange;
				}
				else if (technique >= 80)
				{
					frmWEPES.lblTechnique.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblTechnique.ForeColor = Color.Empty;
				}
				frmWEPES.lblTechnique.Text = technique.ToString();
				if (aggression >= 95)
				{
					frmWEPES.lblAggressiveness.ForeColor = Color.Red;
				}
				else if (aggression >= 90)
				{
					frmWEPES.lblAggressiveness.ForeColor = Color.Orange;
				}
				else if (aggression >= 80)
				{
					frmWEPES.lblAggressiveness.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblAggressiveness.ForeColor = Color.Empty;
				}
				frmWEPES.lblAggressiveness.Text = aggression.ToString();
				if (mentality >= 95)
				{
					frmWEPES.lblMentality.ForeColor = Color.Red;
				}
				else if (mentality >= 90)
				{
					frmWEPES.lblMentality.ForeColor = Color.Orange;
				}
				else if (mentality >= 80)
				{
					frmWEPES.lblMentality.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblMentality.ForeColor = Color.Empty;
				}
				frmWEPES.lblMentality.Text = mentality.ToString();
				if (teamwork >= 95)
				{
					frmWEPES.lblCooperation.ForeColor = Color.Red;
				}
				else if (teamwork >= 90)
				{
					frmWEPES.lblCooperation.ForeColor = Color.Orange;
				}
				else if (teamwork >= 80)
				{
					frmWEPES.lblCooperation.ForeColor = Color.Yellow;
				}
				else
				{
					frmWEPES.lblCooperation.ForeColor = Color.Empty;
				}
				frmWEPES.lblCooperation.Text = teamwork.ToString();
				if (cmbDribbling.SelectedIndex >= 16)
				{
					frmWEPES.lblDribbler.ForeColor = Color.Yellow;
					frmWEPES.lblDribbler.Text = "*";
				}
				if ((cmbDribbling.SelectedIndex >= 16) & (cmbFlair.SelectedIndex >= 16))
				{
					frmWEPES.lblKeepDribble.ForeColor = Color.Yellow;
					frmWEPES.lblKeepDribble.Text = "*";
				}
				if ((cmbPosition.SelectedIndex == 7) & (cmbPositioning.SelectedIndex >= 16))
				{
					frmWEPES.lblPositioning.ForeColor = Color.Yellow;
					frmWEPES.lblPositioning.Text = "*";
				}
				if (cmbOffTheBall.SelectedIndex >= 16)
				{
					frmWEPES.lblDashIn.ForeColor = Color.Yellow;
					frmWEPES.lblDashIn.Text = "*";
				}
				if ((cmbPassing.SelectedIndex >= 16) & (cmbCreativity.SelectedIndex >= 16))
				{
					frmWEPES.lblCommander.ForeColor = Color.Yellow;
					frmWEPES.lblCommander.Text = "*";
				}
				if (cmbPassing.SelectedIndex >= 16)
				{
					frmWEPES.lblPasser.ForeColor = Color.Yellow;
					frmWEPES.lblPasser.Text = "*";
				}
				if ((cmbPosition.SelectedIndex == 7) & (cmbFinishing.SelectedIndex >= 16) & (cmbOffTheBall.SelectedIndex >= 16))
				{
					frmWEPES.lblStriker.ForeColor = Color.Yellow;
					frmWEPES.lblStriker.Text = "*";
				}
				if ((cmbFinishing.SelectedIndex >= 16) & (cmbComposure.SelectedIndex >= 16))
				{
					frmWEPES.lblShoot1On1.ForeColor = Color.Yellow;
					frmWEPES.lblShoot1On1.Text = "*";
				}
				if ((cmbPosition.SelectedIndex == 7) & (cmbBalance.SelectedIndex >= 16) & (cmbStrength.SelectedIndex >= 16))
				{
					frmWEPES.lblHoldingUpTheBall.ForeColor = Color.Yellow;
					frmWEPES.lblHoldingUpTheBall.Text = "*";
				}
				if ((cmbDecisions.SelectedIndex >= 16) & (cmbOffTheBall.SelectedIndex >= 16) & (cmbPositioning.SelectedIndex >= 16))
				{
					frmWEPES.lblLinePositioning.ForeColor = Color.Yellow;
					frmWEPES.lblLinePositioning.Text = "*";
				}
				if (cmbLongShots.SelectedIndex >= 16)
				{
					frmWEPES.lblMiddleShot.ForeColor = Color.Yellow;
					frmWEPES.lblMiddleShot.Text = "*";
				}
				if ((cmbPace.SelectedIndex >= 16) & (cmbAcceleration.SelectedIndex >= 16) & (cmbDribbling.SelectedIndex >= 16))
				{
					frmWEPES.lblSidePlayer.ForeColor = Color.Yellow;
					frmWEPES.lblSidePlayer.Text = "*";
				}
				if (cmbPenaltyTaking.SelectedIndex >= 16)
				{
					frmWEPES.lblPKKicker.ForeColor = Color.Yellow;
					frmWEPES.lblPKKicker.Text = "*";
				}
				if ((cmbCreativity.SelectedIndex >= 16) & (cmbTechnique.SelectedIndex >= 16))
				{
					frmWEPES.lblDirectPlay.ForeColor = Color.Yellow;
					frmWEPES.lblDirectPlay.Text = "*";
				}
				if ((cmbFlair.SelectedIndex >= 16) & (cmbTechnique.SelectedIndex >= 16))
				{
					frmWEPES.lblOutside.ForeColor = Color.Yellow;
					frmWEPES.lblOutside.Text = "*";
				}
				if (cmbMarking.SelectedIndex >= 16)
				{
					frmWEPES.lblManMarking.ForeColor = Color.Yellow;
					frmWEPES.lblManMarking.Text = "*";
				}
				if ((cmbTackling.SelectedIndex >= 16) & (cmbBravery.SelectedIndex >= 16) & (cmbDecisions.SelectedIndex >= 16))
				{
					frmWEPES.lblSliding.ForeColor = Color.Yellow;
					frmWEPES.lblSliding.Text = "*";
				}
				if ((cmbPosition.SelectedIndex == 0) & (cmbInfluence.SelectedIndex >= 16) & (cmbTeamwork.SelectedIndex >= 16))
				{
					frmWEPES.lblBackLineControl.ForeColor = Color.Yellow;
					frmWEPES.lblBackLineControl.Text = "*";
				}
				if (cmbLongThrows.SelectedIndex >= 16)
				{
					frmWEPES.lblLongThrow.ForeColor = Color.Yellow;
					frmWEPES.lblLongThrow.Text = "*";
				}
				frmWEPES.ShowDialog();
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			cmbPosition.SelectedIndex = 0;
			cmbCorners.SelectedIndex = 9;
			cmbCrossing.SelectedIndex = 9;
			cmbDribbling.SelectedIndex = 9;
			cmbFinishing.SelectedIndex = 9;
			cmbFirstTouch.SelectedIndex = 9;
			cmbFreeKicks.SelectedIndex = 9;
			cmbHeading.SelectedIndex = 9;
			cmbLongShots.SelectedIndex = 9;
			cmbLongThrows.SelectedIndex = 9;
			cmbMarking.SelectedIndex = 9;
			cmbPassing.SelectedIndex = 9;
			cmbPenaltyTaking.SelectedIndex = 9;
			cmbTackling.SelectedIndex = 9;
			cmbTechnique.SelectedIndex = 9;
			cmbAggression.SelectedIndex = 9;
			cmbAnticipation.SelectedIndex = 9;
			cmbBravery.SelectedIndex = 9;
			cmbComposure.SelectedIndex = 9;
			cmbConcentration.SelectedIndex = 9;
			cmbCreativity.SelectedIndex = 9;
			cmbDecisions.SelectedIndex = 9;
			cmbDetermination.SelectedIndex = 9;
			cmbFlair.SelectedIndex = 9;
			cmbInfluence.SelectedIndex = 9;
			cmbOffTheBall.SelectedIndex = 9;
			cmbPositioning.SelectedIndex = 9;
			cmbTeamwork.SelectedIndex = 9;
			cmbWorkRate.SelectedIndex = 9;
			cmbAcceleration.SelectedIndex = 9;
			cmbAgility.SelectedIndex = 9;
			cmbBalance.SelectedIndex = 9;
			cmbJumping.SelectedIndex = 9;
			cmbNaturalFitness.SelectedIndex = 9;
			cmbPace.SelectedIndex = 9;
			cmbStamina.SelectedIndex = 9;
			cmbStrength.SelectedIndex = 9;
			cmbPreferredFoot.SelectedIndex = 0;
			frmWEPES.ForeColor = Color.Empty;
			frmWEPES.lblAttack.Text = "";
			frmWEPES.lblDefense.Text = "";
			frmWEPES.lblBodyBalance.Text = "";
			frmWEPES.lblAcceleration.Text = "";
			frmWEPES.lblTopSpeed.Text = "";
			frmWEPES.lblStamina.Text = "";
			frmWEPES.lblShortPassSpeed.Text = "";
			frmWEPES.lblShortPassPrecision.Text = "";
			frmWEPES.lblDribbleSpeed.Text = "";
			frmWEPES.lblDribblePrecision.Text = "";
			frmWEPES.lblAgility.Text = "";
			frmWEPES.lblResponse.Text = "";
			frmWEPES.lblMentality.Text = "";
			frmWEPES.lblAggressiveness.Text = "";
			frmWEPES.lblTechnique.Text = "";
			frmWEPES.lblJump.Text = "";
			frmWEPES.lblHeading.Text = "";
			frmWEPES.lblBend.Text = "";
			frmWEPES.lblFreeKickPrecision.Text = "";
			frmWEPES.lblShotTechnique.Text = "";
			frmWEPES.lblShotPower.Text = "";
			frmWEPES.lblShotPrecision.Text = "";
			frmWEPES.lblLongPassSpeed.Text = "";
			frmWEPES.lblLongPassPrecision.Text = "";
			frmWEPES.lblSecondFootAccuracy.Text = "";
			frmWEPES.lblStabilityOfCondition.Text = "";
			frmWEPES.lblCooperation.Text = "";
			frmWEPES.lblGoalKeeperSkill.Text = "50";
			frmWEPES.lblStabilityOfPlay.Text = "";
			frmWEPES.lblSecondFootFrequency.Text = "";
			frmWEPES.lblSliding.Text = "";
			frmWEPES.lblBackLineControl.Text = "";
			frmWEPES.lblManMarking.Text = "";
			frmWEPES.lblOutside.Text = "";
			frmWEPES.lblCentrePlayer.Text = "";
			frmWEPES.lblSidePlayer.Text = "";
			frmWEPES.lblDirectPlay.Text = "";
			frmWEPES.lblLongThrow.Text = "";
			frmWEPES.lblShoot1On1.Text = "";
			frmWEPES.lblPKKicker.Text = "";
			frmWEPES.lblCovering.Text = "";
			frmWEPES.lblPasser.Text = "";
			frmWEPES.lblCommander.Text = "";
			frmWEPES.lblStriker.Text = "";
			frmWEPES.lblLinePositioning.Text = "";
			frmWEPES.lblDashIn.Text = "";
			frmWEPES.lblPositioning.Text = "";
			frmWEPES.lblHoldingUpTheBall.Text = "";
			frmWEPES.lblKeepDribble.Text = "";
			frmWEPES.lblDribbler.Text = "";
			frmWEPES.lblMiddleShot.Text = "";
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
            this.Close();
        }
	}
}