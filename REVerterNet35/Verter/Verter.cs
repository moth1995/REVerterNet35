using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Verter;

public class Verter : Form
{
	[AccessedThroughProperty("lblLongShots")]
	private Label _lblLongShots;

	[AccessedThroughProperty("cmbOffTheBall")]
	private ComboBox _cmbOffTheBall;

	[AccessedThroughProperty("lblOffTheBall")]
	private Label _lblOffTheBall;

	[AccessedThroughProperty("cmbInfluence")]
	private ComboBox _cmbInfluence;

	[AccessedThroughProperty("lblInfluence")]
	private Label _lblInfluence;

	[AccessedThroughProperty("cmbFlair")]
	private ComboBox _cmbFlair;

	[AccessedThroughProperty("lblFlair")]
	private Label _lblFlair;

	[AccessedThroughProperty("cmbDetermination")]
	private ComboBox _cmbDetermination;

	[AccessedThroughProperty("cmbAcceleration")]
	private ComboBox _cmbAcceleration;

	[AccessedThroughProperty("lblHeading")]
	private Label _lblHeading;

	[AccessedThroughProperty("cmbAgility")]
	private ComboBox _cmbAgility;

	[AccessedThroughProperty("lblDetermination")]
	private Label _lblDetermination;

	[AccessedThroughProperty("cmbDecisions")]
	private ComboBox _cmbDecisions;

	[AccessedThroughProperty("lblDecisions")]
	private Label _lblDecisions;

	[AccessedThroughProperty("cmbCreativity")]
	private ComboBox _cmbCreativity;

	[AccessedThroughProperty("lblCreativity")]
	private Label _lblCreativity;

	[AccessedThroughProperty("cmbConcentration")]
	private ComboBox _cmbConcentration;

	[AccessedThroughProperty("lblConcentration")]
	private Label _lblConcentration;

	[AccessedThroughProperty("cmbComposure")]
	private ComboBox _cmbComposure;

	[AccessedThroughProperty("lblComposure")]
	private Label _lblComposure;

	[AccessedThroughProperty("cmbBravery")]
	private ComboBox _cmbBravery;

	[AccessedThroughProperty("lblTeamwork")]
	private Label _lblTeamwork;

	[AccessedThroughProperty("cmbPositioning")]
	private ComboBox _cmbPositioning;

	[AccessedThroughProperty("grpFM2005Stats")]
	private GroupBox _grpFM2005Stats;

	[AccessedThroughProperty("cmbPosition")]
	private ComboBox _cmbPosition;

	[AccessedThroughProperty("txtName")]
	private TextBox _txtName;

	[AccessedThroughProperty("lblName")]
	private Label _lblName;

	[AccessedThroughProperty("cmbPreferredFoot")]
	private ComboBox _cmbPreferredFoot;

	[AccessedThroughProperty("cmbStrength")]
	private ComboBox _cmbStrength;

	[AccessedThroughProperty("lblStrength")]
	private Label _lblStrength;

	[AccessedThroughProperty("cmbStamina")]
	private ComboBox _cmbStamina;

	[AccessedThroughProperty("cmbPace")]
	private ComboBox _cmbPace;

	[AccessedThroughProperty("lblPace")]
	private Label _lblPace;

	[AccessedThroughProperty("cmbNaturalFitness")]
	private ComboBox _cmbNaturalFitness;

	[AccessedThroughProperty("lblNaturalFitness")]
	private Label _lblNaturalFitness;

	[AccessedThroughProperty("cmbJumping")]
	private ComboBox _cmbJumping;

	[AccessedThroughProperty("lblBravery")]
	private Label _lblBravery;

	[AccessedThroughProperty("cmbAnticipation")]
	private ComboBox _cmbAnticipation;

	[AccessedThroughProperty("lblAnticipation")]
	private Label _lblAnticipation;

	[AccessedThroughProperty("cmbWorkRate")]
	private ComboBox _cmbWorkRate;

	[AccessedThroughProperty("cmbAggression")]
	private ComboBox _cmbAggression;

	[AccessedThroughProperty("lblAggression")]
	private Label _lblAggression;

	[AccessedThroughProperty("cmbTechnique")]
	private ComboBox _cmbTechnique;

	[AccessedThroughProperty("lblPosition")]
	private Label _lblPosition;

	[AccessedThroughProperty("lblJumping")]
	private Label _lblJumping;

	[AccessedThroughProperty("lblAcceleration")]
	private Label _lblAcceleration;

	[AccessedThroughProperty("cmbTackling")]
	private ComboBox _cmbTackling;

	[AccessedThroughProperty("lblTackling")]
	private Label _lblTackling;

	[AccessedThroughProperty("lblPreferredFoot")]
	private Label _lblPreferredFoot;

	[AccessedThroughProperty("lblStamina")]
	private Label _lblStamina;

	[AccessedThroughProperty("cmbPenaltyTaking")]
	private ComboBox _cmbPenaltyTaking;

	[AccessedThroughProperty("lblPenaltyTaking")]
	private Label _lblPenaltyTaking;

	[AccessedThroughProperty("cmbPassing")]
	private ComboBox _cmbPassing;

	[AccessedThroughProperty("lblAgility")]
	private Label _lblAgility;

	[AccessedThroughProperty("lblPassing")]
	private Label _lblPassing;

	[AccessedThroughProperty("lblWorkRate")]
	private Label _lblWorkRate;

	[AccessedThroughProperty("cmbMarking")]
	private ComboBox _cmbMarking;

	[AccessedThroughProperty("lblMarking")]
	private Label _lblMarking;

	[AccessedThroughProperty("cmbBalance")]
	private ComboBox _cmbBalance;

	[AccessedThroughProperty("lblTechnique")]
	private Label _lblTechnique;

	[AccessedThroughProperty("cmbLongThrows")]
	private ComboBox _cmbLongThrows;

	[AccessedThroughProperty("lblLongThrows")]
	private Label _lblLongThrows;

	[AccessedThroughProperty("cmbLongShots")]
	private ComboBox _cmbLongShots;

	[AccessedThroughProperty("grpPlayerInformation")]
	private GroupBox _grpPlayerInformation;

	[AccessedThroughProperty("cmbHeading")]
	private ComboBox _cmbHeading;

	[AccessedThroughProperty("cmbFreeKicks")]
	private ComboBox _cmbFreeKicks;

	[AccessedThroughProperty("lblFreeKicks")]
	private Label _lblFreeKicks;

	[AccessedThroughProperty("cmbFirstTouch")]
	private ComboBox _cmbFirstTouch;

	[AccessedThroughProperty("lblPositioning")]
	private Label _lblPositioning;

	[AccessedThroughProperty("cmbTeamwork")]
	private ComboBox _cmbTeamwork;

	[AccessedThroughProperty("lblFirstTouch")]
	private Label _lblFirstTouch;

	[AccessedThroughProperty("lblBalance")]
	private Label _lblBalance;

	[AccessedThroughProperty("cmbFinishing")]
	private ComboBox _cmbFinishing;

	[AccessedThroughProperty("lblFinishing")]
	private Label _lblFinishing;

	[AccessedThroughProperty("cmbDribbling")]
	private ComboBox _cmbDribbling;

	[AccessedThroughProperty("lblDribbling")]
	private Label _lblDribbling;

	[AccessedThroughProperty("cmbCrossing")]
	private ComboBox _cmbCrossing;

	[AccessedThroughProperty("lblCrossing")]
	private Label _lblCrossing;

	[AccessedThroughProperty("cmbCorners")]
	private ComboBox _cmbCorners;

	[AccessedThroughProperty("lblCorners")]
	private Label _lblCorners;

	[AccessedThroughProperty("btnConvert")]
	private Button _btnConvert;

	[AccessedThroughProperty("btnReset")]
	private Button _btnReset;

	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	private IContainer components;

	private frmWEPES frmWEPES;

	private decimal decCBAttackMax;

	private decimal decCBAttackMin;

	private decimal decCBDefenseMax;

	private decimal decCBDefenseMin;

	private decimal decCBBodyBalanceMax;

	private decimal decCBBodyBalanceMin;

	private decimal decCBStaminaMax;

	private decimal decCBStaminaMin;

	private decimal decCBTopSpeedMax;

	private decimal decCBTopSpeedMin;

	private decimal decCBAccelerationMax;

	private decimal decCBAccelerationMin;

	private decimal decCBResponseMax;

	private decimal decCBResponseMin;

	private decimal decCBAgilityMax;

	private decimal decCBAgilityMin;

	private decimal decCBDribblePrecisionMax;

	private decimal decCBDribblePrecisionMin;

	private decimal decCBDribbleSpeedMax;

	private decimal decCBDribbleSpeedMin;

	private decimal decCBShortPassPrecisionMax;

	private decimal decCBShortPassPrecisionMin;

	private decimal decCBShortPassSpeedMax;

	private decimal decCBShortPassSpeedMin;

	private decimal decCBLongPassPrecisionMax;

	private decimal decCBLongPassPrecisionMin;

	private decimal decCBLongPassSpeedMax;

	private decimal decCBLongPassSpeedMin;

	private decimal decCBShotPrecisionMax;

	private decimal decCBShotPrecisionMin;

	private decimal decCBShotPowerMax;

	private decimal decCBShotPowerMin;

	private decimal decCBShotTechniqueMax;

	private decimal decCBShotTechniqueMin;

	private decimal decCBFreeKickPrecisionMax;

	private decimal decCBFreeKickPrecisionMin;

	private decimal decCBBendMax;

	private decimal decCBBendMin;

	private decimal decCBHeadingMax;

	private decimal decCBHeadingMin;

	private decimal decCBJumpMax;

	private decimal decCBJumpMin;

	private decimal decCBTechniqueMax;

	private decimal decCBTechniqueMin;

	private decimal decCBAggressivenessMax;

	private decimal decCBAggressivenessMin;

	private decimal decCBMentalityMax;

	private decimal decCBMentalityMin;

	private decimal decCBCooperationMax;

	private decimal decCBCooperationMin;

	private decimal decCBStarPlayer;

	private decimal decSBAttackMax;

	private decimal decSBAttackMin;

	private decimal decSBDefenseMax;

	private decimal decSBDefenseMin;

	private decimal decSBBodyBalanceMax;

	private decimal decSBBodyBalanceMin;

	private decimal decSBStaminaMax;

	private decimal decSBStaminaMin;

	private decimal decSBTopSpeedMax;

	private decimal decSBTopSpeedMin;

	private decimal decSBAccelerationMax;

	private decimal decSBAccelerationMin;

	private decimal decSBResponseMax;

	private decimal decSBResponseMin;

	private decimal decSBAgilityMax;

	private decimal decSBAgilityMin;

	private decimal decSBDribblePrecisionMax;

	private decimal decSBDribblePrecisionMin;

	private decimal decSBDribbleSpeedMax;

	private decimal decSBDribbleSpeedMin;

	private decimal decSBShortPassPrecisionMax;

	private decimal decSBShortPassPrecisionMin;

	private decimal decSBShortPassSpeedMax;

	private decimal decSBShortPassSpeedMin;

	private decimal decSBLongPassPrecisionMax;

	private decimal decSBLongPassPrecisionMin;

	private decimal decSBLongPassSpeedMax;

	private decimal decSBLongPassSpeedMin;

	private decimal decSBShotPrecisionMax;

	private decimal decSBShotPrecisionMin;

	private decimal decSBShotPowerMax;

	private decimal decSBShotPowerMin;

	private decimal decSBShotTechniqueMax;

	private decimal decSBShotTechniqueMin;

	private decimal decSBFreeKickPrecisionMax;

	private decimal decSBFreeKickPrecisionMin;

	private decimal decSBBendMax;

	private decimal decSBBendMin;

	private decimal decSBHeadingMax;

	private decimal decSBHeadingMin;

	private decimal decSBJumpMax;

	private decimal decSBJumpMin;

	private decimal decSBTechniqueMax;

	private decimal decSBTechniqueMin;

	private decimal decSBAggressivenessMax;

	private decimal decSBAggressivenessMin;

	private decimal decSBMentalityMax;

	private decimal decSBMentalityMin;

	private decimal decSBCooperationMax;

	private decimal decSBCooperationMin;

	private decimal decSBStarPlayer;

	private decimal decDMFAttackMax;

	private decimal decDMFAttackMin;

	private decimal decDMFDefenseMax;

	private decimal decDMFDefenseMin;

	private decimal decDMFBodyBalanceMax;

	private decimal decDMFBodyBalanceMin;

	private decimal decDMFStaminaMax;

	private decimal decDMFStaminaMin;

	private decimal decDMFTopSpeedMax;

	private decimal decDMFTopSpeedMin;

	private decimal decDMFAccelerationMax;

	private decimal decDMFAccelerationMin;

	private decimal decDMFResponseMax;

	private decimal decDMFResponseMin;

	private decimal decDMFAgilityMax;

	private decimal decDMFAgilityMin;

	private decimal decDMFDribblePrecisionMax;

	private decimal decDMFDribblePrecisionMin;

	private decimal decDMFDribbleSpeedMax;

	private decimal decDMFDribbleSpeedMin;

	private decimal decDMFShortPassPrecisionMax;

	private decimal decDMFShortPassPrecisionMin;

	private decimal decDMFShortPassSpeedMax;

	private decimal decDMFShortPassSpeedMin;

	private decimal decDMFLongPassPrecisionMax;

	private decimal decDMFLongPassPrecisionMin;

	private decimal decDMFLongPassSpeedMax;

	private decimal decDMFLongPassSpeedMin;

	private decimal decDMFShotPrecisionMax;

	private decimal decDMFShotPrecisionMin;

	private decimal decDMFShotPowerMax;

	private decimal decDMFShotPowerMin;

	private decimal decDMFShotTechniqueMax;

	private decimal decDMFShotTechniqueMin;

	private decimal decDMFFreeKickPrecisionMax;

	private decimal decDMFFreeKickPrecisionMin;

	private decimal decDMFBendMax;

	private decimal decDMFBendMin;

	private decimal decDMFHeadingMax;

	private decimal decDMFHeadingMin;

	private decimal decDMFJumpMax;

	private decimal decDMFJumpMin;

	private decimal decDMFTechniqueMax;

	private decimal decDMFTechniqueMin;

	private decimal decDMFAggressivenessMax;

	private decimal decDMFAggressivenessMin;

	private decimal decDMFMentalityMax;

	private decimal decDMFMentalityMin;

	private decimal decDMFCooperationMax;

	private decimal decDMFCooperationMin;

	private decimal decDMFStarPlayer;

	private decimal decSMFAttackMax;

	private decimal decSMFAttackMin;

	private decimal decSMFDefenseMax;

	private decimal decSMFDefenseMin;

	private decimal decSMFBodyBalanceMax;

	private decimal decSMFBodyBalanceMin;

	private decimal decSMFStaminaMax;

	private decimal decSMFStaminaMin;

	private decimal decSMFTopSpeedMax;

	private decimal decSMFTopSpeedMin;

	private decimal decSMFAccelerationMax;

	private decimal decSMFAccelerationMin;

	private decimal decSMFResponseMax;

	private decimal decSMFResponseMin;

	private decimal decSMFAgilityMax;

	private decimal decSMFAgilityMin;

	private decimal decSMFDribblePrecisionMax;

	private decimal decSMFDribblePrecisionMin;

	private decimal decSMFDribbleSpeedMax;

	private decimal decSMFDribbleSpeedMin;

	private decimal decSMFShortPassPrecisionMax;

	private decimal decSMFShortPassPrecisionMin;

	private decimal decSMFShortPassSpeedMax;

	private decimal decSMFShortPassSpeedMin;

	private decimal decSMFLongPassPrecisionMax;

	private decimal decSMFLongPassPrecisionMin;

	private decimal decSMFLongPassSpeedMax;

	private decimal decSMFLongPassSpeedMin;

	private decimal decSMFShotPrecisionMax;

	private decimal decSMFShotPrecisionMin;

	private decimal decSMFShotPowerMax;

	private decimal decSMFShotPowerMin;

	private decimal decSMFShotTechniqueMax;

	private decimal decSMFShotTechniqueMin;

	private decimal decSMFFreeKickPrecisionMax;

	private decimal decSMFFreeKickPrecisionMin;

	private decimal decSMFBendMax;

	private decimal decSMFBendMin;

	private decimal decSMFHeadingMax;

	private decimal decSMFHeadingMin;

	private decimal decSMFJumpMax;

	private decimal decSMFJumpMin;

	private decimal decSMFTechniqueMax;

	private decimal decSMFTechniqueMin;

	private decimal decSMFAggressivenessMax;

	private decimal decSMFAggressivenessMin;

	private decimal decSMFMentalityMax;

	private decimal decSMFMentalityMin;

	private decimal decSMFCooperationMax;

	private decimal decSMFCooperationMin;

	private decimal decSMFStarPlayer;

	private decimal decOMFAttackMax;

	private decimal decOMFAttackMin;

	private decimal decOMFDefenseMax;

	private decimal decOMFDefenseMin;

	private decimal decOMFBodyBalanceMax;

	private decimal decOMFBodyBalanceMin;

	private decimal decOMFStaminaMax;

	private decimal decOMFStaminaMin;

	private decimal decOMFTopSpeedMax;

	private decimal decOMFTopSpeedMin;

	private decimal decOMFAccelerationMax;

	private decimal decOMFAccelerationMin;

	private decimal decOMFResponseMax;

	private decimal decOMFResponseMin;

	private decimal decOMFAgilityMax;

	private decimal decOMFAgilityMin;

	private decimal decOMFDribblePrecisionMax;

	private decimal decOMFDribblePrecisionMin;

	private decimal decOMFDribbleSpeedMax;

	private decimal decOMFDribbleSpeedMin;

	private decimal decOMFShortPassPrecisionMax;

	private decimal decOMFShortPassPrecisionMin;

	private decimal decOMFShortPassSpeedMax;

	private decimal decOMFShortPassSpeedMin;

	private decimal decOMFLongPassPrecisionMax;

	private decimal decOMFLongPassPrecisionMin;

	private decimal decOMFLongPassSpeedMax;

	private decimal decOMFLongPassSpeedMin;

	private decimal decOMFShotPrecisionMax;

	private decimal decOMFShotPrecisionMin;

	private decimal decOMFShotPowerMax;

	private decimal decOMFShotPowerMin;

	private decimal decOMFShotTechniqueMax;

	private decimal decOMFShotTechniqueMin;

	private decimal decOMFFreeKickPrecisionMax;

	private decimal decOMFFreeKickPrecisionMin;

	private decimal decOMFBendMax;

	private decimal decOMFBendMin;

	private decimal decOMFHeadingMax;

	private decimal decOMFHeadingMin;

	private decimal decOMFJumpMax;

	private decimal decOMFJumpMin;

	private decimal decOMFTechniqueMax;

	private decimal decOMFTechniqueMin;

	private decimal decOMFAggressivenessMax;

	private decimal decOMFAggressivenessMin;

	private decimal decOMFMentalityMax;

	private decimal decOMFMentalityMin;

	private decimal decOMFCooperationMax;

	private decimal decOMFCooperationMin;

	private decimal decOMFStarPlayer;

	private decimal decWFAttackMax;

	private decimal decWFAttackMin;

	private decimal decWFDefenseMax;

	private decimal decWFDefenseMin;

	private decimal decWFBodyBalanceMax;

	private decimal decWFBodyBalanceMin;

	private decimal decWFStaminaMax;

	private decimal decWFStaminaMin;

	private decimal decWFTopSpeedMax;

	private decimal decWFTopSpeedMin;

	private decimal decWFAccelerationMax;

	private decimal decWFAccelerationMin;

	private decimal decWFResponseMax;

	private decimal decWFResponseMin;

	private decimal decWFAgilityMax;

	private decimal decWFAgilityMin;

	private decimal decWFDribblePrecisionMax;

	private decimal decWFDribblePrecisionMin;

	private decimal decWFDribbleSpeedMax;

	private decimal decWFDribbleSpeedMin;

	private decimal decWFShortPassPrecisionMax;

	private decimal decWFShortPassPrecisionMin;

	private decimal decWFShortPassSpeedMax;

	private decimal decWFShortPassSpeedMin;

	private decimal decWFLongPassPrecisionMax;

	private decimal decWFLongPassPrecisionMin;

	private decimal decWFLongPassSpeedMax;

	private decimal decWFLongPassSpeedMin;

	private decimal decWFShotPrecisionMax;

	private decimal decWFShotPrecisionMin;

	private decimal decWFShotPowerMax;

	private decimal decWFShotPowerMin;

	private decimal decWFShotTechniqueMax;

	private decimal decWFShotTechniqueMin;

	private decimal decWFFreeKickPrecisionMax;

	private decimal decWFFreeKickPrecisionMin;

	private decimal decWFBendMax;

	private decimal decWFBendMin;

	private decimal decWFHeadingMax;

	private decimal decWFHeadingMin;

	private decimal decWFJumpMax;

	private decimal decWFJumpMin;

	private decimal decWFTechniqueMax;

	private decimal decWFTechniqueMin;

	private decimal decWFAggressivenessMax;

	private decimal decWFAggressivenessMin;

	private decimal decWFMentalityMax;

	private decimal decWFMentalityMin;

	private decimal decWFCooperationMax;

	private decimal decWFCooperationMin;

	private decimal decWFStarPlayer;

	private decimal decSTCFAttackMax;

	private decimal decSTCFAttackMin;

	private decimal decSTCFDefenseMax;

	private decimal decSTCFDefenseMin;

	private decimal decSTCFBodyBalanceMax;

	private decimal decSTCFBodyBalanceMin;

	private decimal decSTCFStaminaMax;

	private decimal decSTCFStaminaMin;

	private decimal decSTCFTopSpeedMax;

	private decimal decSTCFTopSpeedMin;

	private decimal decSTCFAccelerationMax;

	private decimal decSTCFAccelerationMin;

	private decimal decSTCFResponseMax;

	private decimal decSTCFResponseMin;

	private decimal decSTCFAgilityMax;

	private decimal decSTCFAgilityMin;

	private decimal decSTCFDribblePrecisionMax;

	private decimal decSTCFDribblePrecisionMin;

	private decimal decSTCFDribbleSpeedMax;

	private decimal decSTCFDribbleSpeedMin;

	private decimal decSTCFShortPassPrecisionMax;

	private decimal decSTCFShortPassPrecisionMin;

	private decimal decSTCFShortPassSpeedMax;

	private decimal decSTCFShortPassSpeedMin;

	private decimal decSTCFLongPassPrecisionMax;

	private decimal decSTCFLongPassPrecisionMin;

	private decimal decSTCFLongPassSpeedMax;

	private decimal decSTCFLongPassSpeedMin;

	private decimal decSTCFShotPrecisionMax;

	private decimal decSTCFShotPrecisionMin;

	private decimal decSTCFShotPowerMax;

	private decimal decSTCFShotPowerMin;

	private decimal decSTCFShotTechniqueMax;

	private decimal decSTCFShotTechniqueMin;

	private decimal decSTCFFreeKickPrecisionMax;

	private decimal decSTCFFreeKickPrecisionMin;

	private decimal decSTCFBendMax;

	private decimal decSTCFBendMin;

	private decimal decSTCFHeadingMax;

	private decimal decSTCFHeadingMin;

	private decimal decSTCFJumpMax;

	private decimal decSTCFJumpMin;

	private decimal decSTCFTechniqueMax;

	private decimal decSTCFTechniqueMin;

	private decimal decSTCFAggressivenessMax;

	private decimal decSTCFAggressivenessMin;

	private decimal decSTCFMentalityMax;

	private decimal decSTCFMentalityMin;

	private decimal decSTCFCooperationMax;

	private decimal decSTCFCooperationMin;

	private decimal decSTCFStarPlayer;

	internal virtual Label lblPosition
	{
		get
		{
			return _lblPosition;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPosition != null)
			{
			}
			_lblPosition = value;
			if (_lblPosition == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbPosition
	{
		get
		{
			return _cmbPosition;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbPosition != null)
			{
			}
			_cmbPosition = value;
			if (_cmbPosition == null)
			{
			}
		}
	}

	internal virtual TextBox txtName
	{
		get
		{
			return _txtName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_txtName != null)
			{
			}
			_txtName = value;
			if (_txtName == null)
			{
			}
		}
	}

	internal virtual Label lblName
	{
		get
		{
			return _lblName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblName != null)
			{
			}
			_lblName = value;
			if (_lblName == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbPreferredFoot
	{
		get
		{
			return _cmbPreferredFoot;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbPreferredFoot != null)
			{
			}
			_cmbPreferredFoot = value;
			if (_cmbPreferredFoot == null)
			{
			}
		}
	}

	internal virtual Label lblPreferredFoot
	{
		get
		{
			return _lblPreferredFoot;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPreferredFoot != null)
			{
			}
			_lblPreferredFoot = value;
			if (_lblPreferredFoot == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbStrength
	{
		get
		{
			return _cmbStrength;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbStrength != null)
			{
			}
			_cmbStrength = value;
			if (_cmbStrength == null)
			{
			}
		}
	}

	internal virtual Label lblStrength
	{
		get
		{
			return _lblStrength;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStrength != null)
			{
			}
			_lblStrength = value;
			if (_lblStrength == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbStamina
	{
		get
		{
			return _cmbStamina;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbStamina != null)
			{
			}
			_cmbStamina = value;
			if (_cmbStamina == null)
			{
			}
		}
	}

	internal virtual Label lblStamina
	{
		get
		{
			return _lblStamina;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStamina != null)
			{
			}
			_lblStamina = value;
			if (_lblStamina == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbPace
	{
		get
		{
			return _cmbPace;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbPace != null)
			{
			}
			_cmbPace = value;
			if (_cmbPace == null)
			{
			}
		}
	}

	internal virtual Label lblPace
	{
		get
		{
			return _lblPace;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPace != null)
			{
			}
			_lblPace = value;
			if (_lblPace == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbNaturalFitness
	{
		get
		{
			return _cmbNaturalFitness;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbNaturalFitness != null)
			{
			}
			_cmbNaturalFitness = value;
			if (_cmbNaturalFitness == null)
			{
			}
		}
	}

	internal virtual Label lblNaturalFitness
	{
		get
		{
			return _lblNaturalFitness;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblNaturalFitness != null)
			{
			}
			_lblNaturalFitness = value;
			if (_lblNaturalFitness == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbJumping
	{
		get
		{
			return _cmbJumping;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbJumping != null)
			{
			}
			_cmbJumping = value;
			if (_cmbJumping == null)
			{
			}
		}
	}

	internal virtual Label lblJumping
	{
		get
		{
			return _lblJumping;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblJumping != null)
			{
			}
			_lblJumping = value;
			if (_lblJumping == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbBalance
	{
		get
		{
			return _cmbBalance;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbBalance != null)
			{
			}
			_cmbBalance = value;
			if (_cmbBalance == null)
			{
			}
		}
	}

	internal virtual Label lblBalance
	{
		get
		{
			return _lblBalance;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblBalance != null)
			{
			}
			_lblBalance = value;
			if (_lblBalance == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbAgility
	{
		get
		{
			return _cmbAgility;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbAgility != null)
			{
			}
			_cmbAgility = value;
			if (_cmbAgility == null)
			{
			}
		}
	}

	internal virtual Label lblAgility
	{
		get
		{
			return _lblAgility;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAgility != null)
			{
			}
			_lblAgility = value;
			if (_lblAgility == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbAcceleration
	{
		get
		{
			return _cmbAcceleration;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbAcceleration != null)
			{
			}
			_cmbAcceleration = value;
			if (_cmbAcceleration == null)
			{
			}
		}
	}

	internal virtual Label lblAcceleration
	{
		get
		{
			return _lblAcceleration;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAcceleration != null)
			{
			}
			_lblAcceleration = value;
			if (_lblAcceleration == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbWorkRate
	{
		get
		{
			return _cmbWorkRate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbWorkRate != null)
			{
			}
			_cmbWorkRate = value;
			if (_cmbWorkRate == null)
			{
			}
		}
	}

	internal virtual Label lblWorkRate
	{
		get
		{
			return _lblWorkRate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblWorkRate != null)
			{
			}
			_lblWorkRate = value;
			if (_lblWorkRate == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbTeamwork
	{
		get
		{
			return _cmbTeamwork;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbTeamwork != null)
			{
			}
			_cmbTeamwork = value;
			if (_cmbTeamwork == null)
			{
			}
		}
	}

	internal virtual Label lblTeamwork
	{
		get
		{
			return _lblTeamwork;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblTeamwork != null)
			{
			}
			_lblTeamwork = value;
			if (_lblTeamwork == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbPositioning
	{
		get
		{
			return _cmbPositioning;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbPositioning != null)
			{
			}
			_cmbPositioning = value;
			if (_cmbPositioning == null)
			{
			}
		}
	}

	internal virtual Label lblPositioning
	{
		get
		{
			return _lblPositioning;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPositioning != null)
			{
			}
			_lblPositioning = value;
			if (_lblPositioning == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbOffTheBall
	{
		get
		{
			return _cmbOffTheBall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbOffTheBall != null)
			{
			}
			_cmbOffTheBall = value;
			if (_cmbOffTheBall == null)
			{
			}
		}
	}

	internal virtual Label lblOffTheBall
	{
		get
		{
			return _lblOffTheBall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblOffTheBall != null)
			{
			}
			_lblOffTheBall = value;
			if (_lblOffTheBall == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbInfluence
	{
		get
		{
			return _cmbInfluence;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbInfluence != null)
			{
			}
			_cmbInfluence = value;
			if (_cmbInfluence == null)
			{
			}
		}
	}

	internal virtual Label lblInfluence
	{
		get
		{
			return _lblInfluence;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblInfluence != null)
			{
			}
			_lblInfluence = value;
			if (_lblInfluence == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbFlair
	{
		get
		{
			return _cmbFlair;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbFlair != null)
			{
			}
			_cmbFlair = value;
			if (_cmbFlair == null)
			{
			}
		}
	}

	internal virtual Label lblFlair
	{
		get
		{
			return _lblFlair;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblFlair != null)
			{
			}
			_lblFlair = value;
			if (_lblFlair == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbDetermination
	{
		get
		{
			return _cmbDetermination;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbDetermination != null)
			{
			}
			_cmbDetermination = value;
			if (_cmbDetermination == null)
			{
			}
		}
	}

	internal virtual Label lblDetermination
	{
		get
		{
			return _lblDetermination;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDetermination != null)
			{
			}
			_lblDetermination = value;
			if (_lblDetermination == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbDecisions
	{
		get
		{
			return _cmbDecisions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbDecisions != null)
			{
			}
			_cmbDecisions = value;
			if (_cmbDecisions == null)
			{
			}
		}
	}

	internal virtual Label lblDecisions
	{
		get
		{
			return _lblDecisions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDecisions != null)
			{
			}
			_lblDecisions = value;
			if (_lblDecisions == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbCreativity
	{
		get
		{
			return _cmbCreativity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbCreativity != null)
			{
			}
			_cmbCreativity = value;
			if (_cmbCreativity == null)
			{
			}
		}
	}

	internal virtual Label lblCreativity
	{
		get
		{
			return _lblCreativity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCreativity != null)
			{
			}
			_lblCreativity = value;
			if (_lblCreativity == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbConcentration
	{
		get
		{
			return _cmbConcentration;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbConcentration != null)
			{
			}
			_cmbConcentration = value;
			if (_cmbConcentration == null)
			{
			}
		}
	}

	internal virtual Label lblConcentration
	{
		get
		{
			return _lblConcentration;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblConcentration != null)
			{
			}
			_lblConcentration = value;
			if (_lblConcentration == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbComposure
	{
		get
		{
			return _cmbComposure;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbComposure != null)
			{
			}
			_cmbComposure = value;
			if (_cmbComposure == null)
			{
			}
		}
	}

	internal virtual Label lblComposure
	{
		get
		{
			return _lblComposure;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblComposure != null)
			{
			}
			_lblComposure = value;
			if (_lblComposure == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbBravery
	{
		get
		{
			return _cmbBravery;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbBravery != null)
			{
			}
			_cmbBravery = value;
			if (_cmbBravery == null)
			{
			}
		}
	}

	internal virtual Label lblBravery
	{
		get
		{
			return _lblBravery;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblBravery != null)
			{
			}
			_lblBravery = value;
			if (_lblBravery == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbAnticipation
	{
		get
		{
			return _cmbAnticipation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbAnticipation != null)
			{
			}
			_cmbAnticipation = value;
			if (_cmbAnticipation == null)
			{
			}
		}
	}

	internal virtual Label lblAnticipation
	{
		get
		{
			return _lblAnticipation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAnticipation != null)
			{
			}
			_lblAnticipation = value;
			if (_lblAnticipation == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbAggression
	{
		get
		{
			return _cmbAggression;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbAggression != null)
			{
			}
			_cmbAggression = value;
			if (_cmbAggression == null)
			{
			}
		}
	}

	internal virtual Label lblAggression
	{
		get
		{
			return _lblAggression;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAggression != null)
			{
			}
			_lblAggression = value;
			if (_lblAggression == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbTechnique
	{
		get
		{
			return _cmbTechnique;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbTechnique != null)
			{
			}
			_cmbTechnique = value;
			if (_cmbTechnique == null)
			{
			}
		}
	}

	internal virtual Label lblTechnique
	{
		get
		{
			return _lblTechnique;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblTechnique != null)
			{
			}
			_lblTechnique = value;
			if (_lblTechnique == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbTackling
	{
		get
		{
			return _cmbTackling;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbTackling != null)
			{
			}
			_cmbTackling = value;
			if (_cmbTackling == null)
			{
			}
		}
	}

	internal virtual Label lblTackling
	{
		get
		{
			return _lblTackling;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblTackling != null)
			{
			}
			_lblTackling = value;
			if (_lblTackling == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbPenaltyTaking
	{
		get
		{
			return _cmbPenaltyTaking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbPenaltyTaking != null)
			{
			}
			_cmbPenaltyTaking = value;
			if (_cmbPenaltyTaking == null)
			{
			}
		}
	}

	internal virtual Label lblPenaltyTaking
	{
		get
		{
			return _lblPenaltyTaking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPenaltyTaking != null)
			{
			}
			_lblPenaltyTaking = value;
			if (_lblPenaltyTaking == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbPassing
	{
		get
		{
			return _cmbPassing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbPassing != null)
			{
			}
			_cmbPassing = value;
			if (_cmbPassing == null)
			{
			}
		}
	}

	internal virtual Label lblPassing
	{
		get
		{
			return _lblPassing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPassing != null)
			{
			}
			_lblPassing = value;
			if (_lblPassing == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbMarking
	{
		get
		{
			return _cmbMarking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbMarking != null)
			{
			}
			_cmbMarking = value;
			if (_cmbMarking == null)
			{
			}
		}
	}

	internal virtual Label lblMarking
	{
		get
		{
			return _lblMarking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblMarking != null)
			{
			}
			_lblMarking = value;
			if (_lblMarking == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbLongThrows
	{
		get
		{
			return _cmbLongThrows;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbLongThrows != null)
			{
			}
			_cmbLongThrows = value;
			if (_cmbLongThrows == null)
			{
			}
		}
	}

	internal virtual Label lblLongThrows
	{
		get
		{
			return _lblLongThrows;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLongThrows != null)
			{
			}
			_lblLongThrows = value;
			if (_lblLongThrows == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbLongShots
	{
		get
		{
			return _cmbLongShots;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbLongShots != null)
			{
			}
			_cmbLongShots = value;
			if (_cmbLongShots == null)
			{
			}
		}
	}

	internal virtual Label lblLongShots
	{
		get
		{
			return _lblLongShots;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLongShots != null)
			{
			}
			_lblLongShots = value;
			if (_lblLongShots == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbHeading
	{
		get
		{
			return _cmbHeading;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbHeading != null)
			{
			}
			_cmbHeading = value;
			if (_cmbHeading == null)
			{
			}
		}
	}

	internal virtual Label lblHeading
	{
		get
		{
			return _lblHeading;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblHeading != null)
			{
			}
			_lblHeading = value;
			if (_lblHeading == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbFreeKicks
	{
		get
		{
			return _cmbFreeKicks;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbFreeKicks != null)
			{
			}
			_cmbFreeKicks = value;
			if (_cmbFreeKicks == null)
			{
			}
		}
	}

	internal virtual Label lblFreeKicks
	{
		get
		{
			return _lblFreeKicks;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblFreeKicks != null)
			{
			}
			_lblFreeKicks = value;
			if (_lblFreeKicks == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbFirstTouch
	{
		get
		{
			return _cmbFirstTouch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbFirstTouch != null)
			{
			}
			_cmbFirstTouch = value;
			if (_cmbFirstTouch == null)
			{
			}
		}
	}

	internal virtual Label lblFirstTouch
	{
		get
		{
			return _lblFirstTouch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblFirstTouch != null)
			{
			}
			_lblFirstTouch = value;
			if (_lblFirstTouch == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbFinishing
	{
		get
		{
			return _cmbFinishing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbFinishing != null)
			{
			}
			_cmbFinishing = value;
			if (_cmbFinishing == null)
			{
			}
		}
	}

	internal virtual Label lblFinishing
	{
		get
		{
			return _lblFinishing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblFinishing != null)
			{
			}
			_lblFinishing = value;
			if (_lblFinishing == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbDribbling
	{
		get
		{
			return _cmbDribbling;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbDribbling != null)
			{
			}
			_cmbDribbling = value;
			if (_cmbDribbling == null)
			{
			}
		}
	}

	internal virtual Label lblDribbling
	{
		get
		{
			return _lblDribbling;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDribbling != null)
			{
			}
			_lblDribbling = value;
			if (_lblDribbling == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbCrossing
	{
		get
		{
			return _cmbCrossing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbCrossing != null)
			{
			}
			_cmbCrossing = value;
			if (_cmbCrossing == null)
			{
			}
		}
	}

	internal virtual Label lblCrossing
	{
		get
		{
			return _lblCrossing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCrossing != null)
			{
			}
			_lblCrossing = value;
			if (_lblCrossing == null)
			{
			}
		}
	}

	internal virtual ComboBox cmbCorners
	{
		get
		{
			return _cmbCorners;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_cmbCorners != null)
			{
			}
			_cmbCorners = value;
			if (_cmbCorners == null)
			{
			}
		}
	}

	internal virtual Label lblCorners
	{
		get
		{
			return _lblCorners;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCorners != null)
			{
			}
			_lblCorners = value;
			if (_lblCorners == null)
			{
			}
		}
	}

	internal virtual Button btnConvert
	{
		get
		{
			return _btnConvert;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnConvert != null)
			{
				_btnConvert.Click -= btnConvert_Click;
			}
			_btnConvert = value;
			if (_btnConvert != null)
			{
				_btnConvert.Click += btnConvert_Click;
			}
		}
	}

	internal virtual Button btnReset
	{
		get
		{
			return _btnReset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnReset != null)
			{
				_btnReset.Click -= btnReset_Click;
			}
			_btnReset = value;
			if (_btnReset != null)
			{
				_btnReset.Click += btnReset_Click;
			}
		}
	}

	internal virtual Button btnExit
	{
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnExit != null)
			{
				_btnExit.Click -= btnExit_Click;
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				_btnExit.Click += btnExit_Click;
			}
		}
	}

	internal virtual GroupBox grpPlayerInformation
	{
		get
		{
			return _grpPlayerInformation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_grpPlayerInformation != null)
			{
			}
			_grpPlayerInformation = value;
			if (_grpPlayerInformation == null)
			{
			}
		}
	}

	internal virtual GroupBox grpFM2005Stats
	{
		get
		{
			return _grpFM2005Stats;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_grpFM2005Stats != null)
			{
			}
			_grpFM2005Stats = value;
			if (_grpFM2005Stats == null)
			{
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run(new Verter());
	}

	public Verter()
	{
		base.Load += Verter_Load;
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

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.txtName = new TextBox();
		this.lblName = new Label();
		this.lblPosition = new Label();
		this.cmbPosition = new ComboBox();
		this.grpPlayerInformation = new GroupBox();
		this.grpFM2005Stats = new GroupBox();
		this.cmbTeamwork = new ComboBox();
		this.lblTeamwork = new Label();
		this.cmbPositioning = new ComboBox();
		this.lblPositioning = new Label();
		this.cmbOffTheBall = new ComboBox();
		this.lblOffTheBall = new Label();
		this.cmbInfluence = new ComboBox();
		this.lblInfluence = new Label();
		this.cmbFlair = new ComboBox();
		this.lblFlair = new Label();
		this.cmbDetermination = new ComboBox();
		this.lblDetermination = new Label();
		this.cmbDecisions = new ComboBox();
		this.lblDecisions = new Label();
		this.cmbCreativity = new ComboBox();
		this.lblCreativity = new Label();
		this.cmbConcentration = new ComboBox();
		this.lblConcentration = new Label();
		this.cmbComposure = new ComboBox();
		this.lblComposure = new Label();
		this.cmbPreferredFoot = new ComboBox();
		this.lblPreferredFoot = new Label();
		this.cmbStrength = new ComboBox();
		this.lblStrength = new Label();
		this.cmbStamina = new ComboBox();
		this.lblStamina = new Label();
		this.cmbPace = new ComboBox();
		this.cmbTechnique = new ComboBox();
		this.lblTechnique = new Label();
		this.cmbTackling = new ComboBox();
		this.lblTackling = new Label();
		this.cmbPenaltyTaking = new ComboBox();
		this.lblPenaltyTaking = new Label();
		this.cmbPassing = new ComboBox();
		this.lblPassing = new Label();
		this.cmbMarking = new ComboBox();
		this.lblMarking = new Label();
		this.cmbLongThrows = new ComboBox();
		this.lblLongThrows = new Label();
		this.cmbLongShots = new ComboBox();
		this.lblLongShots = new Label();
		this.cmbHeading = new ComboBox();
		this.lblHeading = new Label();
		this.cmbFreeKicks = new ComboBox();
		this.lblFreeKicks = new Label();
		this.cmbFirstTouch = new ComboBox();
		this.lblFirstTouch = new Label();
		this.cmbFinishing = new ComboBox();
		this.lblFinishing = new Label();
		this.cmbDribbling = new ComboBox();
		this.cmbBravery = new ComboBox();
		this.lblBravery = new Label();
		this.cmbAnticipation = new ComboBox();
		this.lblCrossing = new Label();
		this.lblAnticipation = new Label();
		this.cmbAggression = new ComboBox();
		this.lblAggression = new Label();
		this.cmbCorners = new ComboBox();
		this.lblDribbling = new Label();
		this.lblCorners = new Label();
		this.lblPace = new Label();
		this.cmbNaturalFitness = new ComboBox();
		this.cmbCrossing = new ComboBox();
		this.lblNaturalFitness = new Label();
		this.cmbJumping = new ComboBox();
		this.lblJumping = new Label();
		this.cmbBalance = new ComboBox();
		this.lblBalance = new Label();
		this.cmbAgility = new ComboBox();
		this.lblAgility = new Label();
		this.cmbAcceleration = new ComboBox();
		this.lblAcceleration = new Label();
		this.cmbWorkRate = new ComboBox();
		this.lblWorkRate = new Label();
		this.btnConvert = new Button();
		this.btnReset = new Button();
		this.btnExit = new Button();
		this.grpPlayerInformation.SuspendLayout();
		this.grpFM2005Stats.SuspendLayout();
		this.SuspendLayout();
		this.txtName.AutoSize = false;
		this.txtName.Enabled = false;
		TextBox textBox = this.txtName;
		Point location = new Point(112, 24);
		textBox.Location = location;
		this.txtName.Name = "txtName";
		TextBox textBox2 = this.txtName;
		textBox2.Size = new Size(160, 24);
		this.txtName.TabIndex = 0;
		this.txtName.Text = "";
		this.lblName.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label = this.lblName;
		location = new Point(56, 24);
		label.Location = location;
		this.lblName.Name = "lblName";
		Label label2 = this.lblName;
		label2.Size = new Size(48, 24);
		this.lblName.TabIndex = 2;
		this.lblName.Text = "Name";
		this.lblName.TextAlign = ContentAlignment.MiddleRight;
		this.lblPosition.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label3 = this.lblPosition;
		location = new Point(8, 48);
		label3.Location = location;
		this.lblPosition.Name = "lblPosition";
		Label label4 = this.lblPosition;
		label4.Size = new Size(96, 24);
		this.lblPosition.TabIndex = 4;
		this.lblPosition.Text = "WE/PES Position";
		this.lblPosition.TextAlign = ContentAlignment.MiddleRight;
		this.cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbPosition.ItemHeight = 13;
		this.cmbPosition.Items.AddRange(new object[8] { "CB", "SB", "DMF", "CMF", "SMF", "OMF", "WF", "ST/CF" });
		ComboBox comboBox = this.cmbPosition;
		location = new Point(112, 50);
		comboBox.Location = location;
		this.cmbPosition.Name = "cmbPosition";
		ComboBox comboBox2 = this.cmbPosition;
		comboBox2.Size = new Size(56, 21);
		this.cmbPosition.TabIndex = 6;
		this.grpPlayerInformation.Controls.Add(this.txtName);
		this.grpPlayerInformation.Controls.Add(this.lblName);
		this.grpPlayerInformation.Controls.Add(this.lblPosition);
		this.grpPlayerInformation.Controls.Add(this.cmbPosition);
		GroupBox groupBox = this.grpPlayerInformation;
		location = new Point(128, 8);
		groupBox.Location = location;
		this.grpPlayerInformation.Name = "grpPlayerInformation";
		GroupBox groupBox2 = this.grpPlayerInformation;
		groupBox2.Size = new Size(280, 88);
		this.grpPlayerInformation.TabIndex = 81;
		this.grpPlayerInformation.TabStop = false;
		this.grpPlayerInformation.Text = "Player Information";
		this.grpFM2005Stats.Controls.Add(this.cmbTeamwork);
		this.grpFM2005Stats.Controls.Add(this.lblTeamwork);
		this.grpFM2005Stats.Controls.Add(this.cmbPositioning);
		this.grpFM2005Stats.Controls.Add(this.lblPositioning);
		this.grpFM2005Stats.Controls.Add(this.cmbOffTheBall);
		this.grpFM2005Stats.Controls.Add(this.lblOffTheBall);
		this.grpFM2005Stats.Controls.Add(this.cmbInfluence);
		this.grpFM2005Stats.Controls.Add(this.lblInfluence);
		this.grpFM2005Stats.Controls.Add(this.cmbFlair);
		this.grpFM2005Stats.Controls.Add(this.lblFlair);
		this.grpFM2005Stats.Controls.Add(this.cmbDetermination);
		this.grpFM2005Stats.Controls.Add(this.lblDetermination);
		this.grpFM2005Stats.Controls.Add(this.cmbDecisions);
		this.grpFM2005Stats.Controls.Add(this.lblDecisions);
		this.grpFM2005Stats.Controls.Add(this.cmbCreativity);
		this.grpFM2005Stats.Controls.Add(this.lblCreativity);
		this.grpFM2005Stats.Controls.Add(this.cmbConcentration);
		this.grpFM2005Stats.Controls.Add(this.lblConcentration);
		this.grpFM2005Stats.Controls.Add(this.cmbComposure);
		this.grpFM2005Stats.Controls.Add(this.lblComposure);
		this.grpFM2005Stats.Controls.Add(this.cmbPreferredFoot);
		this.grpFM2005Stats.Controls.Add(this.lblPreferredFoot);
		this.grpFM2005Stats.Controls.Add(this.cmbStrength);
		this.grpFM2005Stats.Controls.Add(this.lblStrength);
		this.grpFM2005Stats.Controls.Add(this.cmbStamina);
		this.grpFM2005Stats.Controls.Add(this.lblStamina);
		this.grpFM2005Stats.Controls.Add(this.cmbPace);
		this.grpFM2005Stats.Controls.Add(this.cmbTechnique);
		this.grpFM2005Stats.Controls.Add(this.lblTechnique);
		this.grpFM2005Stats.Controls.Add(this.cmbTackling);
		this.grpFM2005Stats.Controls.Add(this.lblTackling);
		this.grpFM2005Stats.Controls.Add(this.cmbPenaltyTaking);
		this.grpFM2005Stats.Controls.Add(this.lblPenaltyTaking);
		this.grpFM2005Stats.Controls.Add(this.cmbPassing);
		this.grpFM2005Stats.Controls.Add(this.lblPassing);
		this.grpFM2005Stats.Controls.Add(this.cmbMarking);
		this.grpFM2005Stats.Controls.Add(this.lblMarking);
		this.grpFM2005Stats.Controls.Add(this.cmbLongThrows);
		this.grpFM2005Stats.Controls.Add(this.lblLongThrows);
		this.grpFM2005Stats.Controls.Add(this.cmbLongShots);
		this.grpFM2005Stats.Controls.Add(this.lblLongShots);
		this.grpFM2005Stats.Controls.Add(this.cmbHeading);
		this.grpFM2005Stats.Controls.Add(this.lblHeading);
		this.grpFM2005Stats.Controls.Add(this.cmbFreeKicks);
		this.grpFM2005Stats.Controls.Add(this.lblFreeKicks);
		this.grpFM2005Stats.Controls.Add(this.cmbFirstTouch);
		this.grpFM2005Stats.Controls.Add(this.lblFirstTouch);
		this.grpFM2005Stats.Controls.Add(this.cmbFinishing);
		this.grpFM2005Stats.Controls.Add(this.lblFinishing);
		this.grpFM2005Stats.Controls.Add(this.cmbDribbling);
		this.grpFM2005Stats.Controls.Add(this.cmbBravery);
		this.grpFM2005Stats.Controls.Add(this.lblBravery);
		this.grpFM2005Stats.Controls.Add(this.cmbAnticipation);
		this.grpFM2005Stats.Controls.Add(this.lblCrossing);
		this.grpFM2005Stats.Controls.Add(this.lblAnticipation);
		this.grpFM2005Stats.Controls.Add(this.cmbAggression);
		this.grpFM2005Stats.Controls.Add(this.lblAggression);
		this.grpFM2005Stats.Controls.Add(this.cmbCorners);
		this.grpFM2005Stats.Controls.Add(this.lblDribbling);
		this.grpFM2005Stats.Controls.Add(this.lblCorners);
		this.grpFM2005Stats.Controls.Add(this.lblPace);
		this.grpFM2005Stats.Controls.Add(this.cmbNaturalFitness);
		this.grpFM2005Stats.Controls.Add(this.cmbCrossing);
		this.grpFM2005Stats.Controls.Add(this.lblNaturalFitness);
		this.grpFM2005Stats.Controls.Add(this.cmbJumping);
		this.grpFM2005Stats.Controls.Add(this.lblJumping);
		this.grpFM2005Stats.Controls.Add(this.cmbBalance);
		this.grpFM2005Stats.Controls.Add(this.lblBalance);
		this.grpFM2005Stats.Controls.Add(this.cmbAgility);
		this.grpFM2005Stats.Controls.Add(this.lblAgility);
		this.grpFM2005Stats.Controls.Add(this.cmbAcceleration);
		this.grpFM2005Stats.Controls.Add(this.lblAcceleration);
		this.grpFM2005Stats.Controls.Add(this.cmbWorkRate);
		this.grpFM2005Stats.Controls.Add(this.lblWorkRate);
		GroupBox groupBox3 = this.grpFM2005Stats;
		location = new Point(8, 104);
		groupBox3.Location = location;
		this.grpFM2005Stats.Name = "grpFM2005Stats";
		GroupBox groupBox4 = this.grpFM2005Stats;
		groupBox4.Size = new Size(520, 368);
		this.grpFM2005Stats.TabIndex = 82;
		this.grpFM2005Stats.TabStop = false;
		this.grpFM2005Stats.Text = "Football Manager 2005 Stats";
		this.cmbTeamwork.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbTeamwork.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox3 = this.cmbTeamwork;
		location = new Point(256, 312);
		comboBox3.Location = location;
		this.cmbTeamwork.Name = "cmbTeamwork";
		ComboBox comboBox4 = this.cmbTeamwork;
		comboBox4.Size = new Size(48, 21);
		this.cmbTeamwork.TabIndex = 136;
		this.lblTeamwork.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label5 = this.lblTeamwork;
		location = new Point(168, 312);
		label5.Location = location;
		this.lblTeamwork.Name = "lblTeamwork";
		Label label6 = this.lblTeamwork;
		label6.Size = new Size(80, 24);
		this.lblTeamwork.TabIndex = 135;
		this.lblTeamwork.Text = "Teamwork";
		this.lblTeamwork.TextAlign = ContentAlignment.MiddleRight;
		this.cmbPositioning.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbPositioning.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox5 = this.cmbPositioning;
		location = new Point(256, 288);
		comboBox5.Location = location;
		this.cmbPositioning.Name = "cmbPositioning";
		ComboBox comboBox6 = this.cmbPositioning;
		comboBox6.Size = new Size(48, 21);
		this.cmbPositioning.TabIndex = 134;
		this.lblPositioning.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label7 = this.lblPositioning;
		location = new Point(168, 288);
		label7.Location = location;
		this.lblPositioning.Name = "lblPositioning";
		Label label8 = this.lblPositioning;
		label8.Size = new Size(80, 24);
		this.lblPositioning.TabIndex = 133;
		this.lblPositioning.Text = "Positioning";
		this.lblPositioning.TextAlign = ContentAlignment.MiddleRight;
		this.cmbOffTheBall.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbOffTheBall.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox7 = this.cmbOffTheBall;
		location = new Point(256, 264);
		comboBox7.Location = location;
		this.cmbOffTheBall.Name = "cmbOffTheBall";
		ComboBox comboBox8 = this.cmbOffTheBall;
        Size size = new Size(48, 21);
		comboBox8.Size = size;
		this.cmbOffTheBall.TabIndex = 132;
		this.lblOffTheBall.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label9 = this.lblOffTheBall;
		location = new Point(168, 264);
		label9.Location = location;
		this.lblOffTheBall.Name = "lblOffTheBall";
		Label label10 = this.lblOffTheBall;
		size = new Size(80, 24);
		label10.Size = size;
		this.lblOffTheBall.TabIndex = 131;
		this.lblOffTheBall.Text = "Off The Ball";
		this.lblOffTheBall.TextAlign = ContentAlignment.MiddleRight;
		this.cmbInfluence.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbInfluence.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox9 = this.cmbInfluence;
		location = new Point(256, 240);
		comboBox9.Location = location;
		this.cmbInfluence.Name = "cmbInfluence";
		ComboBox comboBox10 = this.cmbInfluence;
		size = new Size(48, 21);
		comboBox10.Size = size;
		this.cmbInfluence.TabIndex = 130;
		this.lblInfluence.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label11 = this.lblInfluence;
		location = new Point(168, 240);
		label11.Location = location;
		this.lblInfluence.Name = "lblInfluence";
		Label label12 = this.lblInfluence;
		size = new Size(80, 24);
		label12.Size = size;
		this.lblInfluence.TabIndex = 129;
		this.lblInfluence.Text = "Influence";
		this.lblInfluence.TextAlign = ContentAlignment.MiddleRight;
		this.cmbFlair.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbFlair.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox11 = this.cmbFlair;
		location = new Point(256, 216);
		comboBox11.Location = location;
		this.cmbFlair.Name = "cmbFlair";
		ComboBox comboBox12 = this.cmbFlair;
		size = new Size(48, 21);
		comboBox12.Size = size;
		this.cmbFlair.TabIndex = 128;
		this.lblFlair.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label13 = this.lblFlair;
		location = new Point(168, 216);
		label13.Location = location;
		this.lblFlair.Name = "lblFlair";
		Label label14 = this.lblFlair;
		size = new Size(80, 24);
		label14.Size = size;
		this.lblFlair.TabIndex = 127;
		this.lblFlair.Text = "Flair";
		this.lblFlair.TextAlign = ContentAlignment.MiddleRight;
		this.cmbDetermination.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbDetermination.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox13 = this.cmbDetermination;
		location = new Point(256, 192);
		comboBox13.Location = location;
		this.cmbDetermination.Name = "cmbDetermination";
		ComboBox comboBox14 = this.cmbDetermination;
		size = new Size(48, 21);
		comboBox14.Size = size;
		this.cmbDetermination.TabIndex = 126;
		this.lblDetermination.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label15 = this.lblDetermination;
		location = new Point(168, 192);
		label15.Location = location;
		this.lblDetermination.Name = "lblDetermination";
		Label label16 = this.lblDetermination;
		size = new Size(80, 24);
		label16.Size = size;
		this.lblDetermination.TabIndex = 125;
		this.lblDetermination.Text = "Determination";
		this.lblDetermination.TextAlign = ContentAlignment.MiddleRight;
		this.cmbDecisions.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbDecisions.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox15 = this.cmbDecisions;
		location = new Point(256, 168);
		comboBox15.Location = location;
		this.cmbDecisions.Name = "cmbDecisions";
		ComboBox comboBox16 = this.cmbDecisions;
		size = new Size(48, 21);
		comboBox16.Size = size;
		this.cmbDecisions.TabIndex = 124;
		this.lblDecisions.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label17 = this.lblDecisions;
		location = new Point(168, 168);
		label17.Location = location;
		this.lblDecisions.Name = "lblDecisions";
		Label label18 = this.lblDecisions;
		size = new Size(80, 24);
		label18.Size = size;
		this.lblDecisions.TabIndex = 123;
		this.lblDecisions.Text = "Decisions";
		this.lblDecisions.TextAlign = ContentAlignment.MiddleRight;
		this.cmbCreativity.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbCreativity.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox17 = this.cmbCreativity;
		location = new Point(256, 144);
		comboBox17.Location = location;
		this.cmbCreativity.Name = "cmbCreativity";
		ComboBox comboBox18 = this.cmbCreativity;
		size = new Size(48, 21);
		comboBox18.Size = size;
		this.cmbCreativity.TabIndex = 122;
		this.lblCreativity.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label19 = this.lblCreativity;
		location = new Point(168, 144);
		label19.Location = location;
		this.lblCreativity.Name = "lblCreativity";
		Label label20 = this.lblCreativity;
		size = new Size(80, 24);
		label20.Size = size;
		this.lblCreativity.TabIndex = 121;
		this.lblCreativity.Text = "Creativity";
		this.lblCreativity.TextAlign = ContentAlignment.MiddleRight;
		this.cmbConcentration.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbConcentration.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox19 = this.cmbConcentration;
		location = new Point(256, 120);
		comboBox19.Location = location;
		this.cmbConcentration.Name = "cmbConcentration";
		ComboBox comboBox20 = this.cmbConcentration;
		size = new Size(48, 21);
		comboBox20.Size = size;
		this.cmbConcentration.TabIndex = 120;
		this.lblConcentration.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label21 = this.lblConcentration;
		location = new Point(168, 120);
		label21.Location = location;
		this.lblConcentration.Name = "lblConcentration";
		Label label22 = this.lblConcentration;
		size = new Size(80, 24);
		label22.Size = size;
		this.lblConcentration.TabIndex = 119;
		this.lblConcentration.Text = "Concentration";
		this.lblConcentration.TextAlign = ContentAlignment.MiddleRight;
		this.cmbComposure.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbComposure.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox21 = this.cmbComposure;
		location = new Point(256, 96);
		comboBox21.Location = location;
		this.cmbComposure.Name = "cmbComposure";
		ComboBox comboBox22 = this.cmbComposure;
		size = new Size(48, 21);
		comboBox22.Size = size;
		this.cmbComposure.TabIndex = 118;
		this.lblComposure.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label23 = this.lblComposure;
		location = new Point(168, 96);
		label23.Location = location;
		this.lblComposure.Name = "lblComposure";
		Label label24 = this.lblComposure;
		size = new Size(80, 24);
		label24.Size = size;
		this.lblComposure.TabIndex = 117;
		this.lblComposure.Text = "Composure";
		this.lblComposure.TextAlign = ContentAlignment.MiddleRight;
		this.cmbPreferredFoot.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbPreferredFoot.Items.AddRange(new object[5] { "Right", "Right Only", "Left", "Left Only", "Either" });
		ComboBox comboBox23 = this.cmbPreferredFoot;
		location = new Point(408, 216);
		comboBox23.Location = location;
		this.cmbPreferredFoot.Name = "cmbPreferredFoot";
		ComboBox comboBox24 = this.cmbPreferredFoot;
		size = new Size(96, 21);
		comboBox24.Size = size;
		this.cmbPreferredFoot.TabIndex = 156;
		this.lblPreferredFoot.BackColor = Color.Transparent;
		this.lblPreferredFoot.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label25 = this.lblPreferredFoot;
		location = new Point(320, 216);
		label25.Location = location;
		this.lblPreferredFoot.Name = "lblPreferredFoot";
		Label label26 = this.lblPreferredFoot;
		size = new Size(80, 24);
		label26.Size = size;
		this.lblPreferredFoot.TabIndex = 155;
		this.lblPreferredFoot.Text = "Preferred Foot";
		this.lblPreferredFoot.TextAlign = ContentAlignment.MiddleRight;
		this.cmbStrength.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbStrength.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox25 = this.cmbStrength;
		location = new Point(408, 192);
		comboBox25.Location = location;
		this.cmbStrength.Name = "cmbStrength";
		ComboBox comboBox26 = this.cmbStrength;
		size = new Size(48, 21);
		comboBox26.Size = size;
		this.cmbStrength.TabIndex = 154;
		this.lblStrength.BackColor = Color.Transparent;
		this.lblStrength.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label27 = this.lblStrength;
		location = new Point(320, 192);
		label27.Location = location;
		this.lblStrength.Name = "lblStrength";
		Label label28 = this.lblStrength;
		size = new Size(80, 24);
		label28.Size = size;
		this.lblStrength.TabIndex = 153;
		this.lblStrength.Text = "Strength";
		this.lblStrength.TextAlign = ContentAlignment.MiddleRight;
		this.cmbStamina.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbStamina.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox27 = this.cmbStamina;
		location = new Point(408, 168);
		comboBox27.Location = location;
		this.cmbStamina.Name = "cmbStamina";
		ComboBox comboBox28 = this.cmbStamina;
		size = new Size(48, 21);
		comboBox28.Size = size;
		this.cmbStamina.TabIndex = 152;
		this.lblStamina.BackColor = Color.Transparent;
		this.lblStamina.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label29 = this.lblStamina;
		location = new Point(320, 168);
		label29.Location = location;
		this.lblStamina.Name = "lblStamina";
		Label label30 = this.lblStamina;
		size = new Size(80, 24);
		label30.Size = size;
		this.lblStamina.TabIndex = 151;
		this.lblStamina.Text = "Stamina";
		this.lblStamina.TextAlign = ContentAlignment.MiddleRight;
		this.cmbPace.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbPace.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox29 = this.cmbPace;
		location = new Point(408, 144);
		comboBox29.Location = location;
		this.cmbPace.Name = "cmbPace";
		ComboBox comboBox30 = this.cmbPace;
		size = new Size(48, 21);
		comboBox30.Size = size;
		this.cmbPace.TabIndex = 150;
		this.cmbTechnique.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbTechnique.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox31 = this.cmbTechnique;
		location = new Point(104, 336);
		comboBox31.Location = location;
		this.cmbTechnique.Name = "cmbTechnique";
		ComboBox comboBox32 = this.cmbTechnique;
		size = new Size(48, 21);
		comboBox32.Size = size;
		this.cmbTechnique.TabIndex = 110;
		this.lblTechnique.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label31 = this.lblTechnique;
		location = new Point(16, 336);
		label31.Location = location;
		this.lblTechnique.Name = "lblTechnique";
		Label label32 = this.lblTechnique;
		size = new Size(80, 24);
		label32.Size = size;
		this.lblTechnique.TabIndex = 109;
		this.lblTechnique.Text = "Technique";
		this.lblTechnique.TextAlign = ContentAlignment.MiddleRight;
		this.cmbTackling.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbTackling.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox33 = this.cmbTackling;
		location = new Point(104, 312);
		comboBox33.Location = location;
		this.cmbTackling.Name = "cmbTackling";
		ComboBox comboBox34 = this.cmbTackling;
		size = new Size(48, 21);
		comboBox34.Size = size;
		this.cmbTackling.TabIndex = 108;
		this.lblTackling.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label33 = this.lblTackling;
		location = new Point(16, 312);
		label33.Location = location;
		this.lblTackling.Name = "lblTackling";
		Label label34 = this.lblTackling;
		size = new Size(80, 24);
		label34.Size = size;
		this.lblTackling.TabIndex = 107;
		this.lblTackling.Text = "Tackling";
		this.lblTackling.TextAlign = ContentAlignment.MiddleRight;
		this.cmbPenaltyTaking.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbPenaltyTaking.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox35 = this.cmbPenaltyTaking;
		location = new Point(104, 288);
		comboBox35.Location = location;
		this.cmbPenaltyTaking.Name = "cmbPenaltyTaking";
		ComboBox comboBox36 = this.cmbPenaltyTaking;
		size = new Size(48, 21);
		comboBox36.Size = size;
		this.cmbPenaltyTaking.TabIndex = 106;
		this.lblPenaltyTaking.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label35 = this.lblPenaltyTaking;
		location = new Point(16, 288);
		label35.Location = location;
		this.lblPenaltyTaking.Name = "lblPenaltyTaking";
		Label label36 = this.lblPenaltyTaking;
		size = new Size(80, 24);
		label36.Size = size;
		this.lblPenaltyTaking.TabIndex = 105;
		this.lblPenaltyTaking.Text = "Penalty Taking";
		this.lblPenaltyTaking.TextAlign = ContentAlignment.MiddleRight;
		this.cmbPassing.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbPassing.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox37 = this.cmbPassing;
		location = new Point(104, 264);
		comboBox37.Location = location;
		this.cmbPassing.Name = "cmbPassing";
		ComboBox comboBox38 = this.cmbPassing;
		size = new Size(48, 21);
		comboBox38.Size = size;
		this.cmbPassing.TabIndex = 104;
		this.lblPassing.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label37 = this.lblPassing;
		location = new Point(16, 264);
		label37.Location = location;
		this.lblPassing.Name = "lblPassing";
		Label label38 = this.lblPassing;
		size = new Size(80, 24);
		label38.Size = size;
		this.lblPassing.TabIndex = 103;
		this.lblPassing.Text = "Passing";
		this.lblPassing.TextAlign = ContentAlignment.MiddleRight;
		this.cmbMarking.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbMarking.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox39 = this.cmbMarking;
		location = new Point(104, 240);
		comboBox39.Location = location;
		this.cmbMarking.Name = "cmbMarking";
		ComboBox comboBox40 = this.cmbMarking;
		size = new Size(48, 21);
		comboBox40.Size = size;
		this.cmbMarking.TabIndex = 102;
		this.lblMarking.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label39 = this.lblMarking;
		location = new Point(16, 240);
		label39.Location = location;
		this.lblMarking.Name = "lblMarking";
		Label label40 = this.lblMarking;
		size = new Size(80, 24);
		label40.Size = size;
		this.lblMarking.TabIndex = 101;
		this.lblMarking.Text = "Marking";
		this.lblMarking.TextAlign = ContentAlignment.MiddleRight;
		this.cmbLongThrows.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbLongThrows.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox41 = this.cmbLongThrows;
		location = new Point(104, 216);
		comboBox41.Location = location;
		this.cmbLongThrows.Name = "cmbLongThrows";
		ComboBox comboBox42 = this.cmbLongThrows;
		size = new Size(48, 21);
		comboBox42.Size = size;
		this.cmbLongThrows.TabIndex = 100;
		this.lblLongThrows.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label41 = this.lblLongThrows;
		location = new Point(16, 216);
		label41.Location = location;
		this.lblLongThrows.Name = "lblLongThrows";
		Label label42 = this.lblLongThrows;
		size = new Size(80, 24);
		label42.Size = size;
		this.lblLongThrows.TabIndex = 99;
		this.lblLongThrows.Text = "Long Throws";
		this.lblLongThrows.TextAlign = ContentAlignment.MiddleRight;
		this.cmbLongShots.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbLongShots.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox43 = this.cmbLongShots;
		location = new Point(104, 192);
		comboBox43.Location = location;
		this.cmbLongShots.Name = "cmbLongShots";
		ComboBox comboBox44 = this.cmbLongShots;
		size = new Size(48, 21);
		comboBox44.Size = size;
		this.cmbLongShots.TabIndex = 98;
		this.lblLongShots.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label43 = this.lblLongShots;
		location = new Point(16, 192);
		label43.Location = location;
		this.lblLongShots.Name = "lblLongShots";
		Label label44 = this.lblLongShots;
		size = new Size(80, 24);
		label44.Size = size;
		this.lblLongShots.TabIndex = 97;
		this.lblLongShots.Text = "Long Shots";
		this.lblLongShots.TextAlign = ContentAlignment.MiddleRight;
		this.cmbHeading.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbHeading.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox45 = this.cmbHeading;
		location = new Point(104, 168);
		comboBox45.Location = location;
		this.cmbHeading.Name = "cmbHeading";
		ComboBox comboBox46 = this.cmbHeading;
		size = new Size(48, 21);
		comboBox46.Size = size;
		this.cmbHeading.TabIndex = 96;
		this.lblHeading.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label45 = this.lblHeading;
		location = new Point(16, 168);
		label45.Location = location;
		this.lblHeading.Name = "lblHeading";
		Label label46 = this.lblHeading;
		size = new Size(80, 24);
		label46.Size = size;
		this.lblHeading.TabIndex = 95;
		this.lblHeading.Text = "Heading";
		this.lblHeading.TextAlign = ContentAlignment.MiddleRight;
		this.cmbFreeKicks.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbFreeKicks.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox47 = this.cmbFreeKicks;
		location = new Point(104, 144);
		comboBox47.Location = location;
		this.cmbFreeKicks.Name = "cmbFreeKicks";
		ComboBox comboBox48 = this.cmbFreeKicks;
		size = new Size(48, 21);
		comboBox48.Size = size;
		this.cmbFreeKicks.TabIndex = 94;
		this.lblFreeKicks.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label47 = this.lblFreeKicks;
		location = new Point(16, 144);
		label47.Location = location;
		this.lblFreeKicks.Name = "lblFreeKicks";
		Label label48 = this.lblFreeKicks;
		size = new Size(80, 24);
		label48.Size = size;
		this.lblFreeKicks.TabIndex = 93;
		this.lblFreeKicks.Text = "Free Kicks";
		this.lblFreeKicks.TextAlign = ContentAlignment.MiddleRight;
		this.cmbFirstTouch.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbFirstTouch.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox49 = this.cmbFirstTouch;
		location = new Point(104, 120);
		comboBox49.Location = location;
		this.cmbFirstTouch.Name = "cmbFirstTouch";
		ComboBox comboBox50 = this.cmbFirstTouch;
		size = new Size(48, 21);
		comboBox50.Size = size;
		this.cmbFirstTouch.TabIndex = 92;
		this.lblFirstTouch.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label49 = this.lblFirstTouch;
		location = new Point(16, 120);
		label49.Location = location;
		this.lblFirstTouch.Name = "lblFirstTouch";
		Label label50 = this.lblFirstTouch;
		size = new Size(80, 24);
		label50.Size = size;
		this.lblFirstTouch.TabIndex = 91;
		this.lblFirstTouch.Text = "First Touch";
		this.lblFirstTouch.TextAlign = ContentAlignment.MiddleRight;
		this.cmbFinishing.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbFinishing.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox51 = this.cmbFinishing;
		location = new Point(104, 96);
		comboBox51.Location = location;
		this.cmbFinishing.Name = "cmbFinishing";
		ComboBox comboBox52 = this.cmbFinishing;
		size = new Size(48, 21);
		comboBox52.Size = size;
		this.cmbFinishing.TabIndex = 90;
		this.lblFinishing.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label51 = this.lblFinishing;
		location = new Point(16, 96);
		label51.Location = location;
		this.lblFinishing.Name = "lblFinishing";
		Label label52 = this.lblFinishing;
		size = new Size(80, 24);
		label52.Size = size;
		this.lblFinishing.TabIndex = 89;
		this.lblFinishing.Text = "Finishing";
		this.lblFinishing.TextAlign = ContentAlignment.MiddleRight;
		this.cmbDribbling.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbDribbling.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox53 = this.cmbDribbling;
		location = new Point(104, 72);
		comboBox53.Location = location;
		this.cmbDribbling.Name = "cmbDribbling";
		ComboBox comboBox54 = this.cmbDribbling;
		size = new Size(48, 21);
		comboBox54.Size = size;
		this.cmbDribbling.TabIndex = 88;
		this.cmbBravery.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbBravery.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox55 = this.cmbBravery;
		location = new Point(256, 72);
		comboBox55.Location = location;
		this.cmbBravery.Name = "cmbBravery";
		ComboBox comboBox56 = this.cmbBravery;
		size = new Size(48, 21);
		comboBox56.Size = size;
		this.cmbBravery.TabIndex = 116;
		this.lblBravery.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label53 = this.lblBravery;
		location = new Point(168, 72);
		label53.Location = location;
		this.lblBravery.Name = "lblBravery";
		Label label54 = this.lblBravery;
		size = new Size(80, 24);
		label54.Size = size;
		this.lblBravery.TabIndex = 115;
		this.lblBravery.Text = "Bravery";
		this.lblBravery.TextAlign = ContentAlignment.MiddleRight;
		this.cmbAnticipation.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbAnticipation.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox57 = this.cmbAnticipation;
		location = new Point(256, 48);
		comboBox57.Location = location;
		this.cmbAnticipation.Name = "cmbAnticipation";
		ComboBox comboBox58 = this.cmbAnticipation;
		size = new Size(48, 21);
		comboBox58.Size = size;
		this.cmbAnticipation.TabIndex = 114;
		this.lblCrossing.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label55 = this.lblCrossing;
		location = new Point(16, 48);
		label55.Location = location;
		this.lblCrossing.Name = "lblCrossing";
		Label label56 = this.lblCrossing;
		size = new Size(80, 24);
		label56.Size = size;
		this.lblCrossing.TabIndex = 85;
		this.lblCrossing.Text = "Crossing";
		this.lblCrossing.TextAlign = ContentAlignment.MiddleRight;
		this.lblAnticipation.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label57 = this.lblAnticipation;
		location = new Point(168, 48);
		label57.Location = location;
		this.lblAnticipation.Name = "lblAnticipation";
		Label label58 = this.lblAnticipation;
		size = new Size(80, 24);
		label58.Size = size;
		this.lblAnticipation.TabIndex = 113;
		this.lblAnticipation.Text = "Anticipation";
		this.lblAnticipation.TextAlign = ContentAlignment.MiddleRight;
		this.cmbAggression.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbAggression.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox59 = this.cmbAggression;
		location = new Point(256, 24);
		comboBox59.Location = location;
		this.cmbAggression.Name = "cmbAggression";
		ComboBox comboBox60 = this.cmbAggression;
		size = new Size(48, 21);
		comboBox60.Size = size;
		this.cmbAggression.TabIndex = 112;
		this.lblAggression.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label59 = this.lblAggression;
		location = new Point(168, 24);
		label59.Location = location;
		this.lblAggression.Name = "lblAggression";
		Label label60 = this.lblAggression;
		size = new Size(80, 24);
		label60.Size = size;
		this.lblAggression.TabIndex = 111;
		this.lblAggression.Text = "Aggression";
		this.lblAggression.TextAlign = ContentAlignment.MiddleRight;
		this.cmbCorners.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbCorners.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox61 = this.cmbCorners;
		location = new Point(104, 24);
		comboBox61.Location = location;
		this.cmbCorners.Name = "cmbCorners";
		ComboBox comboBox62 = this.cmbCorners;
		size = new Size(48, 21);
		comboBox62.Size = size;
		this.cmbCorners.TabIndex = 84;
		this.lblDribbling.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label61 = this.lblDribbling;
		location = new Point(16, 72);
		label61.Location = location;
		this.lblDribbling.Name = "lblDribbling";
		Label label62 = this.lblDribbling;
		size = new Size(80, 24);
		label62.Size = size;
		this.lblDribbling.TabIndex = 87;
		this.lblDribbling.Text = "Dribbling";
		this.lblDribbling.TextAlign = ContentAlignment.MiddleRight;
		this.lblCorners.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label63 = this.lblCorners;
		location = new Point(16, 24);
		label63.Location = location;
		this.lblCorners.Name = "lblCorners";
		Label label64 = this.lblCorners;
		size = new Size(80, 24);
		label64.Size = size;
		this.lblCorners.TabIndex = 83;
		this.lblCorners.Text = "Corners";
		this.lblCorners.TextAlign = ContentAlignment.MiddleRight;
		this.lblPace.BackColor = Color.Transparent;
		this.lblPace.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label65 = this.lblPace;
		location = new Point(320, 144);
		label65.Location = location;
		this.lblPace.Name = "lblPace";
		Label label66 = this.lblPace;
		size = new Size(80, 24);
		label66.Size = size;
		this.lblPace.TabIndex = 149;
		this.lblPace.Text = "Pace";
		this.lblPace.TextAlign = ContentAlignment.MiddleRight;
		this.cmbNaturalFitness.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbNaturalFitness.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox63 = this.cmbNaturalFitness;
		location = new Point(408, 120);
		comboBox63.Location = location;
		this.cmbNaturalFitness.Name = "cmbNaturalFitness";
		ComboBox comboBox64 = this.cmbNaturalFitness;
		size = new Size(48, 21);
		comboBox64.Size = size;
		this.cmbNaturalFitness.TabIndex = 148;
		this.cmbCrossing.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbCrossing.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox65 = this.cmbCrossing;
		location = new Point(104, 48);
		comboBox65.Location = location;
		this.cmbCrossing.Name = "cmbCrossing";
		ComboBox comboBox66 = this.cmbCrossing;
		size = new Size(48, 21);
		comboBox66.Size = size;
		this.cmbCrossing.TabIndex = 86;
		this.lblNaturalFitness.BackColor = Color.Transparent;
		this.lblNaturalFitness.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label67 = this.lblNaturalFitness;
		location = new Point(320, 120);
		label67.Location = location;
		this.lblNaturalFitness.Name = "lblNaturalFitness";
		Label label68 = this.lblNaturalFitness;
		size = new Size(80, 24);
		label68.Size = size;
		this.lblNaturalFitness.TabIndex = 147;
		this.lblNaturalFitness.Text = "Natural Fitness";
		this.lblNaturalFitness.TextAlign = ContentAlignment.MiddleRight;
		this.cmbJumping.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbJumping.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox67 = this.cmbJumping;
		location = new Point(408, 96);
		comboBox67.Location = location;
		this.cmbJumping.Name = "cmbJumping";
		ComboBox comboBox68 = this.cmbJumping;
		size = new Size(48, 21);
		comboBox68.Size = size;
		this.cmbJumping.TabIndex = 146;
		this.lblJumping.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label69 = this.lblJumping;
		location = new Point(320, 96);
		label69.Location = location;
		this.lblJumping.Name = "lblJumping";
		Label label70 = this.lblJumping;
		size = new Size(80, 24);
		label70.Size = size;
		this.lblJumping.TabIndex = 145;
		this.lblJumping.Text = "Jumping";
		this.lblJumping.TextAlign = ContentAlignment.MiddleRight;
		this.cmbBalance.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbBalance.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox69 = this.cmbBalance;
		location = new Point(408, 72);
		comboBox69.Location = location;
		this.cmbBalance.Name = "cmbBalance";
		ComboBox comboBox70 = this.cmbBalance;
		size = new Size(48, 21);
		comboBox70.Size = size;
		this.cmbBalance.TabIndex = 144;
		this.lblBalance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label71 = this.lblBalance;
		location = new Point(320, 72);
		label71.Location = location;
		this.lblBalance.Name = "lblBalance";
		Label label72 = this.lblBalance;
		size = new Size(80, 24);
		label72.Size = size;
		this.lblBalance.TabIndex = 143;
		this.lblBalance.Text = "Balance";
		this.lblBalance.TextAlign = ContentAlignment.MiddleRight;
		this.cmbAgility.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbAgility.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox71 = this.cmbAgility;
		location = new Point(408, 48);
		comboBox71.Location = location;
		this.cmbAgility.Name = "cmbAgility";
		ComboBox comboBox72 = this.cmbAgility;
		size = new Size(48, 21);
		comboBox72.Size = size;
		this.cmbAgility.TabIndex = 142;
		this.lblAgility.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label73 = this.lblAgility;
		location = new Point(320, 48);
		label73.Location = location;
		this.lblAgility.Name = "lblAgility";
		Label label74 = this.lblAgility;
		size = new Size(80, 24);
		label74.Size = size;
		this.lblAgility.TabIndex = 141;
		this.lblAgility.Text = "Agility";
		this.lblAgility.TextAlign = ContentAlignment.MiddleRight;
		this.cmbAcceleration.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbAcceleration.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox73 = this.cmbAcceleration;
		location = new Point(408, 24);
		comboBox73.Location = location;
		this.cmbAcceleration.Name = "cmbAcceleration";
		ComboBox comboBox74 = this.cmbAcceleration;
		size = new Size(48, 21);
		comboBox74.Size = size;
		this.cmbAcceleration.TabIndex = 140;
		this.lblAcceleration.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label75 = this.lblAcceleration;
		location = new Point(320, 24);
		label75.Location = location;
		this.lblAcceleration.Name = "lblAcceleration";
		Label label76 = this.lblAcceleration;
		size = new Size(80, 24);
		label76.Size = size;
		this.lblAcceleration.TabIndex = 139;
		this.lblAcceleration.Text = "Acceleration";
		this.lblAcceleration.TextAlign = ContentAlignment.MiddleRight;
		this.cmbWorkRate.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbWorkRate.Items.AddRange(new object[20]
		{
			"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
			"11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
		});
		ComboBox comboBox75 = this.cmbWorkRate;
		location = new Point(256, 336);
		comboBox75.Location = location;
		this.cmbWorkRate.Name = "cmbWorkRate";
		ComboBox comboBox76 = this.cmbWorkRate;
		size = new Size(48, 21);
		comboBox76.Size = size;
		this.cmbWorkRate.TabIndex = 138;
		this.lblWorkRate.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Label label77 = this.lblWorkRate;
		location = new Point(168, 336);
		label77.Location = location;
		this.lblWorkRate.Name = "lblWorkRate";
		Label label78 = this.lblWorkRate;
		size = new Size(80, 24);
		label78.Size = size;
		this.lblWorkRate.TabIndex = 137;
		this.lblWorkRate.Text = "Work Rate";
		this.lblWorkRate.TextAlign = ContentAlignment.MiddleRight;
		Button button = this.btnConvert;
		location = new Point(152, 480);
		button.Location = location;
		this.btnConvert.Name = "btnConvert";
		Button button2 = this.btnConvert;
		size = new Size(72, 24);
		button2.Size = size;
		this.btnConvert.TabIndex = 83;
		this.btnConvert.Text = "&Convert";
		Button button3 = this.btnReset;
		location = new Point(232, 480);
		button3.Location = location;
		this.btnReset.Name = "btnReset";
		Button button4 = this.btnReset;
		size = new Size(72, 24);
		button4.Size = size;
		this.btnReset.TabIndex = 84;
		this.btnReset.Text = "&Reset";
		Button button5 = this.btnExit;
		location = new Point(312, 480);
		button5.Location = location;
		this.btnExit.Name = "btnExit";
		Button button6 = this.btnExit;
		size = new Size(72, 24);
		button6.Size = size;
		this.btnExit.TabIndex = 85;
		this.btnExit.Text = "E&xit";
		size = new Size(5, 14);
		this.AutoScaleBaseSize = size;
		this.BackColor = SystemColors.Control;
		size = new Size(536, 518);
		this.ClientSize = size;
		this.Controls.Add(this.btnExit);
		this.Controls.Add(this.btnReset);
		this.Controls.Add(this.btnConvert);
		this.Controls.Add(this.grpFM2005Stats);
		this.Controls.Add(this.grpPlayerInformation);
		this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.Name = "Verter";
		this.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Verter - The Ultimate FM-to-WE/PES Stats Converter";
		this.grpPlayerInformation.ResumeLayout(false);
		this.grpFM2005Stats.ResumeLayout(false);
		this.ResumeLayout(false);
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
			decimal d = new decimal((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbHeading.SelectedIndex + cmbLongShots.SelectedIndex + cmbLongThrows.SelectedIndex + cmbMarking.SelectedIndex + cmbPassing.SelectedIndex + cmbPenaltyTaking.SelectedIndex + cmbTackling.SelectedIndex + cmbTechnique.SelectedIndex + cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbCreativity.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbFlair.SelectedIndex + cmbInfluence.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPositioning.SelectedIndex + cmbTeamwork.SelectedIndex + cmbWorkRate.SelectedIndex + cmbAcceleration.SelectedIndex + cmbAgility.SelectedIndex + cmbBalance.SelectedIndex + cmbJumping.SelectedIndex + cmbNaturalFitness.SelectedIndex + cmbPace.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + 36) / 36.0);
			int num = (int)Math.Round(5.0 * ((double)(cmbNaturalFitness.SelectedIndex + 1) * 0.4) / 8.0 + 3.0);
			if (num > 7)
			{
				frmWEPES.lblStabilityOfCondition.ForeColor = Color.Red;
				frmWEPES.lblStabilityOfCondition.Text = StringType.FromInteger(8);
			}
			else if (num > 6)
			{
				frmWEPES.lblStabilityOfCondition.ForeColor = Color.Orange;
				frmWEPES.lblStabilityOfCondition.Text = StringType.FromInteger(7);
			}
			else
			{
				frmWEPES.lblStabilityOfCondition.ForeColor = Color.Empty;
				frmWEPES.lblStabilityOfCondition.Text = StringType.FromInteger(num);
			}
			int num2 = (int)Math.Round(5.0 * ((double)(cmbComposure.SelectedIndex + cmbDetermination.SelectedIndex + 2) / 2.0 * 0.4) / 8.0 + 3.0);
			if (num2 > 7)
			{
				frmWEPES.lblStabilityOfPlay.ForeColor = Color.Red;
				frmWEPES.lblStabilityOfPlay.Text = StringType.FromInteger(8);
			}
			else if (num2 > 6)
			{
				frmWEPES.lblStabilityOfPlay.ForeColor = Color.Orange;
				frmWEPES.lblStabilityOfPlay.Text = StringType.FromInteger(7);
			}
			else
			{
				frmWEPES.lblStabilityOfPlay.ForeColor = Color.Empty;
				frmWEPES.lblStabilityOfPlay.Text = StringType.FromInteger(num2);
			}
			if ((cmbPreferredFoot.SelectedIndex == 0) | (cmbPreferredFoot.SelectedIndex == 2))
			{
				if (cmbTechnique.SelectedIndex < 14)
				{
					frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Empty;
					frmWEPES.lblSecondFootFrequency.ForeColor = Color.Empty;
					frmWEPES.lblSecondFootAccuracy.Text = StringType.FromInteger(5);
					frmWEPES.lblSecondFootFrequency.Text = StringType.FromInteger(5);
				}
				else
				{
					frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Empty;
					frmWEPES.lblSecondFootFrequency.ForeColor = Color.Empty;
					frmWEPES.lblSecondFootAccuracy.Text = StringType.FromInteger(6);
					frmWEPES.lblSecondFootFrequency.Text = StringType.FromInteger(6);
				}
			}
			else if ((cmbPreferredFoot.SelectedIndex == 1) | (cmbPreferredFoot.SelectedIndex == 3))
			{
				if (cmbTechnique.SelectedIndex < 14)
				{
					frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Empty;
					frmWEPES.lblSecondFootFrequency.ForeColor = Color.Empty;
					frmWEPES.lblSecondFootAccuracy.Text = StringType.FromInteger(3);
					frmWEPES.lblSecondFootFrequency.Text = StringType.FromInteger(3);
				}
				else
				{
					frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Empty;
					frmWEPES.lblSecondFootFrequency.ForeColor = Color.Empty;
					frmWEPES.lblSecondFootAccuracy.Text = StringType.FromInteger(4);
					frmWEPES.lblSecondFootFrequency.Text = StringType.FromInteger(4);
				}
			}
			else if (cmbTechnique.SelectedIndex < 14)
			{
				frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Red;
				frmWEPES.lblSecondFootAccuracy.Text = StringType.FromInteger(7);
				frmWEPES.lblSecondFootFrequency.ForeColor = Color.Red;
				frmWEPES.lblSecondFootFrequency.Text = StringType.FromInteger(7);
			}
			else
			{
				frmWEPES.lblSecondFootAccuracy.ForeColor = Color.Red;
				frmWEPES.lblSecondFootAccuracy.Text = StringType.FromInteger(8);
				frmWEPES.lblSecondFootFrequency.ForeColor = Color.Red;
				frmWEPES.lblSecondFootFrequency.Text = StringType.FromInteger(8);
			}
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			int num7 = default(int);
			int num8 = default(int);
			int num9 = default(int);
			int num10 = default(int);
			int num11 = default(int);
			int num12 = default(int);
			int num13 = default(int);
			int num14 = default(int);
			int num15 = default(int);
			int num16 = default(int);
			int num17 = default(int);
			int num18 = default(int);
			int num19 = default(int);
			int num20 = default(int);
			int num21 = default(int);
			int num22 = default(int);
			int num23 = default(int);
			int num24 = default(int);
			int num25 = default(int);
			int num26 = default(int);
			int num27 = default(int);
			if (cmbPosition.SelectedIndex == 0)
			{
				num3 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBBodyBalanceMax, decCBBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBBodyBalanceMin));
				num4 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBStaminaMax, decCBStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBStaminaMin));
				num5 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBTopSpeedMax, decCBTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBTopSpeedMin));
				num6 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAccelerationMax, decCBAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBAccelerationMin));
				num7 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAgilityMax, decCBAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBAgilityMin));
				num8 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBJumpMax, decCBJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBJumpMin));
				if (decimal.Compare(d, decCBStarPlayer) >= 0)
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAttackMax, decCBAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decCBAttackMin));
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDefenseMax, decCBDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decCBDefenseMin));
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBResponseMax, decCBResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBResponseMin));
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDribblePrecisionMax, decCBDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBDribblePrecisionMin));
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDribbleSpeedMax, decCBDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decCBDribbleSpeedMin));
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShortPassPrecisionMax, decCBShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBShortPassPrecisionMin));
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShortPassSpeedMax, decCBShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShortPassSpeedMin));
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBLongPassPrecisionMax, decCBLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBLongPassPrecisionMin));
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBLongPassSpeedMax, decCBLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBLongPassSpeedMin));
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotPrecisionMax, decCBShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBShotPrecisionMin));
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotPowerMax, decCBShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShotPowerMin));
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotTechniqueMax, decCBShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShotTechniqueMin));
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBFreeKickPrecisionMax, decCBFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBFreeKickPrecisionMin));
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBBendMax, decCBBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBBendMin));
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBHeadingMax, decCBHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBHeadingMin));
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBTechniqueMax, decCBTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBTechniqueMin));
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAggressivenessMax, decCBAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBAggressivenessMin));
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBMentalityMax, decCBMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decCBMentalityMin));
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBCooperationMax, decCBCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBCooperationMin));
				}
				else
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAttackMax, decCBAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decCBAttackMin) - 5.0);
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDefenseMax, decCBDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decCBDefenseMin) - 5.0);
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBResponseMax, decCBResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBResponseMin) - 5.0);
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDribblePrecisionMax, decCBDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBDribblePrecisionMin) - 5.0);
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBDribbleSpeedMax, decCBDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decCBDribbleSpeedMin) - 5.0);
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShortPassPrecisionMax, decCBShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBShortPassPrecisionMin) - 5.0);
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShortPassSpeedMax, decCBShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShortPassSpeedMin) - 5.0);
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBLongPassPrecisionMax, decCBLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBLongPassPrecisionMin) - 5.0);
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBLongPassSpeedMax, decCBLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBLongPassSpeedMin) - 5.0);
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotPrecisionMax, decCBShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBShotPrecisionMin) - 5.0);
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotPowerMax, decCBShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShotPowerMin) - 5.0);
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBShotTechniqueMax, decCBShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decCBShotTechniqueMin) - 5.0);
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBFreeKickPrecisionMax, decCBFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBFreeKickPrecisionMin) - 5.0);
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBBendMax, decCBBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decCBBendMin) - 5.0);
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBHeadingMax, decCBHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBHeadingMin) - 5.0);
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBTechniqueMax, decCBTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBTechniqueMin) - 5.0);
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBAggressivenessMax, decCBAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBAggressivenessMin) - 5.0);
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBMentalityMax, decCBMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decCBMentalityMin) - 5.0);
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decCBCooperationMax, decCBCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decCBCooperationMin) - 5.0);
				}
			}
			if (cmbPosition.SelectedIndex == 1)
			{
				num3 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBBodyBalanceMax, decSBBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBBodyBalanceMin));
				num4 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBStaminaMax, decSBStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBStaminaMin));
				num5 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBTopSpeedMax, decSBTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBTopSpeedMin));
				num7 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAgilityMax, decSBAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBAgilityMin));
				num6 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAccelerationMax, decSBAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBAccelerationMin));
				num8 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBJumpMax, decSBJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBJumpMin));
				if (decimal.Compare(d, decSBStarPlayer) >= 0)
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAttackMax, decSBAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSBAttackMin));
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDefenseMax, decSBDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSBDefenseMin));
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBResponseMax, decSBResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBResponseMin));
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDribblePrecisionMax, decSBDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBDribblePrecisionMin));
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDribbleSpeedMax, decSBDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSBDribbleSpeedMin));
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShortPassPrecisionMax, decSBShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBShortPassPrecisionMin));
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShortPassSpeedMax, decSBShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShortPassSpeedMin));
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBLongPassPrecisionMax, decSBLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBLongPassPrecisionMin));
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBLongPassSpeedMax, decSBLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBLongPassSpeedMin));
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotPrecisionMax, decSBShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBShotPrecisionMin));
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotPowerMax, decSBShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShotPowerMin));
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotTechniqueMax, decSBShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShotTechniqueMin));
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBFreeKickPrecisionMax, decSBFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBFreeKickPrecisionMin));
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBBendMax, decSBBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBBendMin));
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBHeadingMax, decSBHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBHeadingMin));
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBTechniqueMax, decSBTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBTechniqueMin));
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAggressivenessMax, decSBAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBAggressivenessMin));
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBMentalityMax, decSBMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSBMentalityMin));
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBCooperationMax, decSBCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBCooperationMin));
				}
				else
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAttackMax, decSBAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSBAttackMin) - 5.0);
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDefenseMax, decSBDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSBDefenseMin) - 5.0);
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBResponseMax, decSBResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBResponseMin) - 5.0);
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDribblePrecisionMax, decSBDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBDribblePrecisionMin) - 5.0);
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBDribbleSpeedMax, decSBDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSBDribbleSpeedMin) - 5.0);
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShortPassPrecisionMax, decSBShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBShortPassPrecisionMin) - 5.0);
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShortPassSpeedMax, decSBShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShortPassSpeedMin) - 5.0);
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBLongPassPrecisionMax, decSBLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBLongPassPrecisionMin) - 5.0);
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBLongPassSpeedMax, decSBLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBLongPassSpeedMin) - 5.0);
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotPrecisionMax, decSBShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBShotPrecisionMin) - 5.0);
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotPowerMax, decSBShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShotPowerMin) - 5.0);
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBShotTechniqueMax, decSBShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSBShotTechniqueMin) - 5.0);
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBFreeKickPrecisionMax, decSBFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBFreeKickPrecisionMin) - 5.0);
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBBendMax, decSBBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSBBendMin) - 5.0);
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBHeadingMax, decSBHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBHeadingMin) - 5.0);
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBTechniqueMax, decSBTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBTechniqueMin) - 5.0);
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBAggressivenessMax, decSBAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBAggressivenessMin) - 5.0);
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBMentalityMax, decSBMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSBMentalityMin) - 5.0);
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSBCooperationMax, decSBCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSBCooperationMin) - 5.0);
				}
			}
			if (cmbPosition.SelectedIndex == 2)
			{
				num3 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFBodyBalanceMax, decDMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBodyBalanceMin));
				num4 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFStaminaMax, decDMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFStaminaMin));
				num5 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFTopSpeedMax, decDMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTopSpeedMin));
				num6 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAccelerationMax, decDMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAccelerationMin));
				num7 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAgilityMax, decDMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAgilityMin));
				num8 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFJumpMax, decDMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFJumpMin));
				if (decimal.Compare(d, decDMFStarPlayer) >= 0)
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAttackMax, decDMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFAttackMin));
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDefenseMax, decDMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDefenseMin));
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFResponseMax, decDMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFResponseMin));
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDribblePrecisionMax, decDMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFDribblePrecisionMin));
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDribbleSpeedMax, decDMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDribbleSpeedMin));
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShortPassPrecisionMax, decDMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShortPassPrecisionMin));
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShortPassSpeedMax, decDMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShortPassSpeedMin));
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFLongPassPrecisionMax, decDMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFLongPassPrecisionMin));
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFLongPassSpeedMax, decDMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFLongPassSpeedMin));
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotPrecisionMax, decDMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShotPrecisionMin));
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotPowerMax, decDMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotPowerMin));
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotTechniqueMax, decDMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotTechniqueMin));
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFFreeKickPrecisionMax, decDMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFFreeKickPrecisionMin));
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFBendMax, decDMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBendMin));
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFHeadingMax, decDMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFHeadingMin));
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFTechniqueMax, decDMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTechniqueMin));
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAggressivenessMax, decDMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAggressivenessMin));
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFMentalityMax, decDMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFMentalityMin));
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFCooperationMax, decDMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFCooperationMin));
				}
				else
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAttackMax, decDMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFAttackMin) - 5.0);
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDefenseMax, decDMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDefenseMin) - 5.0);
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFResponseMax, decDMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFResponseMin) - 5.0);
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDribblePrecisionMax, decDMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFDribblePrecisionMin) - 5.0);
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFDribbleSpeedMax, decDMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDribbleSpeedMin) - 5.0);
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShortPassPrecisionMax, decDMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShortPassPrecisionMin) - 5.0);
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShortPassSpeedMax, decDMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShortPassSpeedMin) - 5.0);
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFLongPassPrecisionMax, decDMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFLongPassPrecisionMin) - 5.0);
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFLongPassSpeedMax, decDMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFLongPassSpeedMin) - 5.0);
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotPrecisionMax, decDMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShotPrecisionMin) - 5.0);
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotPowerMax, decDMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotPowerMin) - 5.0);
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFShotTechniqueMax, decDMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotTechniqueMin) - 5.0);
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFFreeKickPrecisionMax, decDMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFFreeKickPrecisionMin) - 5.0);
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFBendMax, decDMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBendMin) - 5.0);
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFHeadingMax, decDMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFHeadingMin) - 5.0);
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFTechniqueMax, decDMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTechniqueMin) - 5.0);
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFAggressivenessMax, decDMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAggressivenessMin) - 5.0);
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFMentalityMax, decDMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFMentalityMin) - 5.0);
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decDMFCooperationMax, decDMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFCooperationMin) - 5.0);
				}
			}
			if (cmbPosition.SelectedIndex == 3)
			{
				num3 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFBodyBalanceMax, decDMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBodyBalanceMin) + (Convert.ToDouble(decimal.Subtract(decSMFBodyBalanceMax, decSMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBodyBalanceMin)) + (Convert.ToDouble(decimal.Subtract(decOMFBodyBalanceMax, decOMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBodyBalanceMin))) / 3.0);
				num4 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFStaminaMax, decDMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFStaminaMin) + (Convert.ToDouble(decimal.Subtract(decSMFStaminaMax, decSMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFStaminaMin)) + (Convert.ToDouble(decimal.Subtract(decOMFStaminaMax, decOMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFStaminaMin))) / 3.0);
				num5 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFTopSpeedMax, decDMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTopSpeedMin) + (Convert.ToDouble(decimal.Subtract(decSMFTopSpeedMax, decSMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTopSpeedMin)) + (Convert.ToDouble(decimal.Subtract(decOMFTopSpeedMax, decOMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTopSpeedMin))) / 3.0);
				num6 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAccelerationMax, decDMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAccelerationMin) + (Convert.ToDouble(decimal.Subtract(decSMFAccelerationMax, decSMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAccelerationMin)) + (Convert.ToDouble(decimal.Subtract(decOMFAccelerationMax, decOMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAccelerationMin))) / 3.0);
				num7 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAgilityMax, decDMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAgilityMin) + (Convert.ToDouble(decimal.Subtract(decSMFAgilityMax, decSMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAgilityMin)) + (Convert.ToDouble(decimal.Subtract(decOMFAgilityMax, decOMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAgilityMin))) / 3.0);
				num8 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFJumpMax, decDMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFJumpMin) + (Convert.ToDouble(decimal.Subtract(decSMFJumpMax, decSMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFJumpMin)) + (Convert.ToDouble(decimal.Subtract(decOMFJumpMax, decOMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFJumpMin))) / 3.0);
				if (decimal.Compare(d, decimal.Divide(decimal.Add(decimal.Add(decDMFStarPlayer, decSMFStarPlayer), decOMFStarPlayer), 3m)) >= 0)
				{
					num9 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAttackMax, decDMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFAttackMin) + (Convert.ToDouble(decimal.Subtract(decSMFAttackMax, decSMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFAttackMin)) + (Convert.ToDouble(decimal.Subtract(decOMFAttackMax, decOMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFAttackMin))) / 3.0);
					num10 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDefenseMax, decDMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDefenseMin) + (Convert.ToDouble(decimal.Subtract(decSMFDefenseMax, decSMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDefenseMin)) + (Convert.ToDouble(decimal.Subtract(decOMFDefenseMax, decOMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDefenseMin))) / 3.0);
					num11 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFResponseMax, decDMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFResponseMin) + (Convert.ToDouble(decimal.Subtract(decSMFResponseMax, decSMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFResponseMin)) + (Convert.ToDouble(decimal.Subtract(decOMFResponseMax, decOMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFResponseMin))) / 3.0);
					num12 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDribblePrecisionMax, decDMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFDribblePrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFDribblePrecisionMax, decSMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFDribblePrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFDribblePrecisionMax, decOMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFDribblePrecisionMin))) / 3.0);
					num13 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDribbleSpeedMax, decDMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDribbleSpeedMin) + (Convert.ToDouble(decimal.Subtract(decSMFDribbleSpeedMax, decSMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDribbleSpeedMin)) + (Convert.ToDouble(decimal.Subtract(decOMFDribbleSpeedMax, decOMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDribbleSpeedMin))) / 3.0);
					num14 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShortPassPrecisionMax, decDMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShortPassPrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFShortPassPrecisionMax, decSMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShortPassPrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShortPassPrecisionMax, decOMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShortPassPrecisionMin))) / 3.0);
					num15 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShortPassSpeedMax, decDMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShortPassSpeedMin) + (Convert.ToDouble(decimal.Subtract(decSMFShortPassSpeedMax, decSMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShortPassSpeedMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShortPassSpeedMax, decOMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShortPassSpeedMin))) / 3.0);
					num16 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFLongPassPrecisionMax, decDMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFLongPassPrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFLongPassPrecisionMax, decSMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFLongPassPrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFLongPassPrecisionMax, decOMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFLongPassPrecisionMin))) / 3.0);
					num17 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFLongPassSpeedMax, decDMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFLongPassSpeedMin) + (Convert.ToDouble(decimal.Subtract(decSMFLongPassSpeedMax, decSMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFLongPassSpeedMin)) + (Convert.ToDouble(decimal.Subtract(decOMFLongPassSpeedMax, decOMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFLongPassSpeedMin))) / 3.0);
					num18 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotPrecisionMax, decDMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShotPrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFShotPrecisionMax, decSMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShotPrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShotPrecisionMax, decOMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShotPrecisionMin))) / 3.0);
					num19 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotPowerMax, decDMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotPowerMin) + (Convert.ToDouble(decimal.Subtract(decSMFShotPowerMax, decSMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotPowerMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShotPowerMax, decOMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotPowerMin))) / 3.0);
					num20 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotTechniqueMax, decDMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotTechniqueMin) + (Convert.ToDouble(decimal.Subtract(decSMFShotTechniqueMax, decSMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotTechniqueMin)) + (Convert.ToDouble(decimal.Subtract(decOMFShotTechniqueMax, decOMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotTechniqueMin))) / 3.0);
					num21 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFFreeKickPrecisionMax, decDMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFFreeKickPrecisionMin) + (Convert.ToDouble(decimal.Subtract(decSMFFreeKickPrecisionMax, decSMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFFreeKickPrecisionMin)) + (Convert.ToDouble(decimal.Subtract(decOMFFreeKickPrecisionMax, decOMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFFreeKickPrecisionMin))) / 3.0);
					num22 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFBendMax, decDMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBendMin) + (Convert.ToDouble(decimal.Subtract(decSMFBendMax, decSMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBendMin)) + (Convert.ToDouble(decimal.Subtract(decOMFBendMax, decOMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBendMin))) / 3.0);
					num23 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFHeadingMax, decDMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFHeadingMin) + (Convert.ToDouble(decimal.Subtract(decSMFHeadingMax, decSMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFHeadingMin)) + (Convert.ToDouble(decimal.Subtract(decOMFHeadingMax, decOMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFHeadingMin))) / 3.0);
					num24 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFTechniqueMax, decDMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTechniqueMin) + (Convert.ToDouble(decimal.Subtract(decSMFTechniqueMax, decSMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTechniqueMin)) + (Convert.ToDouble(decimal.Subtract(decOMFTechniqueMax, decOMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTechniqueMin))) / 3.0);
					num25 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAggressivenessMax, decDMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAggressivenessMin) + (Convert.ToDouble(decimal.Subtract(decSMFAggressivenessMax, decSMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAggressivenessMin)) + (Convert.ToDouble(decimal.Subtract(decOMFAggressivenessMax, decOMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAggressivenessMin))) / 3.0);
					num26 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFMentalityMax, decDMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFMentalityMin) + (Convert.ToDouble(decimal.Subtract(decSMFMentalityMax, decSMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFMentalityMin)) + (Convert.ToDouble(decimal.Subtract(decOMFMentalityMax, decOMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFMentalityMin))) / 3.0);
					num27 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFCooperationMax, decDMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFCooperationMin) + (Convert.ToDouble(decimal.Subtract(decSMFCooperationMax, decSMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFCooperationMin)) + (Convert.ToDouble(decimal.Subtract(decOMFCooperationMax, decOMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFCooperationMin))) / 3.0);
				}
				else
				{
					num9 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAttackMax, decDMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFAttackMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFAttackMax, decSMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFAttackMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFAttackMax, decOMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFAttackMin) - 5.0)) / 3.0);
					num10 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDefenseMax, decDMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDefenseMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFDefenseMax, decSMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDefenseMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFDefenseMax, decOMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDefenseMin) - 5.0)) / 3.0);
					num11 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFResponseMax, decDMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFResponseMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFResponseMax, decSMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFResponseMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFResponseMax, decOMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFResponseMin) - 5.0)) / 3.0);
					num12 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDribblePrecisionMax, decDMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFDribblePrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFDribblePrecisionMax, decSMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFDribblePrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFDribblePrecisionMax, decOMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFDribblePrecisionMin) - 5.0)) / 3.0);
					num13 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFDribbleSpeedMax, decDMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFDribbleSpeedMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFDribbleSpeedMax, decSMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDribbleSpeedMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFDribbleSpeedMax, decOMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDribbleSpeedMin) - 5.0)) / 3.0);
					num14 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShortPassPrecisionMax, decDMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShortPassPrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShortPassPrecisionMax, decSMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShortPassPrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShortPassPrecisionMax, decOMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShortPassPrecisionMin) - 5.0)) / 3.0);
					num15 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShortPassSpeedMax, decDMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShortPassSpeedMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShortPassSpeedMax, decSMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShortPassSpeedMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShortPassSpeedMax, decOMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShortPassSpeedMin) - 5.0)) / 3.0);
					num16 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFLongPassPrecisionMax, decDMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFLongPassPrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFLongPassPrecisionMax, decSMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFLongPassPrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFLongPassPrecisionMax, decOMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFLongPassPrecisionMin) - 5.0)) / 3.0);
					num17 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFLongPassSpeedMax, decDMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFLongPassSpeedMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFLongPassSpeedMax, decSMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFLongPassSpeedMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFLongPassSpeedMax, decOMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFLongPassSpeedMin) - 5.0)) / 3.0);
					num18 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotPrecisionMax, decDMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFShotPrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShotPrecisionMax, decSMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShotPrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShotPrecisionMax, decOMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShotPrecisionMin) - 5.0)) / 3.0);
					num19 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotPowerMax, decDMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotPowerMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShotPowerMax, decSMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotPowerMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShotPowerMax, decOMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotPowerMin) - 5.0)) / 3.0);
					num20 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFShotTechniqueMax, decDMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFShotTechniqueMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFShotTechniqueMax, decSMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotTechniqueMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFShotTechniqueMax, decOMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotTechniqueMin) - 5.0)) / 3.0);
					num21 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFFreeKickPrecisionMax, decDMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFFreeKickPrecisionMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFFreeKickPrecisionMax, decSMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFFreeKickPrecisionMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFFreeKickPrecisionMax, decOMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFFreeKickPrecisionMin) - 5.0)) / 3.0);
					num22 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFBendMax, decDMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFBendMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFBendMax, decSMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBendMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFBendMax, decOMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBendMin) - 5.0)) / 3.0);
					num23 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFHeadingMax, decDMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFHeadingMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFHeadingMax, decSMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFHeadingMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFHeadingMax, decOMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFHeadingMin) - 5.0)) / 3.0);
					num24 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFTechniqueMax, decDMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFTechniqueMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFTechniqueMax, decSMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTechniqueMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFTechniqueMax, decOMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTechniqueMin) - 5.0)) / 3.0);
					num25 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFAggressivenessMax, decDMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFAggressivenessMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFAggressivenessMax, decSMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAggressivenessMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFAggressivenessMax, decOMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAggressivenessMin) - 5.0)) / 3.0);
					num26 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFMentalityMax, decDMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decDMFMentalityMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFMentalityMax, decSMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFMentalityMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFMentalityMax, decOMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFMentalityMin) - 5.0)) / 3.0);
					num27 = (int)Math.Round((Convert.ToDouble(decimal.Subtract(decDMFCooperationMax, decDMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decDMFCooperationMin) - 5.0 + (Convert.ToDouble(decimal.Subtract(decSMFCooperationMax, decSMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFCooperationMin) - 5.0) + (Convert.ToDouble(decimal.Subtract(decOMFCooperationMax, decOMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFCooperationMin) - 5.0)) / 3.0);
				}
			}
			if (cmbPosition.SelectedIndex == 4)
			{
				num3 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFBodyBalanceMax, decSMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBodyBalanceMin));
				num4 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFStaminaMax, decSMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFStaminaMin));
				num5 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFTopSpeedMax, decSMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTopSpeedMin));
				num6 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAccelerationMax, decSMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAccelerationMin));
				num7 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAgilityMax, decSMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAgilityMin));
				num8 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFJumpMax, decSMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFJumpMin));
				if (decimal.Compare(d, decSMFStarPlayer) >= 0)
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAttackMax, decSMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFAttackMin));
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDefenseMax, decSMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDefenseMin));
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFResponseMax, decSMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFResponseMin));
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDribblePrecisionMax, decSMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFDribblePrecisionMin));
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDribbleSpeedMax, decSMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDribbleSpeedMin));
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShortPassPrecisionMax, decSMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShortPassPrecisionMin));
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShortPassSpeedMax, decSMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShortPassSpeedMin));
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFLongPassPrecisionMax, decSMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFLongPassPrecisionMin));
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFLongPassSpeedMax, decSMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFLongPassSpeedMin));
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotPrecisionMax, decSMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShotPrecisionMin));
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotPowerMax, decSMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotPowerMin));
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotTechniqueMax, decSMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotTechniqueMin));
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFFreeKickPrecisionMax, decSMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFFreeKickPrecisionMin));
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFBendMax, decSMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBendMin));
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFHeadingMax, decSMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFHeadingMin));
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFTechniqueMax, decSMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTechniqueMin));
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAggressivenessMax, decSMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAggressivenessMin));
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFMentalityMax, decSMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFMentalityMin));
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFCooperationMax, decSMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFCooperationMin));
				}
				else
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAttackMax, decSMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFAttackMin) - 5.0);
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDefenseMax, decSMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDefenseMin) - 5.0);
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFResponseMax, decSMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFResponseMin) - 5.0);
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDribblePrecisionMax, decSMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFDribblePrecisionMin) - 5.0);
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFDribbleSpeedMax, decSMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFDribbleSpeedMin) - 5.0);
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShortPassPrecisionMax, decSMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShortPassPrecisionMin) - 5.0);
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShortPassSpeedMax, decSMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShortPassSpeedMin) - 5.0);
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFLongPassPrecisionMax, decSMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFLongPassPrecisionMin) - 5.0);
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFLongPassSpeedMax, decSMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFLongPassSpeedMin) - 5.0);
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotPrecisionMax, decSMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFShotPrecisionMin) - 5.0);
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotPowerMax, decSMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotPowerMin) - 5.0);
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFShotTechniqueMax, decSMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFShotTechniqueMin) - 5.0);
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFFreeKickPrecisionMax, decSMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFFreeKickPrecisionMin) - 5.0);
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFBendMax, decSMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFBendMin) - 5.0);
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFHeadingMax, decSMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFHeadingMin) - 5.0);
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFTechniqueMax, decSMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFTechniqueMin) - 5.0);
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFAggressivenessMax, decSMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFAggressivenessMin) - 5.0);
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFMentalityMax, decSMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSMFMentalityMin) - 5.0);
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSMFCooperationMax, decSMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSMFCooperationMin) - 5.0);
				}
			}
			if (cmbPosition.SelectedIndex == 5)
			{
				num3 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFBodyBalanceMax, decOMFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBodyBalanceMin));
				num4 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFStaminaMax, decOMFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFStaminaMin));
				num5 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFTopSpeedMax, decOMFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTopSpeedMin));
				num6 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAccelerationMax, decOMFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAccelerationMin));
				num7 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAgilityMax, decOMFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAgilityMin));
				num8 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFJumpMax, decOMFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFJumpMin));
				if (decimal.Compare(d, decOMFStarPlayer) >= 0)
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAttackMax, decOMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFAttackMin));
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDefenseMax, decOMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDefenseMin));
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFResponseMax, decOMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFResponseMin));
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDribblePrecisionMax, decOMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFDribblePrecisionMin));
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDribbleSpeedMax, decOMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDribbleSpeedMin));
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShortPassPrecisionMax, decOMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShortPassPrecisionMin));
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShortPassSpeedMax, decOMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShortPassSpeedMin));
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFLongPassPrecisionMax, decOMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFLongPassPrecisionMin));
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFLongPassSpeedMax, decOMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFLongPassSpeedMin));
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotPrecisionMax, decOMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShotPrecisionMin));
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotPowerMax, decOMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotPowerMin));
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotTechniqueMax, decOMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotTechniqueMin));
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFFreeKickPrecisionMax, decOMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFFreeKickPrecisionMin));
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFBendMax, decOMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBendMin));
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFHeadingMax, decOMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFHeadingMin));
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFTechniqueMax, decOMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTechniqueMin));
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAggressivenessMax, decOMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAggressivenessMin));
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFMentalityMax, decOMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFMentalityMin));
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFCooperationMax, decOMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFCooperationMin));
				}
				else
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAttackMax, decOMFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFAttackMin) - 5.0);
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDefenseMax, decOMFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDefenseMin) - 5.0);
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFResponseMax, decOMFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFResponseMin) - 5.0);
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDribblePrecisionMax, decOMFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFDribblePrecisionMin) - 5.0);
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFDribbleSpeedMax, decOMFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFDribbleSpeedMin) - 5.0);
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShortPassPrecisionMax, decOMFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShortPassPrecisionMin) - 5.0);
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShortPassSpeedMax, decOMFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShortPassSpeedMin) - 5.0);
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFLongPassPrecisionMax, decOMFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFLongPassPrecisionMin) - 5.0);
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFLongPassSpeedMax, decOMFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFLongPassSpeedMin) - 5.0);
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotPrecisionMax, decOMFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFShotPrecisionMin) - 5.0);
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotPowerMax, decOMFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotPowerMin) - 5.0);
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFShotTechniqueMax, decOMFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFShotTechniqueMin) - 5.0);
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFFreeKickPrecisionMax, decOMFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFFreeKickPrecisionMin) - 5.0);
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFBendMax, decOMFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFBendMin) - 5.0);
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFHeadingMax, decOMFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFHeadingMin) - 5.0);
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFTechniqueMax, decOMFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFTechniqueMin) - 5.0);
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFAggressivenessMax, decOMFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFAggressivenessMin) - 5.0);
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFMentalityMax, decOMFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decOMFMentalityMin) - 5.0);
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decOMFCooperationMax, decOMFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decOMFCooperationMin) - 5.0);
				}
			}
			if (cmbPosition.SelectedIndex == 6)
			{
				num3 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFBodyBalanceMax, decWFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFBodyBalanceMin));
				num4 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFStaminaMax, decWFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFStaminaMin));
				num5 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFTopSpeedMax, decWFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFTopSpeedMin));
				num6 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAccelerationMax, decWFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFAccelerationMin));
				num7 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAgilityMax, decWFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFAgilityMin));
				num8 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFJumpMax, decWFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFJumpMin));
				if (decimal.Compare(d, decWFStarPlayer) >= 0)
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAttackMax, decWFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decWFAttackMin));
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDefenseMax, decWFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decWFDefenseMin));
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFResponseMax, decWFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFResponseMin));
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDribblePrecisionMax, decWFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFDribblePrecisionMin));
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDribbleSpeedMax, decWFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decWFDribbleSpeedMin));
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShortPassPrecisionMax, decWFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFShortPassPrecisionMin));
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShortPassSpeedMax, decWFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShortPassSpeedMin));
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFLongPassPrecisionMax, decWFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFLongPassPrecisionMin));
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFLongPassSpeedMax, decWFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFLongPassSpeedMin));
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotPrecisionMax, decWFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFShotPrecisionMin));
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotPowerMax, decWFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShotPowerMin));
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotTechniqueMax, decWFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShotTechniqueMin));
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFFreeKickPrecisionMax, decWFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFFreeKickPrecisionMin));
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFBendMax, decWFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFBendMin));
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFHeadingMax, decWFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFHeadingMin));
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFTechniqueMax, decWFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFTechniqueMin));
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAggressivenessMax, decWFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFAggressivenessMin));
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFMentalityMax, decWFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decWFMentalityMin));
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFCooperationMax, decWFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFCooperationMin));
				}
				else
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAttackMax, decWFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decWFAttackMin) - 5.0);
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDefenseMax, decWFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decWFDefenseMin) - 5.0);
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFResponseMax, decWFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFResponseMin) - 5.0);
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDribblePrecisionMax, decWFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFDribblePrecisionMin) - 5.0);
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFDribbleSpeedMax, decWFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decWFDribbleSpeedMin) - 5.0);
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShortPassPrecisionMax, decWFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFShortPassPrecisionMin) - 5.0);
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShortPassSpeedMax, decWFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShortPassSpeedMin) - 5.0);
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFLongPassPrecisionMax, decWFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFLongPassPrecisionMin) - 5.0);
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFLongPassSpeedMax, decWFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFLongPassSpeedMin) - 5.0);
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotPrecisionMax, decWFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFShotPrecisionMin) - 5.0);
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotPowerMax, decWFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShotPowerMin) - 5.0);
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFShotTechniqueMax, decWFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decWFShotTechniqueMin) - 5.0);
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFFreeKickPrecisionMax, decWFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFFreeKickPrecisionMin) - 5.0);
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFBendMax, decWFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decWFBendMin) - 5.0);
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFHeadingMax, decWFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFHeadingMin) - 5.0);
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFTechniqueMax, decWFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFTechniqueMin) - 5.0);
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFAggressivenessMax, decWFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFAggressivenessMin) - 5.0);
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFMentalityMax, decWFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decWFMentalityMin) - 5.0);
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decWFCooperationMax, decWFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decWFCooperationMin) - 5.0);
				}
			}
			if (cmbPosition.SelectedIndex == 7)
			{
				num3 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFBodyBalanceMax, decSTCFBodyBalanceMin)) * ((double)(cmbBalance.SelectedIndex + cmbStrength.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFBodyBalanceMin));
				num4 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFStaminaMax, decSTCFStaminaMin)) * ((double)((cmbStamina.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFStaminaMin));
				num5 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFTopSpeedMax, decSTCFTopSpeedMin)) * ((double)((cmbPace.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFTopSpeedMin));
				num6 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAccelerationMax, decSTCFAccelerationMin)) * ((double)((cmbAcceleration.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFAccelerationMin));
				num7 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAgilityMax, decSTCFAgilityMin)) * ((double)((cmbAgility.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFAgilityMin));
				num8 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFJumpMax, decSTCFJumpMin)) * ((double)((cmbJumping.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFJumpMin));
				if (decimal.Compare(d, decSTCFStarPlayer) >= 0)
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAttackMax, decSTCFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFAttackMin));
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDefenseMax, decSTCFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFDefenseMin));
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFResponseMax, decSTCFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFResponseMin));
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDribblePrecisionMax, decSTCFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFDribblePrecisionMin));
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDribbleSpeedMax, decSTCFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFDribbleSpeedMin));
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShortPassPrecisionMax, decSTCFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFShortPassPrecisionMin));
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShortPassSpeedMax, decSTCFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShortPassSpeedMin));
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFLongPassPrecisionMax, decSTCFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFLongPassPrecisionMin));
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFLongPassSpeedMax, decSTCFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFLongPassSpeedMin));
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotPrecisionMax, decSTCFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFShotPrecisionMin));
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotPowerMax, decSTCFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShotPowerMin));
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotTechniqueMax, decSTCFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShotTechniqueMin));
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFFreeKickPrecisionMax, decSTCFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFFreeKickPrecisionMin));
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFBendMax, decSTCFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFBendMin));
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFHeadingMax, decSTCFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFHeadingMin));
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFTechniqueMax, decSTCFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFTechniqueMin));
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAggressivenessMax, decSTCFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFAggressivenessMin));
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFMentalityMax, decSTCFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFMentalityMin));
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFCooperationMax, decSTCFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFCooperationMin));
				}
				else
				{
					num9 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAttackMax, decSTCFAttackMin)) * ((double)(cmbCreativity.SelectedIndex + cmbCrossing.SelectedIndex + cmbDribbling.SelectedIndex + cmbFreeKicks.SelectedIndex + cmbFinishing.SelectedIndex + cmbFirstTouch.SelectedIndex + cmbFlair.SelectedIndex + cmbLongShots.SelectedIndex + cmbOffTheBall.SelectedIndex + cmbPassing.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFAttackMin) - 5.0);
					num10 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDefenseMax, decSTCFDefenseMin)) * ((double)(cmbAcceleration.SelectedIndex + cmbAnticipation.SelectedIndex + cmbHeading.SelectedIndex + cmbJumping.SelectedIndex + cmbMarking.SelectedIndex + cmbPace.SelectedIndex + cmbPositioning.SelectedIndex + cmbStamina.SelectedIndex + cmbStrength.SelectedIndex + cmbTackling.SelectedIndex + 10) / 10.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFDefenseMin) - 5.0);
					num11 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFResponseMax, decSTCFResponseMin)) * ((double)(cmbAnticipation.SelectedIndex + cmbDecisions.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFResponseMin) - 5.0);
					num12 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDribblePrecisionMax, decSTCFDribblePrecisionMin)) * ((double)((cmbDribbling.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFDribblePrecisionMin) - 5.0);
					num13 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFDribbleSpeedMax, decSTCFDribbleSpeedMin)) * ((double)(cmbDribbling.SelectedIndex + cmbAcceleration.SelectedIndex + cmbPace.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFDribbleSpeedMin) - 5.0);
					num14 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShortPassPrecisionMax, decSTCFShortPassPrecisionMin)) * ((double)((cmbPassing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFShortPassPrecisionMin) - 5.0);
					num15 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShortPassSpeedMax, decSTCFShortPassSpeedMin)) * ((double)(cmbPassing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShortPassSpeedMin) - 5.0);
					num16 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFLongPassPrecisionMax, decSTCFLongPassPrecisionMin)) * ((double)((cmbCrossing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFLongPassPrecisionMin) - 5.0);
					num17 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFLongPassSpeedMax, decSTCFLongPassSpeedMin)) * ((double)(cmbCrossing.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFLongPassSpeedMin) - 5.0);
					num18 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotPrecisionMax, decSTCFShotPrecisionMin)) * ((double)((cmbFinishing.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFShotPrecisionMin) - 5.0);
					num19 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotPowerMax, decSTCFShotPowerMin)) * ((double)(cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShotPowerMin) - 5.0);
					num20 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFShotTechniqueMax, decSTCFShotTechniqueMin)) * ((double)(cmbFinishing.SelectedIndex + cmbLongShots.SelectedIndex + cmbTechnique.SelectedIndex + 3) / 3.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFShotTechniqueMin) - 5.0);
					num21 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFFreeKickPrecisionMax, decSTCFFreeKickPrecisionMin)) * ((double)((cmbFreeKicks.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFFreeKickPrecisionMin) - 5.0);
					num22 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFBendMax, decSTCFBendMin)) * ((double)(cmbCorners.SelectedIndex + cmbCrossing.SelectedIndex + 2) / 2.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFBendMin) - 5.0);
					num23 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFHeadingMax, decSTCFHeadingMin)) * ((double)((cmbHeading.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFHeadingMin) - 5.0);
					num24 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFTechniqueMax, decSTCFTechniqueMin)) * ((double)((cmbTechnique.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFTechniqueMin) - 5.0);
					num25 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFAggressivenessMax, decSTCFAggressivenessMin)) * ((double)((cmbAggression.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFAggressivenessMin) - 5.0);
					num26 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFMentalityMax, decSTCFMentalityMin)) * ((double)(cmbAggression.SelectedIndex + cmbAnticipation.SelectedIndex + cmbBravery.SelectedIndex + cmbComposure.SelectedIndex + cmbConcentration.SelectedIndex + cmbDecisions.SelectedIndex + cmbDetermination.SelectedIndex + cmbInfluence.SelectedIndex + cmbTeamwork.SelectedIndex + 9) / 9.0 * 5.0 / 100.0) + Convert.ToDouble(decSTCFMentalityMin) - 5.0);
					num27 = (int)Math.Round(Convert.ToDouble(decimal.Subtract(decSTCFCooperationMax, decSTCFCooperationMin)) * ((double)((cmbTeamwork.SelectedIndex + 1) * 5) / 100.0) + Convert.ToDouble(decSTCFCooperationMin) - 5.0);
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
			if (num9 >= 95)
			{
				frmWEPES.lblAttack.ForeColor = Color.Red;
			}
			else if (num9 >= 90)
			{
				frmWEPES.lblAttack.ForeColor = Color.Orange;
			}
			else if (num9 >= 80)
			{
				frmWEPES.lblAttack.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblAttack.ForeColor = Color.Empty;
			}
			frmWEPES.lblAttack.Text = StringType.FromInteger(num9);
			if (num10 >= 95)
			{
				frmWEPES.lblDefense.ForeColor = Color.Red;
			}
			else if (num10 >= 90)
			{
				frmWEPES.lblDefense.ForeColor = Color.Orange;
			}
			else if (num10 >= 80)
			{
				frmWEPES.lblDefense.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblDefense.ForeColor = Color.Empty;
			}
			frmWEPES.lblDefense.Text = StringType.FromInteger(num10);
			if (num3 >= 95)
			{
				frmWEPES.lblBodyBalance.ForeColor = Color.Red;
			}
			else if (num3 >= 90)
			{
				frmWEPES.lblBodyBalance.ForeColor = Color.Orange;
			}
			else if (num3 >= 80)
			{
				frmWEPES.lblBodyBalance.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblBodyBalance.ForeColor = Color.Empty;
			}
			frmWEPES.lblBodyBalance.Text = StringType.FromInteger(num3);
			if (num4 >= 95)
			{
				frmWEPES.lblStamina.ForeColor = Color.Red;
			}
			else if (num4 >= 90)
			{
				frmWEPES.lblStamina.ForeColor = Color.Orange;
			}
			else if (num4 >= 80)
			{
				frmWEPES.lblStamina.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblStamina.ForeColor = Color.Empty;
			}
			frmWEPES.lblStamina.Text = StringType.FromInteger(num4);
			if (num5 >= 95)
			{
				frmWEPES.lblTopSpeed.ForeColor = Color.Red;
			}
			else if (num5 >= 90)
			{
				frmWEPES.lblTopSpeed.ForeColor = Color.Orange;
			}
			else if (num5 >= 80)
			{
				frmWEPES.lblTopSpeed.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblTopSpeed.ForeColor = Color.Empty;
			}
			frmWEPES.lblTopSpeed.Text = StringType.FromInteger(num5);
			if (num6 >= 95)
			{
				frmWEPES.lblAcceleration.ForeColor = Color.Red;
			}
			else if (num6 >= 90)
			{
				frmWEPES.lblAcceleration.ForeColor = Color.Orange;
			}
			else if (num6 >= 80)
			{
				frmWEPES.lblAcceleration.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblAcceleration.ForeColor = Color.Empty;
			}
			frmWEPES.lblAcceleration.Text = StringType.FromInteger(num6);
			if (num11 >= 95)
			{
				frmWEPES.lblResponse.ForeColor = Color.Red;
			}
			else if (num11 >= 90)
			{
				frmWEPES.lblResponse.ForeColor = Color.Orange;
			}
			else if (num11 >= 80)
			{
				frmWEPES.lblResponse.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblResponse.ForeColor = Color.Empty;
			}
			frmWEPES.lblResponse.Text = StringType.FromInteger(num11);
			if (num7 >= 95)
			{
				frmWEPES.lblAgility.ForeColor = Color.Red;
			}
			else if (num7 >= 90)
			{
				frmWEPES.lblAgility.ForeColor = Color.Orange;
			}
			else if (num7 >= 80)
			{
				frmWEPES.lblAgility.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblAgility.ForeColor = Color.Empty;
			}
			frmWEPES.lblAgility.Text = StringType.FromInteger(num7);
			if (num12 >= 95)
			{
				frmWEPES.lblDribblePrecision.ForeColor = Color.Red;
			}
			else if (num12 >= 90)
			{
				frmWEPES.lblDribblePrecision.ForeColor = Color.Orange;
			}
			else if (num12 >= 80)
			{
				frmWEPES.lblDribblePrecision.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblDribblePrecision.ForeColor = Color.Empty;
			}
			frmWEPES.lblDribblePrecision.Text = StringType.FromInteger(num12);
			if (num13 >= 95)
			{
				frmWEPES.lblDribbleSpeed.ForeColor = Color.Red;
			}
			else if (num13 >= 90)
			{
				frmWEPES.lblDribbleSpeed.ForeColor = Color.Orange;
			}
			else if (num13 >= 80)
			{
				frmWEPES.lblDribbleSpeed.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblDribbleSpeed.ForeColor = Color.Empty;
			}
			frmWEPES.lblDribbleSpeed.Text = StringType.FromInteger(num13);
			if (num14 >= 95)
			{
				frmWEPES.lblShortPassPrecision.ForeColor = Color.Red;
			}
			else if (num14 >= 90)
			{
				frmWEPES.lblShortPassPrecision.ForeColor = Color.Orange;
			}
			else if (num14 >= 80)
			{
				frmWEPES.lblShortPassPrecision.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblShortPassPrecision.ForeColor = Color.Empty;
			}
			frmWEPES.lblShortPassPrecision.Text = StringType.FromInteger(num14);
			if (num15 >= 95)
			{
				frmWEPES.lblShortPassSpeed.ForeColor = Color.Red;
			}
			else if (num15 >= 90)
			{
				frmWEPES.lblShortPassSpeed.ForeColor = Color.Orange;
			}
			else if (num15 >= 80)
			{
				frmWEPES.lblShortPassSpeed.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblShortPassSpeed.ForeColor = Color.Empty;
			}
			frmWEPES.lblShortPassSpeed.Text = StringType.FromInteger(num15);
			if (num16 >= 95)
			{
				frmWEPES.lblLongPassPrecision.ForeColor = Color.Red;
			}
			else if (num16 >= 90)
			{
				frmWEPES.lblLongPassPrecision.ForeColor = Color.Orange;
			}
			else if (num16 >= 80)
			{
				frmWEPES.lblLongPassPrecision.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblLongPassPrecision.ForeColor = Color.Empty;
			}
			frmWEPES.lblLongPassPrecision.Text = StringType.FromInteger(num16);
			if (num17 >= 95)
			{
				frmWEPES.lblLongPassSpeed.ForeColor = Color.Red;
			}
			else if (num17 >= 90)
			{
				frmWEPES.lblLongPassSpeed.ForeColor = Color.Orange;
			}
			else if (num17 >= 80)
			{
				frmWEPES.lblLongPassSpeed.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblLongPassSpeed.ForeColor = Color.Empty;
			}
			frmWEPES.lblLongPassSpeed.Text = StringType.FromInteger(num17);
			if (num18 >= 95)
			{
				frmWEPES.lblShotPrecision.ForeColor = Color.Red;
			}
			else if (num18 >= 90)
			{
				frmWEPES.lblShotPrecision.ForeColor = Color.Orange;
			}
			else if (num18 >= 80)
			{
				frmWEPES.lblShotPrecision.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblShotPrecision.ForeColor = Color.Empty;
			}
			frmWEPES.lblShotPrecision.Text = StringType.FromInteger(num18);
			if (num19 >= 95)
			{
				frmWEPES.lblShotPower.ForeColor = Color.Red;
			}
			else if (num19 >= 90)
			{
				frmWEPES.lblShotPower.ForeColor = Color.Orange;
			}
			else if (num19 >= 80)
			{
				frmWEPES.lblShotPower.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblShotPower.ForeColor = Color.Empty;
			}
			frmWEPES.lblShotPower.Text = StringType.FromInteger(num19);
			if (num20 >= 95)
			{
				frmWEPES.lblShotTechnique.ForeColor = Color.Red;
			}
			else if (num20 >= 90)
			{
				frmWEPES.lblShotTechnique.ForeColor = Color.Orange;
			}
			else if (num20 >= 80)
			{
				frmWEPES.lblShotTechnique.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblShotTechnique.ForeColor = Color.Empty;
			}
			frmWEPES.lblShotTechnique.Text = StringType.FromInteger(num20);
			if (num21 >= 95)
			{
				frmWEPES.lblFreeKickPrecision.ForeColor = Color.Red;
			}
			else if (num21 >= 90)
			{
				frmWEPES.lblFreeKickPrecision.ForeColor = Color.Orange;
			}
			else if (num21 >= 80)
			{
				frmWEPES.lblFreeKickPrecision.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblFreeKickPrecision.ForeColor = Color.Empty;
			}
			frmWEPES.lblFreeKickPrecision.Text = StringType.FromInteger(num21);
			if (num22 >= 95)
			{
				frmWEPES.lblBend.ForeColor = Color.Red;
			}
			else if (num22 >= 90)
			{
				frmWEPES.lblBend.ForeColor = Color.Orange;
			}
			else if (num22 >= 80)
			{
				frmWEPES.lblBend.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblBend.ForeColor = Color.Empty;
			}
			frmWEPES.lblBend.Text = StringType.FromInteger(num22);
			if (num23 >= 95)
			{
				frmWEPES.lblHeading.ForeColor = Color.Red;
			}
			else if (num23 >= 90)
			{
				frmWEPES.lblHeading.ForeColor = Color.Orange;
			}
			else if (num23 >= 80)
			{
				frmWEPES.lblHeading.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblHeading.ForeColor = Color.Empty;
			}
			frmWEPES.lblHeading.Text = StringType.FromInteger(num23);
			if (num8 >= 95)
			{
				frmWEPES.lblJump.ForeColor = Color.Red;
			}
			else if (num8 >= 90)
			{
				frmWEPES.lblJump.ForeColor = Color.Orange;
			}
			else if (num8 >= 80)
			{
				frmWEPES.lblJump.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblJump.ForeColor = Color.Empty;
			}
			frmWEPES.lblJump.Text = StringType.FromInteger(num8);
			if (num24 >= 95)
			{
				frmWEPES.lblTechnique.ForeColor = Color.Red;
			}
			else if (num24 >= 90)
			{
				frmWEPES.lblTechnique.ForeColor = Color.Orange;
			}
			else if (num24 >= 80)
			{
				frmWEPES.lblTechnique.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblTechnique.ForeColor = Color.Empty;
			}
			frmWEPES.lblTechnique.Text = StringType.FromInteger(num24);
			if (num25 >= 95)
			{
				frmWEPES.lblAggressiveness.ForeColor = Color.Red;
			}
			else if (num25 >= 90)
			{
				frmWEPES.lblAggressiveness.ForeColor = Color.Orange;
			}
			else if (num25 >= 80)
			{
				frmWEPES.lblAggressiveness.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblAggressiveness.ForeColor = Color.Empty;
			}
			frmWEPES.lblAggressiveness.Text = StringType.FromInteger(num25);
			if (num26 >= 95)
			{
				frmWEPES.lblMentality.ForeColor = Color.Red;
			}
			else if (num26 >= 90)
			{
				frmWEPES.lblMentality.ForeColor = Color.Orange;
			}
			else if (num26 >= 80)
			{
				frmWEPES.lblMentality.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblMentality.ForeColor = Color.Empty;
			}
			frmWEPES.lblMentality.Text = StringType.FromInteger(num26);
			if (num27 >= 95)
			{
				frmWEPES.lblCooperation.ForeColor = Color.Red;
			}
			else if (num27 >= 90)
			{
				frmWEPES.lblCooperation.ForeColor = Color.Orange;
			}
			else if (num27 >= 80)
			{
				frmWEPES.lblCooperation.ForeColor = Color.Yellow;
			}
			else
			{
				frmWEPES.lblCooperation.ForeColor = Color.Empty;
			}
			frmWEPES.lblCooperation.Text = StringType.FromInteger(num27);
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
		ProjectData.EndApp();
	}
}
