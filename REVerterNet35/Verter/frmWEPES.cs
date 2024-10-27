using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Verter;

public class frmWEPES : Form
{
	[AccessedThroughProperty("lblLongPassPrecision2")]
	private Label _lblLongPassPrecision2;

	[AccessedThroughProperty("lblShortPassSpeed2")]
	private Label _lblShortPassSpeed2;

	[AccessedThroughProperty("lblDefense2")]
	private Label _lblDefense2;

	[AccessedThroughProperty("lblTechnique2")]
	private Label _lblTechnique2;

	[AccessedThroughProperty("lblJump2")]
	private Label _lblJump2;

	[AccessedThroughProperty("lblAttack")]
	private Label _lblAttack;

	[AccessedThroughProperty("lblShotTechnique2")]
	private Label _lblShotTechnique2;

	[AccessedThroughProperty("lblShotPower2")]
	private Label _lblShotPower2;

	[AccessedThroughProperty("lblLongPassSpeed2")]
	private Label _lblLongPassSpeed2;

	[AccessedThroughProperty("lblStamina2")]
	private Label _lblStamina2;

	[AccessedThroughProperty("lblTopSpeed2")]
	private Label _lblTopSpeed2;

	[AccessedThroughProperty("lblAcceleration2")]
	private Label _lblAcceleration2;

	[AccessedThroughProperty("lblBodyBalance2")]
	private Label _lblBodyBalance2;

	[AccessedThroughProperty("lblResponse2")]
	private Label _lblResponse2;

	[AccessedThroughProperty("lblAgility2")]
	private Label _lblAgility2;

	[AccessedThroughProperty("lblDribbleSpeed2")]
	private Label _lblDribbleSpeed2;

	[AccessedThroughProperty("lblAttack2")]
	private Label _lblAttack2;

	[AccessedThroughProperty("lblPreferredFoot")]
	private Label _lblPreferredFoot;

	[AccessedThroughProperty("lblPosition")]
	private Label _lblPosition;

	[AccessedThroughProperty("lblAcceleration")]
	private Label _lblAcceleration;

	[AccessedThroughProperty("lblPreferredFoot2")]
	private Label _lblPreferredFoot2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("lblPosition2")]
	private Label _lblPosition2;

	[AccessedThroughProperty("grpAbilities")]
	private GroupBox _grpAbilities;

	[AccessedThroughProperty("grpSpecialAbilities")]
	private GroupBox _grpSpecialAbilities;

	[AccessedThroughProperty("lblDribblePrecision2")]
	private Label _lblDribblePrecision2;

	[AccessedThroughProperty("lblMiddleShot2")]
	private Label _lblMiddleShot2;

	[AccessedThroughProperty("lblMiddleShot")]
	private Label _lblMiddleShot;

	[AccessedThroughProperty("lblDribbler2")]
	private Label _lblDribbler2;

	[AccessedThroughProperty("lblPKKicker2")]
	private Label _lblPKKicker2;

	[AccessedThroughProperty("lblCovering2")]
	private Label _lblCovering2;

	[AccessedThroughProperty("lblPasser2")]
	private Label _lblPasser2;

	[AccessedThroughProperty("lblCommander2")]
	private Label _lblCommander2;

	[AccessedThroughProperty("lblTopSpeed")]
	private Label _lblTopSpeed;

	[AccessedThroughProperty("lblStriker2")]
	private Label _lblStriker2;

	[AccessedThroughProperty("lblDashIn2")]
	private Label _lblDashIn2;

	[AccessedThroughProperty("lblHoldingUpTheBall2")]
	private Label _lblHoldingUpTheBall2;

	[AccessedThroughProperty("lblKeepDribble2")]
	private Label _lblKeepDribble2;

	[AccessedThroughProperty("lblShortPassPrecision2")]
	private Label _lblShortPassPrecision2;

	[AccessedThroughProperty("lblShoot1On12")]
	private Label _lblShoot1On12;

	[AccessedThroughProperty("lblSliding2")]
	private Label _lblSliding2;

	[AccessedThroughProperty("lblBackLineControl2")]
	private Label _lblBackLineControl2;

	[AccessedThroughProperty("lblManMarking2")]
	private Label _lblManMarking2;

	[AccessedThroughProperty("lblStamina")]
	private Label _lblStamina;

	[AccessedThroughProperty("lblCentrePlayer2")]
	private Label _lblCentrePlayer2;

	[AccessedThroughProperty("lblSidePlayer2")]
	private Label _lblSidePlayer2;

	[AccessedThroughProperty("lblDirectPlay2")]
	private Label _lblDirectPlay2;

	[AccessedThroughProperty("lblDribbler")]
	private Label _lblDribbler;

	[AccessedThroughProperty("lblKeepDribble")]
	private Label _lblKeepDribble;

	[AccessedThroughProperty("lblHoldingUpTheBall")]
	private Label _lblHoldingUpTheBall;

	[AccessedThroughProperty("lblDashIn")]
	private Label _lblDashIn;

	[AccessedThroughProperty("lblCooperation")]
	private Label _lblCooperation;

	[AccessedThroughProperty("lblStriker")]
	private Label _lblStriker;

	[AccessedThroughProperty("lblCommander")]
	private Label _lblCommander;

	[AccessedThroughProperty("lblPasser")]
	private Label _lblPasser;

	[AccessedThroughProperty("lblCovering")]
	private Label _lblCovering;

	[AccessedThroughProperty("lblPKKicker")]
	private Label _lblPKKicker;

	[AccessedThroughProperty("lblShortPassSpeed")]
	private Label _lblShortPassSpeed;

	[AccessedThroughProperty("lblShoot1On1")]
	private Label _lblShoot1On1;

	[AccessedThroughProperty("lblDirectPlay")]
	private Label _lblDirectPlay;

	[AccessedThroughProperty("lblSidePlayer")]
	private Label _lblSidePlayer;

	[AccessedThroughProperty("lblCentrePlayer")]
	private Label _lblCentrePlayer;

	[AccessedThroughProperty("lblManMarking")]
	private Label _lblManMarking;

	[AccessedThroughProperty("lblBackLineControl")]
	private Label _lblBackLineControl;

	[AccessedThroughProperty("lblCooperation2")]
	private Label _lblCooperation2;

	[AccessedThroughProperty("lblSliding")]
	private Label _lblSliding;

	[AccessedThroughProperty("lblSecondFootFrequency2")]
	private Label _lblSecondFootFrequency2;

	[AccessedThroughProperty("lblSecondFootFrequency")]
	private Label _lblSecondFootFrequency;

	[AccessedThroughProperty("lblStabilityOfPlay")]
	private Label _lblStabilityOfPlay;

	[AccessedThroughProperty("lblGoalKeeperSkill")]
	private Label _lblGoalKeeperSkill;

	[AccessedThroughProperty("lblStabilityOfCondition")]
	private Label _lblStabilityOfCondition;

	[AccessedThroughProperty("lblDribbleSpeed")]
	private Label _lblDribbleSpeed;

	[AccessedThroughProperty("lblSecondFootAccuracy")]
	private Label _lblSecondFootAccuracy;

	[AccessedThroughProperty("lblLongPassPrecision")]
	private Label _lblLongPassPrecision;

	[AccessedThroughProperty("lblShotPrecision")]
	private Label _lblShotPrecision;

	[AccessedThroughProperty("lblFreeKickPrecision")]
	private Label _lblFreeKickPrecision;

	[AccessedThroughProperty("lblBend")]
	private Label _lblBend;

	[AccessedThroughProperty("btnClose")]
	private Button _btnClose;

	[AccessedThroughProperty("lblHeading")]
	private Label _lblHeading;

	[AccessedThroughProperty("lblAggressiveness")]
	private Label _lblAggressiveness;

	[AccessedThroughProperty("lblDribblePrecision")]
	private Label _lblDribblePrecision;

	[AccessedThroughProperty("lblShortPassPrecision")]
	private Label _lblShortPassPrecision;

	[AccessedThroughProperty("lblBodyBalance")]
	private Label _lblBodyBalance;

	[AccessedThroughProperty("lblDefense")]
	private Label _lblDefense;

	[AccessedThroughProperty("lblSecondFootAccuracy2")]
	private Label _lblSecondFootAccuracy2;

	[AccessedThroughProperty("lblAgility")]
	private Label _lblAgility;

	[AccessedThroughProperty("lblStabilityOfCondition2")]
	private Label _lblStabilityOfCondition2;

	[AccessedThroughProperty("lblGoalKeeperSkill2")]
	private Label _lblGoalKeeperSkill2;

	[AccessedThroughProperty("lblStabilityOfPlay2")]
	private Label _lblStabilityOfPlay2;

	[AccessedThroughProperty("lblAggressiveness2")]
	private Label _lblAggressiveness2;

	[AccessedThroughProperty("lblLinePositioning2")]
	private Label _lblLinePositioning2;

	[AccessedThroughProperty("lblHeading2")]
	private Label _lblHeading2;

	[AccessedThroughProperty("lblBend2")]
	private Label _lblBend2;

	[AccessedThroughProperty("lblFreeKickPrecision2")]
	private Label _lblFreeKickPrecision2;

	[AccessedThroughProperty("lblShotPrecision2")]
	private Label _lblShotPrecision2;

	[AccessedThroughProperty("lblResponse")]
	private Label _lblResponse;

	[AccessedThroughProperty("lblMentality")]
	private Label _lblMentality;

	[AccessedThroughProperty("lblTechnique")]
	private Label _lblTechnique;

	[AccessedThroughProperty("lblJump")]
	private Label _lblJump;

	[AccessedThroughProperty("lblShotTechnique")]
	private Label _lblShotTechnique;

	[AccessedThroughProperty("lblShotPower")]
	private Label _lblShotPower;

	[AccessedThroughProperty("lblLongPassSpeed")]
	private Label _lblLongPassSpeed;

	[AccessedThroughProperty("lblMentality2")]
	private Label _lblMentality2;

	[AccessedThroughProperty("lblPositioning2")]
	private Label _lblPositioning2;

	[AccessedThroughProperty("lblOutside")]
	private Label _lblOutside;

	[AccessedThroughProperty("lblLongThrow")]
	private Label _lblLongThrow;

	[AccessedThroughProperty("lblLinePositioning")]
	private Label _lblLinePositioning;

	[AccessedThroughProperty("lblPositioning")]
	private Label _lblPositioning;

	[AccessedThroughProperty("lblLongThrow2")]
	private Label _lblLongThrow2;

	[AccessedThroughProperty("lblOutside2")]
	private Label _lblOutside2;

	private IContainer components;

	internal virtual Label lblAttack2
	{
		get
		{
			return _lblAttack2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAttack2 != null)
			{
			}
			_lblAttack2 = value;
			if (_lblAttack2 == null)
			{
			}
		}
	}

	internal virtual Label lblDribbleSpeed2
	{
		get
		{
			return _lblDribbleSpeed2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDribbleSpeed2 != null)
			{
			}
			_lblDribbleSpeed2 = value;
			if (_lblDribbleSpeed2 == null)
			{
			}
		}
	}

	internal virtual Label lblAgility2
	{
		get
		{
			return _lblAgility2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAgility2 != null)
			{
			}
			_lblAgility2 = value;
			if (_lblAgility2 == null)
			{
			}
		}
	}

	internal virtual Label lblResponse2
	{
		get
		{
			return _lblResponse2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblResponse2 != null)
			{
			}
			_lblResponse2 = value;
			if (_lblResponse2 == null)
			{
			}
		}
	}

	internal virtual Label lblAcceleration2
	{
		get
		{
			return _lblAcceleration2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAcceleration2 != null)
			{
			}
			_lblAcceleration2 = value;
			if (_lblAcceleration2 == null)
			{
			}
		}
	}

	internal virtual Label lblTopSpeed2
	{
		get
		{
			return _lblTopSpeed2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblTopSpeed2 != null)
			{
			}
			_lblTopSpeed2 = value;
			if (_lblTopSpeed2 == null)
			{
			}
		}
	}

	internal virtual Label lblStamina2
	{
		get
		{
			return _lblStamina2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStamina2 != null)
			{
			}
			_lblStamina2 = value;
			if (_lblStamina2 == null)
			{
			}
		}
	}

	internal virtual Label lblLongPassSpeed2
	{
		get
		{
			return _lblLongPassSpeed2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLongPassSpeed2 != null)
			{
			}
			_lblLongPassSpeed2 = value;
			if (_lblLongPassSpeed2 == null)
			{
			}
		}
	}

	internal virtual Label lblShotPower2
	{
		get
		{
			return _lblShotPower2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShotPower2 != null)
			{
			}
			_lblShotPower2 = value;
			if (_lblShotPower2 == null)
			{
			}
		}
	}

	internal virtual Label lblShotTechnique2
	{
		get
		{
			return _lblShotTechnique2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShotTechnique2 != null)
			{
			}
			_lblShotTechnique2 = value;
			if (_lblShotTechnique2 == null)
			{
			}
		}
	}

	internal virtual Label lblJump2
	{
		get
		{
			return _lblJump2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblJump2 != null)
			{
			}
			_lblJump2 = value;
			if (_lblJump2 == null)
			{
			}
		}
	}

	internal virtual Label lblTechnique2
	{
		get
		{
			return _lblTechnique2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblTechnique2 != null)
			{
			}
			_lblTechnique2 = value;
			if (_lblTechnique2 == null)
			{
			}
		}
	}

	internal virtual Label lblShortPassSpeed2
	{
		get
		{
			return _lblShortPassSpeed2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShortPassSpeed2 != null)
			{
			}
			_lblShortPassSpeed2 = value;
			if (_lblShortPassSpeed2 == null)
			{
			}
		}
	}

	internal virtual Label lblMentality2
	{
		get
		{
			return _lblMentality2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblMentality2 != null)
			{
			}
			_lblMentality2 = value;
			if (_lblMentality2 == null)
			{
			}
		}
	}

	internal virtual Label lblAttack
	{
		get
		{
			return _lblAttack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAttack != null)
			{
			}
			_lblAttack = value;
			if (_lblAttack == null)
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

	internal virtual Label lblTopSpeed
	{
		get
		{
			return _lblTopSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblTopSpeed != null)
			{
			}
			_lblTopSpeed = value;
			if (_lblTopSpeed == null)
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

	internal virtual Label lblShortPassSpeed
	{
		get
		{
			return _lblShortPassSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShortPassSpeed != null)
			{
			}
			_lblShortPassSpeed = value;
			if (_lblShortPassSpeed == null)
			{
			}
		}
	}

	internal virtual Label lblDribbleSpeed
	{
		get
		{
			return _lblDribbleSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDribbleSpeed != null)
			{
			}
			_lblDribbleSpeed = value;
			if (_lblDribbleSpeed == null)
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

	internal virtual Label lblResponse
	{
		get
		{
			return _lblResponse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblResponse != null)
			{
			}
			_lblResponse = value;
			if (_lblResponse == null)
			{
			}
		}
	}

	internal virtual Label lblMentality
	{
		get
		{
			return _lblMentality;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblMentality != null)
			{
			}
			_lblMentality = value;
			if (_lblMentality == null)
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

	internal virtual Label lblJump
	{
		get
		{
			return _lblJump;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblJump != null)
			{
			}
			_lblJump = value;
			if (_lblJump == null)
			{
			}
		}
	}

	internal virtual Label lblShotTechnique
	{
		get
		{
			return _lblShotTechnique;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShotTechnique != null)
			{
			}
			_lblShotTechnique = value;
			if (_lblShotTechnique == null)
			{
			}
		}
	}

	internal virtual Label lblShotPower
	{
		get
		{
			return _lblShotPower;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShotPower != null)
			{
			}
			_lblShotPower = value;
			if (_lblShotPower == null)
			{
			}
		}
	}

	internal virtual Label lblLongPassSpeed
	{
		get
		{
			return _lblLongPassSpeed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLongPassSpeed != null)
			{
			}
			_lblLongPassSpeed = value;
			if (_lblLongPassSpeed == null)
			{
			}
		}
	}

	internal virtual Label lblOutside
	{
		get
		{
			return _lblOutside;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblOutside != null)
			{
			}
			_lblOutside = value;
			if (_lblOutside == null)
			{
			}
		}
	}

	internal virtual Label lblLongThrow
	{
		get
		{
			return _lblLongThrow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLongThrow != null)
			{
			}
			_lblLongThrow = value;
			if (_lblLongThrow == null)
			{
			}
		}
	}

	internal virtual Label lblLinePositioning
	{
		get
		{
			return _lblLinePositioning;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLinePositioning != null)
			{
			}
			_lblLinePositioning = value;
			if (_lblLinePositioning == null)
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

	internal virtual Label lblLongThrow2
	{
		get
		{
			return _lblLongThrow2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLongThrow2 != null)
			{
			}
			_lblLongThrow2 = value;
			if (_lblLongThrow2 == null)
			{
			}
		}
	}

	internal virtual Label lblOutside2
	{
		get
		{
			return _lblOutside2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblOutside2 != null)
			{
			}
			_lblOutside2 = value;
			if (_lblOutside2 == null)
			{
			}
		}
	}

	internal virtual Label lblPositioning2
	{
		get
		{
			return _lblPositioning2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPositioning2 != null)
			{
			}
			_lblPositioning2 = value;
			if (_lblPositioning2 == null)
			{
			}
		}
	}

	internal virtual Label lblLinePositioning2
	{
		get
		{
			return _lblLinePositioning2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLinePositioning2 != null)
			{
			}
			_lblLinePositioning2 = value;
			if (_lblLinePositioning2 == null)
			{
			}
		}
	}

	internal virtual Button btnClose
	{
		get
		{
			return _btnClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnClose != null)
			{
				_btnClose.Click -= btnClose_Click;
			}
			_btnClose = value;
			if (_btnClose != null)
			{
				_btnClose.Click += btnClose_Click;
			}
		}
	}

	internal virtual Label lblCooperation2
	{
		get
		{
			return _lblCooperation2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCooperation2 != null)
			{
			}
			_lblCooperation2 = value;
			if (_lblCooperation2 == null)
			{
			}
		}
	}

	internal virtual Label lblCooperation
	{
		get
		{
			return _lblCooperation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCooperation != null)
			{
			}
			_lblCooperation = value;
			if (_lblCooperation == null)
			{
			}
		}
	}

	internal virtual Label lblShortPassPrecision2
	{
		get
		{
			return _lblShortPassPrecision2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShortPassPrecision2 != null)
			{
			}
			_lblShortPassPrecision2 = value;
			if (_lblShortPassPrecision2 == null)
			{
			}
		}
	}

	internal virtual Label lblDribblePrecision2
	{
		get
		{
			return _lblDribblePrecision2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDribblePrecision2 != null)
			{
			}
			_lblDribblePrecision2 = value;
			if (_lblDribblePrecision2 == null)
			{
			}
		}
	}

	internal virtual Label lblBodyBalance2
	{
		get
		{
			return _lblBodyBalance2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblBodyBalance2 != null)
			{
			}
			_lblBodyBalance2 = value;
			if (_lblBodyBalance2 == null)
			{
			}
		}
	}

	internal virtual Label lblDefense2
	{
		get
		{
			return _lblDefense2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDefense2 != null)
			{
			}
			_lblDefense2 = value;
			if (_lblDefense2 == null)
			{
			}
		}
	}

	internal virtual Label lblLongPassPrecision2
	{
		get
		{
			return _lblLongPassPrecision2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLongPassPrecision2 != null)
			{
			}
			_lblLongPassPrecision2 = value;
			if (_lblLongPassPrecision2 == null)
			{
			}
		}
	}

	internal virtual Label lblShotPrecision2
	{
		get
		{
			return _lblShotPrecision2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShotPrecision2 != null)
			{
			}
			_lblShotPrecision2 = value;
			if (_lblShotPrecision2 == null)
			{
			}
		}
	}

	internal virtual Label lblFreeKickPrecision2
	{
		get
		{
			return _lblFreeKickPrecision2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblFreeKickPrecision2 != null)
			{
			}
			_lblFreeKickPrecision2 = value;
			if (_lblFreeKickPrecision2 == null)
			{
			}
		}
	}

	internal virtual Label lblBend2
	{
		get
		{
			return _lblBend2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblBend2 != null)
			{
			}
			_lblBend2 = value;
			if (_lblBend2 == null)
			{
			}
		}
	}

	internal virtual Label lblHeading2
	{
		get
		{
			return _lblHeading2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblHeading2 != null)
			{
			}
			_lblHeading2 = value;
			if (_lblHeading2 == null)
			{
			}
		}
	}

	internal virtual Label lblAggressiveness2
	{
		get
		{
			return _lblAggressiveness2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAggressiveness2 != null)
			{
			}
			_lblAggressiveness2 = value;
			if (_lblAggressiveness2 == null)
			{
			}
		}
	}

	internal virtual Label lblStabilityOfPlay2
	{
		get
		{
			return _lblStabilityOfPlay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStabilityOfPlay2 != null)
			{
			}
			_lblStabilityOfPlay2 = value;
			if (_lblStabilityOfPlay2 == null)
			{
			}
		}
	}

	internal virtual Label lblGoalKeeperSkill2
	{
		get
		{
			return _lblGoalKeeperSkill2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblGoalKeeperSkill2 != null)
			{
			}
			_lblGoalKeeperSkill2 = value;
			if (_lblGoalKeeperSkill2 == null)
			{
			}
		}
	}

	internal virtual Label lblStabilityOfCondition2
	{
		get
		{
			return _lblStabilityOfCondition2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStabilityOfCondition2 != null)
			{
			}
			_lblStabilityOfCondition2 = value;
			if (_lblStabilityOfCondition2 == null)
			{
			}
		}
	}

	internal virtual Label lblSecondFootAccuracy2
	{
		get
		{
			return _lblSecondFootAccuracy2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblSecondFootAccuracy2 != null)
			{
			}
			_lblSecondFootAccuracy2 = value;
			if (_lblSecondFootAccuracy2 == null)
			{
			}
		}
	}

	internal virtual Label lblDefense
	{
		get
		{
			return _lblDefense;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDefense != null)
			{
			}
			_lblDefense = value;
			if (_lblDefense == null)
			{
			}
		}
	}

	internal virtual Label lblBodyBalance
	{
		get
		{
			return _lblBodyBalance;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblBodyBalance != null)
			{
			}
			_lblBodyBalance = value;
			if (_lblBodyBalance == null)
			{
			}
		}
	}

	internal virtual Label lblShortPassPrecision
	{
		get
		{
			return _lblShortPassPrecision;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShortPassPrecision != null)
			{
			}
			_lblShortPassPrecision = value;
			if (_lblShortPassPrecision == null)
			{
			}
		}
	}

	internal virtual Label lblDribblePrecision
	{
		get
		{
			return _lblDribblePrecision;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDribblePrecision != null)
			{
			}
			_lblDribblePrecision = value;
			if (_lblDribblePrecision == null)
			{
			}
		}
	}

	internal virtual Label lblAggressiveness
	{
		get
		{
			return _lblAggressiveness;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblAggressiveness != null)
			{
			}
			_lblAggressiveness = value;
			if (_lblAggressiveness == null)
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

	internal virtual Label lblBend
	{
		get
		{
			return _lblBend;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblBend != null)
			{
			}
			_lblBend = value;
			if (_lblBend == null)
			{
			}
		}
	}

	internal virtual Label lblFreeKickPrecision
	{
		get
		{
			return _lblFreeKickPrecision;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblFreeKickPrecision != null)
			{
			}
			_lblFreeKickPrecision = value;
			if (_lblFreeKickPrecision == null)
			{
			}
		}
	}

	internal virtual Label lblShotPrecision
	{
		get
		{
			return _lblShotPrecision;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShotPrecision != null)
			{
			}
			_lblShotPrecision = value;
			if (_lblShotPrecision == null)
			{
			}
		}
	}

	internal virtual Label lblLongPassPrecision
	{
		get
		{
			return _lblLongPassPrecision;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblLongPassPrecision != null)
			{
			}
			_lblLongPassPrecision = value;
			if (_lblLongPassPrecision == null)
			{
			}
		}
	}

	internal virtual Label lblSecondFootAccuracy
	{
		get
		{
			return _lblSecondFootAccuracy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblSecondFootAccuracy != null)
			{
			}
			_lblSecondFootAccuracy = value;
			if (_lblSecondFootAccuracy == null)
			{
			}
		}
	}

	internal virtual Label lblStabilityOfCondition
	{
		get
		{
			return _lblStabilityOfCondition;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStabilityOfCondition != null)
			{
			}
			_lblStabilityOfCondition = value;
			if (_lblStabilityOfCondition == null)
			{
			}
		}
	}

	internal virtual Label lblGoalKeeperSkill
	{
		get
		{
			return _lblGoalKeeperSkill;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblGoalKeeperSkill != null)
			{
			}
			_lblGoalKeeperSkill = value;
			if (_lblGoalKeeperSkill == null)
			{
			}
		}
	}

	internal virtual Label lblStabilityOfPlay
	{
		get
		{
			return _lblStabilityOfPlay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStabilityOfPlay != null)
			{
			}
			_lblStabilityOfPlay = value;
			if (_lblStabilityOfPlay == null)
			{
			}
		}
	}

	internal virtual Label lblSecondFootFrequency
	{
		get
		{
			return _lblSecondFootFrequency;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblSecondFootFrequency != null)
			{
			}
			_lblSecondFootFrequency = value;
			if (_lblSecondFootFrequency == null)
			{
			}
		}
	}

	internal virtual Label lblSecondFootFrequency2
	{
		get
		{
			return _lblSecondFootFrequency2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblSecondFootFrequency2 != null)
			{
			}
			_lblSecondFootFrequency2 = value;
			if (_lblSecondFootFrequency2 == null)
			{
			}
		}
	}

	internal virtual Label lblSliding
	{
		get
		{
			return _lblSliding;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblSliding != null)
			{
			}
			_lblSliding = value;
			if (_lblSliding == null)
			{
			}
		}
	}

	internal virtual Label lblBackLineControl
	{
		get
		{
			return _lblBackLineControl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblBackLineControl != null)
			{
			}
			_lblBackLineControl = value;
			if (_lblBackLineControl == null)
			{
			}
		}
	}

	internal virtual Label lblManMarking
	{
		get
		{
			return _lblManMarking;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblManMarking != null)
			{
			}
			_lblManMarking = value;
			if (_lblManMarking == null)
			{
			}
		}
	}

	internal virtual Label lblCentrePlayer
	{
		get
		{
			return _lblCentrePlayer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCentrePlayer != null)
			{
			}
			_lblCentrePlayer = value;
			if (_lblCentrePlayer == null)
			{
			}
		}
	}

	internal virtual Label lblSidePlayer
	{
		get
		{
			return _lblSidePlayer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblSidePlayer != null)
			{
			}
			_lblSidePlayer = value;
			if (_lblSidePlayer == null)
			{
			}
		}
	}

	internal virtual Label lblDirectPlay
	{
		get
		{
			return _lblDirectPlay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDirectPlay != null)
			{
			}
			_lblDirectPlay = value;
			if (_lblDirectPlay == null)
			{
			}
		}
	}

	internal virtual Label lblShoot1On1
	{
		get
		{
			return _lblShoot1On1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShoot1On1 != null)
			{
			}
			_lblShoot1On1 = value;
			if (_lblShoot1On1 == null)
			{
			}
		}
	}

	internal virtual Label lblPKKicker
	{
		get
		{
			return _lblPKKicker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPKKicker != null)
			{
			}
			_lblPKKicker = value;
			if (_lblPKKicker == null)
			{
			}
		}
	}

	internal virtual Label lblCovering
	{
		get
		{
			return _lblCovering;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCovering != null)
			{
			}
			_lblCovering = value;
			if (_lblCovering == null)
			{
			}
		}
	}

	internal virtual Label lblPasser
	{
		get
		{
			return _lblPasser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPasser != null)
			{
			}
			_lblPasser = value;
			if (_lblPasser == null)
			{
			}
		}
	}

	internal virtual Label lblCommander
	{
		get
		{
			return _lblCommander;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCommander != null)
			{
			}
			_lblCommander = value;
			if (_lblCommander == null)
			{
			}
		}
	}

	internal virtual Label lblStriker
	{
		get
		{
			return _lblStriker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStriker != null)
			{
			}
			_lblStriker = value;
			if (_lblStriker == null)
			{
			}
		}
	}

	internal virtual Label lblDashIn
	{
		get
		{
			return _lblDashIn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDashIn != null)
			{
			}
			_lblDashIn = value;
			if (_lblDashIn == null)
			{
			}
		}
	}

	internal virtual Label lblHoldingUpTheBall
	{
		get
		{
			return _lblHoldingUpTheBall;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblHoldingUpTheBall != null)
			{
			}
			_lblHoldingUpTheBall = value;
			if (_lblHoldingUpTheBall == null)
			{
			}
		}
	}

	internal virtual Label lblKeepDribble
	{
		get
		{
			return _lblKeepDribble;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblKeepDribble != null)
			{
			}
			_lblKeepDribble = value;
			if (_lblKeepDribble == null)
			{
			}
		}
	}

	internal virtual Label lblDribbler
	{
		get
		{
			return _lblDribbler;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDribbler != null)
			{
			}
			_lblDribbler = value;
			if (_lblDribbler == null)
			{
			}
		}
	}

	internal virtual Label lblDirectPlay2
	{
		get
		{
			return _lblDirectPlay2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDirectPlay2 != null)
			{
			}
			_lblDirectPlay2 = value;
			if (_lblDirectPlay2 == null)
			{
			}
		}
	}

	internal virtual Label lblSidePlayer2
	{
		get
		{
			return _lblSidePlayer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblSidePlayer2 != null)
			{
			}
			_lblSidePlayer2 = value;
			if (_lblSidePlayer2 == null)
			{
			}
		}
	}

	internal virtual Label lblCentrePlayer2
	{
		get
		{
			return _lblCentrePlayer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCentrePlayer2 != null)
			{
			}
			_lblCentrePlayer2 = value;
			if (_lblCentrePlayer2 == null)
			{
			}
		}
	}

	internal virtual Label lblManMarking2
	{
		get
		{
			return _lblManMarking2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblManMarking2 != null)
			{
			}
			_lblManMarking2 = value;
			if (_lblManMarking2 == null)
			{
			}
		}
	}

	internal virtual Label lblBackLineControl2
	{
		get
		{
			return _lblBackLineControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblBackLineControl2 != null)
			{
			}
			_lblBackLineControl2 = value;
			if (_lblBackLineControl2 == null)
			{
			}
		}
	}

	internal virtual Label lblSliding2
	{
		get
		{
			return _lblSliding2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblSliding2 != null)
			{
			}
			_lblSliding2 = value;
			if (_lblSliding2 == null)
			{
			}
		}
	}

	internal virtual Label lblShoot1On12
	{
		get
		{
			return _lblShoot1On12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblShoot1On12 != null)
			{
			}
			_lblShoot1On12 = value;
			if (_lblShoot1On12 == null)
			{
			}
		}
	}

	internal virtual Label lblKeepDribble2
	{
		get
		{
			return _lblKeepDribble2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblKeepDribble2 != null)
			{
			}
			_lblKeepDribble2 = value;
			if (_lblKeepDribble2 == null)
			{
			}
		}
	}

	internal virtual Label lblHoldingUpTheBall2
	{
		get
		{
			return _lblHoldingUpTheBall2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblHoldingUpTheBall2 != null)
			{
			}
			_lblHoldingUpTheBall2 = value;
			if (_lblHoldingUpTheBall2 == null)
			{
			}
		}
	}

	internal virtual Label lblDashIn2
	{
		get
		{
			return _lblDashIn2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDashIn2 != null)
			{
			}
			_lblDashIn2 = value;
			if (_lblDashIn2 == null)
			{
			}
		}
	}

	internal virtual Label lblStriker2
	{
		get
		{
			return _lblStriker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblStriker2 != null)
			{
			}
			_lblStriker2 = value;
			if (_lblStriker2 == null)
			{
			}
		}
	}

	internal virtual Label lblCommander2
	{
		get
		{
			return _lblCommander2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCommander2 != null)
			{
			}
			_lblCommander2 = value;
			if (_lblCommander2 == null)
			{
			}
		}
	}

	internal virtual Label lblPasser2
	{
		get
		{
			return _lblPasser2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPasser2 != null)
			{
			}
			_lblPasser2 = value;
			if (_lblPasser2 == null)
			{
			}
		}
	}

	internal virtual Label lblCovering2
	{
		get
		{
			return _lblCovering2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblCovering2 != null)
			{
			}
			_lblCovering2 = value;
			if (_lblCovering2 == null)
			{
			}
		}
	}

	internal virtual Label lblPKKicker2
	{
		get
		{
			return _lblPKKicker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPKKicker2 != null)
			{
			}
			_lblPKKicker2 = value;
			if (_lblPKKicker2 == null)
			{
			}
		}
	}

	internal virtual Label lblDribbler2
	{
		get
		{
			return _lblDribbler2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblDribbler2 != null)
			{
			}
			_lblDribbler2 = value;
			if (_lblDribbler2 == null)
			{
			}
		}
	}

	internal virtual Label lblMiddleShot
	{
		get
		{
			return _lblMiddleShot;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblMiddleShot != null)
			{
			}
			_lblMiddleShot = value;
			if (_lblMiddleShot == null)
			{
			}
		}
	}

	internal virtual Label lblMiddleShot2
	{
		get
		{
			return _lblMiddleShot2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblMiddleShot2 != null)
			{
			}
			_lblMiddleShot2 = value;
			if (_lblMiddleShot2 == null)
			{
			}
		}
	}

	internal virtual GroupBox grpSpecialAbilities
	{
		get
		{
			return _grpSpecialAbilities;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_grpSpecialAbilities != null)
			{
			}
			_grpSpecialAbilities = value;
			if (_grpSpecialAbilities == null)
			{
			}
		}
	}

	internal virtual GroupBox grpAbilities
	{
		get
		{
			return _grpAbilities;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_grpAbilities != null)
			{
			}
			_grpAbilities = value;
			if (_grpAbilities == null)
			{
			}
		}
	}

	internal virtual Label lblPosition2
	{
		get
		{
			return _lblPosition2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPosition2 != null)
			{
			}
			_lblPosition2 = value;
			if (_lblPosition2 == null)
			{
			}
		}
	}

	internal virtual GroupBox GroupBox1
	{
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_GroupBox1 != null)
			{
			}
			_GroupBox1 = value;
			if (_GroupBox1 == null)
			{
			}
		}
	}

	internal virtual Label lblPreferredFoot2
	{
		get
		{
			return _lblPreferredFoot2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lblPreferredFoot2 != null)
			{
			}
			_lblPreferredFoot2 = value;
			if (_lblPreferredFoot2 == null)
			{
			}
		}
	}

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

	public frmWEPES()
	{
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

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.lblAttack2 = new System.Windows.Forms.Label();
		this.lblShortPassPrecision2 = new System.Windows.Forms.Label();
		this.lblDribbleSpeed2 = new System.Windows.Forms.Label();
		this.lblDribblePrecision2 = new System.Windows.Forms.Label();
		this.lblAgility2 = new System.Windows.Forms.Label();
		this.lblResponse2 = new System.Windows.Forms.Label();
		this.lblAcceleration2 = new System.Windows.Forms.Label();
		this.lblTopSpeed2 = new System.Windows.Forms.Label();
		this.lblStamina2 = new System.Windows.Forms.Label();
		this.lblBodyBalance2 = new System.Windows.Forms.Label();
		this.lblDefense2 = new System.Windows.Forms.Label();
		this.lblLongPassPrecision2 = new System.Windows.Forms.Label();
		this.lblLongPassSpeed2 = new System.Windows.Forms.Label();
		this.lblShotPrecision2 = new System.Windows.Forms.Label();
		this.lblShotPower2 = new System.Windows.Forms.Label();
		this.lblShotTechnique2 = new System.Windows.Forms.Label();
		this.lblFreeKickPrecision2 = new System.Windows.Forms.Label();
		this.lblBend2 = new System.Windows.Forms.Label();
		this.lblHeading2 = new System.Windows.Forms.Label();
		this.lblJump2 = new System.Windows.Forms.Label();
		this.lblTechnique2 = new System.Windows.Forms.Label();
		this.lblShortPassSpeed2 = new System.Windows.Forms.Label();
		this.lblAggressiveness2 = new System.Windows.Forms.Label();
		this.lblMentality2 = new System.Windows.Forms.Label();
		this.lblStabilityOfPlay2 = new System.Windows.Forms.Label();
		this.lblGoalKeeperSkill2 = new System.Windows.Forms.Label();
		this.lblCooperation2 = new System.Windows.Forms.Label();
		this.lblStabilityOfCondition2 = new System.Windows.Forms.Label();
		this.lblSecondFootAccuracy2 = new System.Windows.Forms.Label();
		this.lblAttack = new System.Windows.Forms.Label();
		this.lblDefense = new System.Windows.Forms.Label();
		this.lblBodyBalance = new System.Windows.Forms.Label();
		this.lblAcceleration = new System.Windows.Forms.Label();
		this.lblTopSpeed = new System.Windows.Forms.Label();
		this.lblStamina = new System.Windows.Forms.Label();
		this.lblShortPassSpeed = new System.Windows.Forms.Label();
		this.lblShortPassPrecision = new System.Windows.Forms.Label();
		this.lblDribbleSpeed = new System.Windows.Forms.Label();
		this.lblDribblePrecision = new System.Windows.Forms.Label();
		this.lblAgility = new System.Windows.Forms.Label();
		this.lblResponse = new System.Windows.Forms.Label();
		this.lblMentality = new System.Windows.Forms.Label();
		this.lblAggressiveness = new System.Windows.Forms.Label();
		this.lblTechnique = new System.Windows.Forms.Label();
		this.lblJump = new System.Windows.Forms.Label();
		this.lblHeading = new System.Windows.Forms.Label();
		this.lblBend = new System.Windows.Forms.Label();
		this.lblFreeKickPrecision = new System.Windows.Forms.Label();
		this.lblShotTechnique = new System.Windows.Forms.Label();
		this.lblShotPower = new System.Windows.Forms.Label();
		this.lblShotPrecision = new System.Windows.Forms.Label();
		this.lblLongPassSpeed = new System.Windows.Forms.Label();
		this.lblLongPassPrecision = new System.Windows.Forms.Label();
		this.lblSecondFootAccuracy = new System.Windows.Forms.Label();
		this.lblStabilityOfCondition = new System.Windows.Forms.Label();
		this.lblCooperation = new System.Windows.Forms.Label();
		this.lblGoalKeeperSkill = new System.Windows.Forms.Label();
		this.lblStabilityOfPlay = new System.Windows.Forms.Label();
		this.lblSecondFootFrequency = new System.Windows.Forms.Label();
		this.lblSecondFootFrequency2 = new System.Windows.Forms.Label();
		this.lblSliding = new System.Windows.Forms.Label();
		this.lblBackLineControl = new System.Windows.Forms.Label();
		this.lblManMarking = new System.Windows.Forms.Label();
		this.lblOutside = new System.Windows.Forms.Label();
		this.lblCentrePlayer = new System.Windows.Forms.Label();
		this.lblSidePlayer = new System.Windows.Forms.Label();
		this.lblDirectPlay = new System.Windows.Forms.Label();
		this.lblLongThrow = new System.Windows.Forms.Label();
		this.lblShoot1On1 = new System.Windows.Forms.Label();
		this.lblPKKicker = new System.Windows.Forms.Label();
		this.lblCovering = new System.Windows.Forms.Label();
		this.lblPasser = new System.Windows.Forms.Label();
		this.lblCommander = new System.Windows.Forms.Label();
		this.lblStriker = new System.Windows.Forms.Label();
		this.lblLinePositioning = new System.Windows.Forms.Label();
		this.lblDashIn = new System.Windows.Forms.Label();
		this.lblPositioning = new System.Windows.Forms.Label();
		this.lblHoldingUpTheBall = new System.Windows.Forms.Label();
		this.lblKeepDribble = new System.Windows.Forms.Label();
		this.lblDribbler = new System.Windows.Forms.Label();
		this.lblLongThrow2 = new System.Windows.Forms.Label();
		this.lblDirectPlay2 = new System.Windows.Forms.Label();
		this.lblSidePlayer2 = new System.Windows.Forms.Label();
		this.lblCentrePlayer2 = new System.Windows.Forms.Label();
		this.lblOutside2 = new System.Windows.Forms.Label();
		this.lblManMarking2 = new System.Windows.Forms.Label();
		this.lblBackLineControl2 = new System.Windows.Forms.Label();
		this.lblSliding2 = new System.Windows.Forms.Label();
		this.lblShoot1On12 = new System.Windows.Forms.Label();
		this.lblKeepDribble2 = new System.Windows.Forms.Label();
		this.lblHoldingUpTheBall2 = new System.Windows.Forms.Label();
		this.lblPositioning2 = new System.Windows.Forms.Label();
		this.lblDashIn2 = new System.Windows.Forms.Label();
		this.lblLinePositioning2 = new System.Windows.Forms.Label();
		this.lblStriker2 = new System.Windows.Forms.Label();
		this.lblCommander2 = new System.Windows.Forms.Label();
		this.lblPasser2 = new System.Windows.Forms.Label();
		this.lblCovering2 = new System.Windows.Forms.Label();
		this.lblPKKicker2 = new System.Windows.Forms.Label();
		this.lblDribbler2 = new System.Windows.Forms.Label();
		this.btnClose = new System.Windows.Forms.Button();
		this.lblMiddleShot = new System.Windows.Forms.Label();
		this.lblMiddleShot2 = new System.Windows.Forms.Label();
		this.grpSpecialAbilities = new System.Windows.Forms.GroupBox();
		this.grpAbilities = new System.Windows.Forms.GroupBox();
		this.lblPosition2 = new System.Windows.Forms.Label();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.lblPreferredFoot2 = new System.Windows.Forms.Label();
		this.lblPosition = new System.Windows.Forms.Label();
		this.lblPreferredFoot = new System.Windows.Forms.Label();
		this.grpSpecialAbilities.SuspendLayout();
		this.grpAbilities.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		this.SuspendLayout();
		this.lblAttack2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label = this.lblAttack2;
		System.Drawing.Point location = new System.Drawing.Point(16, 24);
		label.Location = location;
		this.lblAttack2.Name = "lblAttack2";
		System.Windows.Forms.Label label2 = this.lblAttack2;
		System.Drawing.Size size = new System.Drawing.Size(128, 16);
		label2.Size = size;
		this.lblAttack2.TabIndex = 0;
		this.lblAttack2.Text = "Attack";
		this.lblAttack2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShortPassPrecision2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label3 = this.lblShortPassPrecision2;
		location = new System.Drawing.Point(16, 184);
		label3.Location = location;
		this.lblShortPassPrecision2.Name = "lblShortPassPrecision2";
		System.Windows.Forms.Label label4 = this.lblShortPassPrecision2;
		size = new System.Drawing.Size(128, 16);
		label4.Size = size;
		this.lblShortPassPrecision2.TabIndex = 1;
		this.lblShortPassPrecision2.Text = "Short Pass Precision";
		this.lblShortPassPrecision2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDribbleSpeed2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label5 = this.lblDribbleSpeed2;
		location = new System.Drawing.Point(16, 168);
		label5.Location = location;
		this.lblDribbleSpeed2.Name = "lblDribbleSpeed2";
		System.Windows.Forms.Label label6 = this.lblDribbleSpeed2;
		size = new System.Drawing.Size(128, 16);
		label6.Size = size;
		this.lblDribbleSpeed2.TabIndex = 2;
		this.lblDribbleSpeed2.Text = "Dribble Speed";
		this.lblDribbleSpeed2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDribblePrecision2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label7 = this.lblDribblePrecision2;
		location = new System.Drawing.Point(16, 152);
		label7.Location = location;
		this.lblDribblePrecision2.Name = "lblDribblePrecision2";
		System.Windows.Forms.Label label8 = this.lblDribblePrecision2;
		size = new System.Drawing.Size(128, 16);
		label8.Size = size;
		this.lblDribblePrecision2.TabIndex = 3;
		this.lblDribblePrecision2.Text = "Dribble Precision";
		this.lblDribblePrecision2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAgility2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label9 = this.lblAgility2;
		location = new System.Drawing.Point(16, 136);
		label9.Location = location;
		this.lblAgility2.Name = "lblAgility2";
		System.Windows.Forms.Label label10 = this.lblAgility2;
		size = new System.Drawing.Size(128, 16);
		label10.Size = size;
		this.lblAgility2.TabIndex = 4;
		this.lblAgility2.Text = "Agility";
		this.lblAgility2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblResponse2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label11 = this.lblResponse2;
		location = new System.Drawing.Point(16, 120);
		label11.Location = location;
		this.lblResponse2.Name = "lblResponse2";
		System.Windows.Forms.Label label12 = this.lblResponse2;
		size = new System.Drawing.Size(128, 16);
		label12.Size = size;
		this.lblResponse2.TabIndex = 5;
		this.lblResponse2.Text = "Response";
		this.lblResponse2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAcceleration2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label13 = this.lblAcceleration2;
		location = new System.Drawing.Point(16, 104);
		label13.Location = location;
		this.lblAcceleration2.Name = "lblAcceleration2";
		System.Windows.Forms.Label label14 = this.lblAcceleration2;
		size = new System.Drawing.Size(128, 16);
		label14.Size = size;
		this.lblAcceleration2.TabIndex = 6;
		this.lblAcceleration2.Text = "Acceleration";
		this.lblAcceleration2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblTopSpeed2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label15 = this.lblTopSpeed2;
		location = new System.Drawing.Point(16, 88);
		label15.Location = location;
		this.lblTopSpeed2.Name = "lblTopSpeed2";
		System.Windows.Forms.Label label16 = this.lblTopSpeed2;
		size = new System.Drawing.Size(128, 16);
		label16.Size = size;
		this.lblTopSpeed2.TabIndex = 7;
		this.lblTopSpeed2.Text = "Top Speed";
		this.lblTopSpeed2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStamina2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label17 = this.lblStamina2;
		location = new System.Drawing.Point(16, 72);
		label17.Location = location;
		this.lblStamina2.Name = "lblStamina2";
		System.Windows.Forms.Label label18 = this.lblStamina2;
		size = new System.Drawing.Size(128, 16);
		label18.Size = size;
		this.lblStamina2.TabIndex = 8;
		this.lblStamina2.Text = "Stamina";
		this.lblStamina2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblBodyBalance2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label19 = this.lblBodyBalance2;
		location = new System.Drawing.Point(16, 56);
		label19.Location = location;
		this.lblBodyBalance2.Name = "lblBodyBalance2";
		System.Windows.Forms.Label label20 = this.lblBodyBalance2;
		size = new System.Drawing.Size(128, 16);
		label20.Size = size;
		this.lblBodyBalance2.TabIndex = 9;
		this.lblBodyBalance2.Text = "Body Balance";
		this.lblBodyBalance2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDefense2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label21 = this.lblDefense2;
		location = new System.Drawing.Point(16, 40);
		label21.Location = location;
		this.lblDefense2.Name = "lblDefense2";
		System.Windows.Forms.Label label22 = this.lblDefense2;
		size = new System.Drawing.Size(128, 16);
		label22.Size = size;
		this.lblDefense2.TabIndex = 10;
		this.lblDefense2.Text = "Defense";
		this.lblDefense2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblLongPassPrecision2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label23 = this.lblLongPassPrecision2;
		location = new System.Drawing.Point(16, 216);
		label23.Location = location;
		this.lblLongPassPrecision2.Name = "lblLongPassPrecision2";
		System.Windows.Forms.Label label24 = this.lblLongPassPrecision2;
		size = new System.Drawing.Size(128, 16);
		label24.Size = size;
		this.lblLongPassPrecision2.TabIndex = 21;
		this.lblLongPassPrecision2.Text = "Long Pass Precision";
		this.lblLongPassPrecision2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblLongPassSpeed2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label25 = this.lblLongPassSpeed2;
		location = new System.Drawing.Point(16, 232);
		label25.Location = location;
		this.lblLongPassSpeed2.Name = "lblLongPassSpeed2";
		System.Windows.Forms.Label label26 = this.lblLongPassSpeed2;
		size = new System.Drawing.Size(128, 16);
		label26.Size = size;
		this.lblLongPassSpeed2.TabIndex = 20;
		this.lblLongPassSpeed2.Text = "Long Pass Speed";
		this.lblLongPassSpeed2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShotPrecision2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label27 = this.lblShotPrecision2;
		location = new System.Drawing.Point(16, 248);
		label27.Location = location;
		this.lblShotPrecision2.Name = "lblShotPrecision2";
		System.Windows.Forms.Label label28 = this.lblShotPrecision2;
		size = new System.Drawing.Size(128, 16);
		label28.Size = size;
		this.lblShotPrecision2.TabIndex = 19;
		this.lblShotPrecision2.Text = "Shot Precision";
		this.lblShotPrecision2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShotPower2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label29 = this.lblShotPower2;
		location = new System.Drawing.Point(16, 264);
		label29.Location = location;
		this.lblShotPower2.Name = "lblShotPower2";
		System.Windows.Forms.Label label30 = this.lblShotPower2;
		size = new System.Drawing.Size(128, 16);
		label30.Size = size;
		this.lblShotPower2.TabIndex = 18;
		this.lblShotPower2.Text = "Shot Power";
		this.lblShotPower2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShotTechnique2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label31 = this.lblShotTechnique2;
		location = new System.Drawing.Point(16, 280);
		label31.Location = location;
		this.lblShotTechnique2.Name = "lblShotTechnique2";
		System.Windows.Forms.Label label32 = this.lblShotTechnique2;
		size = new System.Drawing.Size(128, 16);
		label32.Size = size;
		this.lblShotTechnique2.TabIndex = 17;
		this.lblShotTechnique2.Text = "Shot Technique";
		this.lblShotTechnique2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblFreeKickPrecision2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label33 = this.lblFreeKickPrecision2;
		location = new System.Drawing.Point(16, 296);
		label33.Location = location;
		this.lblFreeKickPrecision2.Name = "lblFreeKickPrecision2";
		System.Windows.Forms.Label label34 = this.lblFreeKickPrecision2;
		size = new System.Drawing.Size(128, 16);
		label34.Size = size;
		this.lblFreeKickPrecision2.TabIndex = 16;
		this.lblFreeKickPrecision2.Text = "Free Kick Precision";
		this.lblFreeKickPrecision2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblBend2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label35 = this.lblBend2;
		location = new System.Drawing.Point(16, 312);
		label35.Location = location;
		this.lblBend2.Name = "lblBend2";
		System.Windows.Forms.Label label36 = this.lblBend2;
		size = new System.Drawing.Size(128, 16);
		label36.Size = size;
		this.lblBend2.TabIndex = 15;
		this.lblBend2.Text = "Bend";
		this.lblBend2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblHeading2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label37 = this.lblHeading2;
		location = new System.Drawing.Point(16, 328);
		label37.Location = location;
		this.lblHeading2.Name = "lblHeading2";
		System.Windows.Forms.Label label38 = this.lblHeading2;
		size = new System.Drawing.Size(128, 16);
		label38.Size = size;
		this.lblHeading2.TabIndex = 14;
		this.lblHeading2.Text = "Heading";
		this.lblHeading2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblJump2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label39 = this.lblJump2;
		location = new System.Drawing.Point(16, 344);
		label39.Location = location;
		this.lblJump2.Name = "lblJump2";
		System.Windows.Forms.Label label40 = this.lblJump2;
		size = new System.Drawing.Size(128, 16);
		label40.Size = size;
		this.lblJump2.TabIndex = 13;
		this.lblJump2.Text = "Jump";
		this.lblJump2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblTechnique2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label41 = this.lblTechnique2;
		location = new System.Drawing.Point(16, 360);
		label41.Location = location;
		this.lblTechnique2.Name = "lblTechnique2";
		System.Windows.Forms.Label label42 = this.lblTechnique2;
		size = new System.Drawing.Size(128, 16);
		label42.Size = size;
		this.lblTechnique2.TabIndex = 12;
		this.lblTechnique2.Text = "Technique";
		this.lblTechnique2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShortPassSpeed2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label43 = this.lblShortPassSpeed2;
		location = new System.Drawing.Point(16, 200);
		label43.Location = location;
		this.lblShortPassSpeed2.Name = "lblShortPassSpeed2";
		System.Windows.Forms.Label label44 = this.lblShortPassSpeed2;
		size = new System.Drawing.Size(128, 16);
		label44.Size = size;
		this.lblShortPassSpeed2.TabIndex = 11;
		this.lblShortPassSpeed2.Text = "Short Pass Speed";
		this.lblShortPassSpeed2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAggressiveness2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label45 = this.lblAggressiveness2;
		location = new System.Drawing.Point(16, 376);
		label45.Location = location;
		this.lblAggressiveness2.Name = "lblAggressiveness2";
		System.Windows.Forms.Label label46 = this.lblAggressiveness2;
		size = new System.Drawing.Size(128, 16);
		label46.Size = size;
		this.lblAggressiveness2.TabIndex = 28;
		this.lblAggressiveness2.Text = "Aggressiveness";
		this.lblAggressiveness2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblMentality2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label47 = this.lblMentality2;
		location = new System.Drawing.Point(16, 392);
		label47.Location = location;
		this.lblMentality2.Name = "lblMentality2";
		System.Windows.Forms.Label label48 = this.lblMentality2;
		size = new System.Drawing.Size(128, 16);
		label48.Size = size;
		this.lblMentality2.TabIndex = 27;
		this.lblMentality2.Text = "Mentality";
		this.lblMentality2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStabilityOfPlay2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label49 = this.lblStabilityOfPlay2;
		location = new System.Drawing.Point(16, 440);
		label49.Location = location;
		this.lblStabilityOfPlay2.Name = "lblStabilityOfPlay2";
		System.Windows.Forms.Label label50 = this.lblStabilityOfPlay2;
		size = new System.Drawing.Size(128, 16);
		label50.Size = size;
		this.lblStabilityOfPlay2.TabIndex = 26;
		this.lblStabilityOfPlay2.Text = "Stability of Play";
		this.lblStabilityOfPlay2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblGoalKeeperSkill2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label51 = this.lblGoalKeeperSkill2;
		location = new System.Drawing.Point(16, 408);
		label51.Location = location;
		this.lblGoalKeeperSkill2.Name = "lblGoalKeeperSkill2";
		System.Windows.Forms.Label label52 = this.lblGoalKeeperSkill2;
		size = new System.Drawing.Size(128, 16);
		label52.Size = size;
		this.lblGoalKeeperSkill2.TabIndex = 25;
		this.lblGoalKeeperSkill2.Text = "Goal Keeper Skill";
		this.lblGoalKeeperSkill2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCooperation2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label53 = this.lblCooperation2;
		location = new System.Drawing.Point(16, 424);
		label53.Location = location;
		this.lblCooperation2.Name = "lblCooperation2";
		System.Windows.Forms.Label label54 = this.lblCooperation2;
		size = new System.Drawing.Size(128, 16);
		label54.Size = size;
		this.lblCooperation2.TabIndex = 24;
		this.lblCooperation2.Text = "Cooperation";
		this.lblCooperation2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStabilityOfCondition2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label55 = this.lblStabilityOfCondition2;
		location = new System.Drawing.Point(16, 456);
		label55.Location = location;
		this.lblStabilityOfCondition2.Name = "lblStabilityOfCondition2";
		System.Windows.Forms.Label label56 = this.lblStabilityOfCondition2;
		size = new System.Drawing.Size(128, 16);
		label56.Size = size;
		this.lblStabilityOfCondition2.TabIndex = 23;
		this.lblStabilityOfCondition2.Text = "Stability of Condition";
		this.lblStabilityOfCondition2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblSecondFootAccuracy2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label57 = this.lblSecondFootAccuracy2;
		location = new System.Drawing.Point(16, 488);
		label57.Location = location;
		this.lblSecondFootAccuracy2.Name = "lblSecondFootAccuracy2";
		System.Windows.Forms.Label label58 = this.lblSecondFootAccuracy2;
		size = new System.Drawing.Size(128, 16);
		label58.Size = size;
		this.lblSecondFootAccuracy2.TabIndex = 22;
		this.lblSecondFootAccuracy2.Text = "Second Foot Accuracy";
		this.lblSecondFootAccuracy2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAttack.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label59 = this.lblAttack;
		location = new System.Drawing.Point(152, 24);
		label59.Location = location;
		this.lblAttack.Name = "lblAttack";
		System.Windows.Forms.Label label60 = this.lblAttack;
		size = new System.Drawing.Size(24, 16);
		label60.Size = size;
		this.lblAttack.TabIndex = 29;
		this.lblAttack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDefense.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label61 = this.lblDefense;
		location = new System.Drawing.Point(152, 40);
		label61.Location = location;
		this.lblDefense.Name = "lblDefense";
		System.Windows.Forms.Label label62 = this.lblDefense;
		size = new System.Drawing.Size(24, 16);
		label62.Size = size;
		this.lblDefense.TabIndex = 30;
		this.lblDefense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblBodyBalance.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label63 = this.lblBodyBalance;
		location = new System.Drawing.Point(152, 56);
		label63.Location = location;
		this.lblBodyBalance.Name = "lblBodyBalance";
		System.Windows.Forms.Label label64 = this.lblBodyBalance;
		size = new System.Drawing.Size(24, 16);
		label64.Size = size;
		this.lblBodyBalance.TabIndex = 31;
		this.lblBodyBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAcceleration.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label65 = this.lblAcceleration;
		location = new System.Drawing.Point(152, 104);
		label65.Location = location;
		this.lblAcceleration.Name = "lblAcceleration";
		System.Windows.Forms.Label label66 = this.lblAcceleration;
		size = new System.Drawing.Size(24, 16);
		label66.Size = size;
		this.lblAcceleration.TabIndex = 34;
		this.lblAcceleration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblTopSpeed.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label67 = this.lblTopSpeed;
		location = new System.Drawing.Point(152, 88);
		label67.Location = location;
		this.lblTopSpeed.Name = "lblTopSpeed";
		System.Windows.Forms.Label label68 = this.lblTopSpeed;
		size = new System.Drawing.Size(24, 16);
		label68.Size = size;
		this.lblTopSpeed.TabIndex = 33;
		this.lblTopSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStamina.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label69 = this.lblStamina;
		location = new System.Drawing.Point(152, 72);
		label69.Location = location;
		this.lblStamina.Name = "lblStamina";
		System.Windows.Forms.Label label70 = this.lblStamina;
		size = new System.Drawing.Size(24, 16);
		label70.Size = size;
		this.lblStamina.TabIndex = 32;
		this.lblStamina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShortPassSpeed.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label71 = this.lblShortPassSpeed;
		location = new System.Drawing.Point(152, 200);
		label71.Location = location;
		this.lblShortPassSpeed.Name = "lblShortPassSpeed";
		System.Windows.Forms.Label label72 = this.lblShortPassSpeed;
		size = new System.Drawing.Size(24, 16);
		label72.Size = size;
		this.lblShortPassSpeed.TabIndex = 40;
		this.lblShortPassSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShortPassPrecision.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label73 = this.lblShortPassPrecision;
		location = new System.Drawing.Point(152, 184);
		label73.Location = location;
		this.lblShortPassPrecision.Name = "lblShortPassPrecision";
		System.Windows.Forms.Label label74 = this.lblShortPassPrecision;
		size = new System.Drawing.Size(24, 16);
		label74.Size = size;
		this.lblShortPassPrecision.TabIndex = 39;
		this.lblShortPassPrecision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDribbleSpeed.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label75 = this.lblDribbleSpeed;
		location = new System.Drawing.Point(152, 168);
		label75.Location = location;
		this.lblDribbleSpeed.Name = "lblDribbleSpeed";
		System.Windows.Forms.Label label76 = this.lblDribbleSpeed;
		size = new System.Drawing.Size(24, 16);
		label76.Size = size;
		this.lblDribbleSpeed.TabIndex = 38;
		this.lblDribbleSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDribblePrecision.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label77 = this.lblDribblePrecision;
		location = new System.Drawing.Point(152, 152);
		label77.Location = location;
		this.lblDribblePrecision.Name = "lblDribblePrecision";
		System.Windows.Forms.Label label78 = this.lblDribblePrecision;
		size = new System.Drawing.Size(24, 16);
		label78.Size = size;
		this.lblDribblePrecision.TabIndex = 37;
		this.lblDribblePrecision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAgility.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label79 = this.lblAgility;
		location = new System.Drawing.Point(152, 136);
		label79.Location = location;
		this.lblAgility.Name = "lblAgility";
		System.Windows.Forms.Label label80 = this.lblAgility;
		size = new System.Drawing.Size(24, 16);
		label80.Size = size;
		this.lblAgility.TabIndex = 36;
		this.lblAgility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblResponse.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label81 = this.lblResponse;
		location = new System.Drawing.Point(152, 120);
		label81.Location = location;
		this.lblResponse.Name = "lblResponse";
		System.Windows.Forms.Label label82 = this.lblResponse;
		size = new System.Drawing.Size(24, 16);
		label82.Size = size;
		this.lblResponse.TabIndex = 35;
		this.lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblMentality.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label83 = this.lblMentality;
		location = new System.Drawing.Point(152, 392);
		label83.Location = location;
		this.lblMentality.Name = "lblMentality";
		System.Windows.Forms.Label label84 = this.lblMentality;
		size = new System.Drawing.Size(24, 16);
		label84.Size = size;
		this.lblMentality.TabIndex = 52;
		this.lblMentality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAggressiveness.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label85 = this.lblAggressiveness;
		location = new System.Drawing.Point(152, 376);
		label85.Location = location;
		this.lblAggressiveness.Name = "lblAggressiveness";
		System.Windows.Forms.Label label86 = this.lblAggressiveness;
		size = new System.Drawing.Size(24, 16);
		label86.Size = size;
		this.lblAggressiveness.TabIndex = 51;
		this.lblAggressiveness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblTechnique.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label87 = this.lblTechnique;
		location = new System.Drawing.Point(152, 360);
		label87.Location = location;
		this.lblTechnique.Name = "lblTechnique";
		System.Windows.Forms.Label label88 = this.lblTechnique;
		size = new System.Drawing.Size(24, 16);
		label88.Size = size;
		this.lblTechnique.TabIndex = 50;
		this.lblTechnique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblJump.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label89 = this.lblJump;
		location = new System.Drawing.Point(152, 344);
		label89.Location = location;
		this.lblJump.Name = "lblJump";
		System.Windows.Forms.Label label90 = this.lblJump;
		size = new System.Drawing.Size(24, 16);
		label90.Size = size;
		this.lblJump.TabIndex = 49;
		this.lblJump.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblHeading.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label91 = this.lblHeading;
		location = new System.Drawing.Point(152, 328);
		label91.Location = location;
		this.lblHeading.Name = "lblHeading";
		System.Windows.Forms.Label label92 = this.lblHeading;
		size = new System.Drawing.Size(24, 16);
		label92.Size = size;
		this.lblHeading.TabIndex = 48;
		this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblBend.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label93 = this.lblBend;
		location = new System.Drawing.Point(152, 312);
		label93.Location = location;
		this.lblBend.Name = "lblBend";
		System.Windows.Forms.Label label94 = this.lblBend;
		size = new System.Drawing.Size(24, 16);
		label94.Size = size;
		this.lblBend.TabIndex = 47;
		this.lblBend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblFreeKickPrecision.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label95 = this.lblFreeKickPrecision;
		location = new System.Drawing.Point(152, 296);
		label95.Location = location;
		this.lblFreeKickPrecision.Name = "lblFreeKickPrecision";
		System.Windows.Forms.Label label96 = this.lblFreeKickPrecision;
		size = new System.Drawing.Size(24, 16);
		label96.Size = size;
		this.lblFreeKickPrecision.TabIndex = 46;
		this.lblFreeKickPrecision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShotTechnique.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label97 = this.lblShotTechnique;
		location = new System.Drawing.Point(152, 280);
		label97.Location = location;
		this.lblShotTechnique.Name = "lblShotTechnique";
		System.Windows.Forms.Label label98 = this.lblShotTechnique;
		size = new System.Drawing.Size(24, 16);
		label98.Size = size;
		this.lblShotTechnique.TabIndex = 45;
		this.lblShotTechnique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShotPower.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label99 = this.lblShotPower;
		location = new System.Drawing.Point(152, 264);
		label99.Location = location;
		this.lblShotPower.Name = "lblShotPower";
		System.Windows.Forms.Label label100 = this.lblShotPower;
		size = new System.Drawing.Size(24, 16);
		label100.Size = size;
		this.lblShotPower.TabIndex = 44;
		this.lblShotPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShotPrecision.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label101 = this.lblShotPrecision;
		location = new System.Drawing.Point(152, 248);
		label101.Location = location;
		this.lblShotPrecision.Name = "lblShotPrecision";
		System.Windows.Forms.Label label102 = this.lblShotPrecision;
		size = new System.Drawing.Size(24, 16);
		label102.Size = size;
		this.lblShotPrecision.TabIndex = 43;
		this.lblShotPrecision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblLongPassSpeed.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label103 = this.lblLongPassSpeed;
		location = new System.Drawing.Point(152, 232);
		label103.Location = location;
		this.lblLongPassSpeed.Name = "lblLongPassSpeed";
		System.Windows.Forms.Label label104 = this.lblLongPassSpeed;
		size = new System.Drawing.Size(24, 16);
		label104.Size = size;
		this.lblLongPassSpeed.TabIndex = 42;
		this.lblLongPassSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblLongPassPrecision.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label105 = this.lblLongPassPrecision;
		location = new System.Drawing.Point(152, 216);
		label105.Location = location;
		this.lblLongPassPrecision.Name = "lblLongPassPrecision";
		System.Windows.Forms.Label label106 = this.lblLongPassPrecision;
		size = new System.Drawing.Size(24, 16);
		label106.Size = size;
		this.lblLongPassPrecision.TabIndex = 41;
		this.lblLongPassPrecision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblSecondFootAccuracy.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label107 = this.lblSecondFootAccuracy;
		location = new System.Drawing.Point(152, 488);
		label107.Location = location;
		this.lblSecondFootAccuracy.Name = "lblSecondFootAccuracy";
		System.Windows.Forms.Label label108 = this.lblSecondFootAccuracy;
		size = new System.Drawing.Size(24, 16);
		label108.Size = size;
		this.lblSecondFootAccuracy.TabIndex = 57;
		this.lblSecondFootAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStabilityOfCondition.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label109 = this.lblStabilityOfCondition;
		location = new System.Drawing.Point(152, 456);
		label109.Location = location;
		this.lblStabilityOfCondition.Name = "lblStabilityOfCondition";
		System.Windows.Forms.Label label110 = this.lblStabilityOfCondition;
		size = new System.Drawing.Size(24, 16);
		label110.Size = size;
		this.lblStabilityOfCondition.TabIndex = 56;
		this.lblStabilityOfCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCooperation.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label111 = this.lblCooperation;
		location = new System.Drawing.Point(152, 424);
		label111.Location = location;
		this.lblCooperation.Name = "lblCooperation";
		System.Windows.Forms.Label label112 = this.lblCooperation;
		size = new System.Drawing.Size(24, 16);
		label112.Size = size;
		this.lblCooperation.TabIndex = 55;
		this.lblCooperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblGoalKeeperSkill.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label113 = this.lblGoalKeeperSkill;
		location = new System.Drawing.Point(152, 408);
		label113.Location = location;
		this.lblGoalKeeperSkill.Name = "lblGoalKeeperSkill";
		System.Windows.Forms.Label label114 = this.lblGoalKeeperSkill;
		size = new System.Drawing.Size(24, 16);
		label114.Size = size;
		this.lblGoalKeeperSkill.TabIndex = 54;
		this.lblGoalKeeperSkill.Text = "50";
		this.lblGoalKeeperSkill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStabilityOfPlay.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label115 = this.lblStabilityOfPlay;
		location = new System.Drawing.Point(152, 440);
		label115.Location = location;
		this.lblStabilityOfPlay.Name = "lblStabilityOfPlay";
		System.Windows.Forms.Label label116 = this.lblStabilityOfPlay;
		size = new System.Drawing.Size(24, 16);
		label116.Size = size;
		this.lblStabilityOfPlay.TabIndex = 53;
		this.lblStabilityOfPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblSecondFootFrequency.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label117 = this.lblSecondFootFrequency;
		location = new System.Drawing.Point(152, 472);
		label117.Location = location;
		this.lblSecondFootFrequency.Name = "lblSecondFootFrequency";
		System.Windows.Forms.Label label118 = this.lblSecondFootFrequency;
		size = new System.Drawing.Size(24, 16);
		label118.Size = size;
		this.lblSecondFootFrequency.TabIndex = 59;
		this.lblSecondFootFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblSecondFootFrequency2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label119 = this.lblSecondFootFrequency2;
		location = new System.Drawing.Point(16, 472);
		label119.Location = location;
		this.lblSecondFootFrequency2.Name = "lblSecondFootFrequency2";
		System.Windows.Forms.Label label120 = this.lblSecondFootFrequency2;
		size = new System.Drawing.Size(128, 16);
		label120.Size = size;
		this.lblSecondFootFrequency2.TabIndex = 58;
		this.lblSecondFootFrequency2.Text = "Second Foot Frequency";
		this.lblSecondFootFrequency2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblSliding.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label121 = this.lblSliding;
		location = new System.Drawing.Point(144, 296);
		label121.Location = location;
		this.lblSliding.Name = "lblSliding";
		System.Windows.Forms.Label label122 = this.lblSliding;
		size = new System.Drawing.Size(16, 16);
		label122.Size = size;
		this.lblSliding.TabIndex = 99;
		this.lblSliding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblBackLineControl.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label123 = this.lblBackLineControl;
		location = new System.Drawing.Point(144, 328);
		label123.Location = location;
		this.lblBackLineControl.Name = "lblBackLineControl";
		System.Windows.Forms.Label label124 = this.lblBackLineControl;
		size = new System.Drawing.Size(16, 16);
		label124.Size = size;
		this.lblBackLineControl.TabIndex = 98;
		this.lblBackLineControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblManMarking.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label125 = this.lblManMarking;
		location = new System.Drawing.Point(144, 280);
		label125.Location = location;
		this.lblManMarking.Name = "lblManMarking";
		System.Windows.Forms.Label label126 = this.lblManMarking;
		size = new System.Drawing.Size(16, 16);
		label126.Size = size;
		this.lblManMarking.TabIndex = 97;
		this.lblManMarking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblOutside.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label127 = this.lblOutside;
		location = new System.Drawing.Point(144, 264);
		label127.Location = location;
		this.lblOutside.Name = "lblOutside";
		System.Windows.Forms.Label label128 = this.lblOutside;
		size = new System.Drawing.Size(16, 16);
		label128.Size = size;
		this.lblOutside.TabIndex = 96;
		this.lblOutside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCentrePlayer.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label129 = this.lblCentrePlayer;
		location = new System.Drawing.Point(144, 216);
		label129.Location = location;
		this.lblCentrePlayer.Name = "lblCentrePlayer";
		System.Windows.Forms.Label label130 = this.lblCentrePlayer;
		size = new System.Drawing.Size(16, 16);
		label130.Size = size;
		this.lblCentrePlayer.TabIndex = 95;
		this.lblCentrePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblSidePlayer.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label131 = this.lblSidePlayer;
		location = new System.Drawing.Point(144, 200);
		label131.Location = location;
		this.lblSidePlayer.Name = "lblSidePlayer";
		System.Windows.Forms.Label label132 = this.lblSidePlayer;
		size = new System.Drawing.Size(16, 16);
		label132.Size = size;
		this.lblSidePlayer.TabIndex = 94;
		this.lblSidePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDirectPlay.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label133 = this.lblDirectPlay;
		location = new System.Drawing.Point(144, 248);
		label133.Location = location;
		this.lblDirectPlay.Name = "lblDirectPlay";
		System.Windows.Forms.Label label134 = this.lblDirectPlay;
		size = new System.Drawing.Size(16, 16);
		label134.Size = size;
		this.lblDirectPlay.TabIndex = 93;
		this.lblDirectPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblLongThrow.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label135 = this.lblLongThrow;
		location = new System.Drawing.Point(144, 344);
		label135.Location = location;
		this.lblLongThrow.Name = "lblLongThrow";
		System.Windows.Forms.Label label136 = this.lblLongThrow;
		size = new System.Drawing.Size(16, 16);
		label136.Size = size;
		this.lblLongThrow.TabIndex = 92;
		this.lblLongThrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShoot1On1.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label137 = this.lblShoot1On1;
		location = new System.Drawing.Point(144, 136);
		label137.Location = location;
		this.lblShoot1On1.Name = "lblShoot1On1";
		System.Windows.Forms.Label label138 = this.lblShoot1On1;
		size = new System.Drawing.Size(16, 16);
		label138.Size = size;
		this.lblShoot1On1.TabIndex = 91;
		this.lblShoot1On1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblPKKicker.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label139 = this.lblPKKicker;
		location = new System.Drawing.Point(144, 232);
		label139.Location = location;
		this.lblPKKicker.Name = "lblPKKicker";
		System.Windows.Forms.Label label140 = this.lblPKKicker;
		size = new System.Drawing.Size(16, 16);
		label140.Size = size;
		this.lblPKKicker.TabIndex = 90;
		this.lblPKKicker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCovering.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label141 = this.lblCovering;
		location = new System.Drawing.Point(144, 312);
		label141.Location = location;
		this.lblCovering.Name = "lblCovering";
		System.Windows.Forms.Label label142 = this.lblCovering;
		size = new System.Drawing.Size(16, 16);
		label142.Size = size;
		this.lblCovering.TabIndex = 89;
		this.lblCovering.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblPasser.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label143 = this.lblPasser;
		location = new System.Drawing.Point(144, 104);
		label143.Location = location;
		this.lblPasser.Name = "lblPasser";
		System.Windows.Forms.Label label144 = this.lblPasser;
		size = new System.Drawing.Size(16, 16);
		label144.Size = size;
		this.lblPasser.TabIndex = 88;
		this.lblPasser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCommander.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label145 = this.lblCommander;
		location = new System.Drawing.Point(144, 88);
		label145.Location = location;
		this.lblCommander.Name = "lblCommander";
		System.Windows.Forms.Label label146 = this.lblCommander;
		size = new System.Drawing.Size(16, 16);
		label146.Size = size;
		this.lblCommander.TabIndex = 87;
		this.lblCommander.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStriker.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label147 = this.lblStriker;
		location = new System.Drawing.Point(144, 120);
		label147.Location = location;
		this.lblStriker.Name = "lblStriker";
		System.Windows.Forms.Label label148 = this.lblStriker;
		size = new System.Drawing.Size(16, 16);
		label148.Size = size;
		this.lblStriker.TabIndex = 86;
		this.lblStriker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblLinePositioning.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label149 = this.lblLinePositioning;
		location = new System.Drawing.Point(144, 168);
		label149.Location = location;
		this.lblLinePositioning.Name = "lblLinePositioning";
		System.Windows.Forms.Label label150 = this.lblLinePositioning;
		size = new System.Drawing.Size(16, 16);
		label150.Size = size;
		this.lblLinePositioning.TabIndex = 85;
		this.lblLinePositioning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDashIn.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label151 = this.lblDashIn;
		location = new System.Drawing.Point(144, 72);
		label151.Location = location;
		this.lblDashIn.Name = "lblDashIn";
		System.Windows.Forms.Label label152 = this.lblDashIn;
		size = new System.Drawing.Size(16, 16);
		label152.Size = size;
		this.lblDashIn.TabIndex = 84;
		this.lblDashIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblPositioning.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label153 = this.lblPositioning;
		location = new System.Drawing.Point(144, 56);
		label153.Location = location;
		this.lblPositioning.Name = "lblPositioning";
		System.Windows.Forms.Label label154 = this.lblPositioning;
		size = new System.Drawing.Size(16, 16);
		label154.Size = size;
		this.lblPositioning.TabIndex = 83;
		this.lblPositioning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblHoldingUpTheBall.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label155 = this.lblHoldingUpTheBall;
		location = new System.Drawing.Point(144, 152);
		label155.Location = location;
		this.lblHoldingUpTheBall.Name = "lblHoldingUpTheBall";
		System.Windows.Forms.Label label156 = this.lblHoldingUpTheBall;
		size = new System.Drawing.Size(16, 16);
		label156.Size = size;
		this.lblHoldingUpTheBall.TabIndex = 82;
		this.lblHoldingUpTheBall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblKeepDribble.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label157 = this.lblKeepDribble;
		location = new System.Drawing.Point(144, 40);
		label157.Location = location;
		this.lblKeepDribble.Name = "lblKeepDribble";
		System.Windows.Forms.Label label158 = this.lblKeepDribble;
		size = new System.Drawing.Size(16, 16);
		label158.Size = size;
		this.lblKeepDribble.TabIndex = 81;
		this.lblKeepDribble.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDribbler.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label159 = this.lblDribbler;
		location = new System.Drawing.Point(144, 24);
		label159.Location = location;
		this.lblDribbler.Name = "lblDribbler";
		System.Windows.Forms.Label label160 = this.lblDribbler;
		size = new System.Drawing.Size(16, 16);
		label160.Size = size;
		this.lblDribbler.TabIndex = 80;
		this.lblDribbler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblLongThrow2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label161 = this.lblLongThrow2;
		location = new System.Drawing.Point(16, 344);
		label161.Location = location;
		this.lblLongThrow2.Name = "lblLongThrow2";
		System.Windows.Forms.Label label162 = this.lblLongThrow2;
		size = new System.Drawing.Size(120, 16);
		label162.Size = size;
		this.lblLongThrow2.TabIndex = 79;
		this.lblLongThrow2.Text = "Long Throw";
		this.lblLongThrow2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDirectPlay2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label163 = this.lblDirectPlay2;
		location = new System.Drawing.Point(16, 248);
		label163.Location = location;
		this.lblDirectPlay2.Name = "lblDirectPlay2";
		System.Windows.Forms.Label label164 = this.lblDirectPlay2;
		size = new System.Drawing.Size(120, 16);
		label164.Size = size;
		this.lblDirectPlay2.TabIndex = 78;
		this.lblDirectPlay2.Text = "Direct Play";
		this.lblDirectPlay2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblSidePlayer2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label165 = this.lblSidePlayer2;
		location = new System.Drawing.Point(16, 200);
		label165.Location = location;
		this.lblSidePlayer2.Name = "lblSidePlayer2";
		System.Windows.Forms.Label label166 = this.lblSidePlayer2;
		size = new System.Drawing.Size(120, 16);
		label166.Size = size;
		this.lblSidePlayer2.TabIndex = 77;
		this.lblSidePlayer2.Text = "Side Player";
		this.lblSidePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCentrePlayer2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label167 = this.lblCentrePlayer2;
		location = new System.Drawing.Point(16, 216);
		label167.Location = location;
		this.lblCentrePlayer2.Name = "lblCentrePlayer2";
		System.Windows.Forms.Label label168 = this.lblCentrePlayer2;
		size = new System.Drawing.Size(120, 16);
		label168.Size = size;
		this.lblCentrePlayer2.TabIndex = 76;
		this.lblCentrePlayer2.Text = "Centre Player";
		this.lblCentrePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblOutside2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label169 = this.lblOutside2;
		location = new System.Drawing.Point(16, 264);
		label169.Location = location;
		this.lblOutside2.Name = "lblOutside2";
		System.Windows.Forms.Label label170 = this.lblOutside2;
		size = new System.Drawing.Size(120, 16);
		label170.Size = size;
		this.lblOutside2.TabIndex = 75;
		this.lblOutside2.Text = "Outside";
		this.lblOutside2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblManMarking2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label171 = this.lblManMarking2;
		location = new System.Drawing.Point(16, 280);
		label171.Location = location;
		this.lblManMarking2.Name = "lblManMarking2";
		System.Windows.Forms.Label label172 = this.lblManMarking2;
		size = new System.Drawing.Size(120, 16);
		label172.Size = size;
		this.lblManMarking2.TabIndex = 74;
		this.lblManMarking2.Text = "Man-Marking";
		this.lblManMarking2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblBackLineControl2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label173 = this.lblBackLineControl2;
		location = new System.Drawing.Point(16, 328);
		label173.Location = location;
		this.lblBackLineControl2.Name = "lblBackLineControl2";
		System.Windows.Forms.Label label174 = this.lblBackLineControl2;
		size = new System.Drawing.Size(120, 16);
		label174.Size = size;
		this.lblBackLineControl2.TabIndex = 73;
		this.lblBackLineControl2.Text = "Back Line Control";
		this.lblBackLineControl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblSliding2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label175 = this.lblSliding2;
		location = new System.Drawing.Point(16, 296);
		label175.Location = location;
		this.lblSliding2.Name = "lblSliding2";
		System.Windows.Forms.Label label176 = this.lblSliding2;
		size = new System.Drawing.Size(120, 16);
		label176.Size = size;
		this.lblSliding2.TabIndex = 72;
		this.lblSliding2.Text = "Sliding";
		this.lblSliding2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblShoot1On12.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label177 = this.lblShoot1On12;
		location = new System.Drawing.Point(16, 136);
		label177.Location = location;
		this.lblShoot1On12.Name = "lblShoot1On12";
		System.Windows.Forms.Label label178 = this.lblShoot1On12;
		size = new System.Drawing.Size(120, 16);
		label178.Size = size;
		this.lblShoot1On12.TabIndex = 71;
		this.lblShoot1On12.Text = "Shoot 1 on 1";
		this.lblShoot1On12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblKeepDribble2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label179 = this.lblKeepDribble2;
		location = new System.Drawing.Point(16, 40);
		label179.Location = location;
		this.lblKeepDribble2.Name = "lblKeepDribble2";
		System.Windows.Forms.Label label180 = this.lblKeepDribble2;
		size = new System.Drawing.Size(120, 16);
		label180.Size = size;
		this.lblKeepDribble2.TabIndex = 70;
		this.lblKeepDribble2.Text = "Keep Dribble";
		this.lblKeepDribble2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblHoldingUpTheBall2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label181 = this.lblHoldingUpTheBall2;
		location = new System.Drawing.Point(16, 152);
		label181.Location = location;
		this.lblHoldingUpTheBall2.Name = "lblHoldingUpTheBall2";
		System.Windows.Forms.Label label182 = this.lblHoldingUpTheBall2;
		size = new System.Drawing.Size(120, 16);
		label182.Size = size;
		this.lblHoldingUpTheBall2.TabIndex = 69;
		this.lblHoldingUpTheBall2.Text = "Holding up the ball";
		this.lblHoldingUpTheBall2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblPositioning2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label183 = this.lblPositioning2;
		location = new System.Drawing.Point(16, 56);
		label183.Location = location;
		this.lblPositioning2.Name = "lblPositioning2";
		System.Windows.Forms.Label label184 = this.lblPositioning2;
		size = new System.Drawing.Size(120, 16);
		label184.Size = size;
		this.lblPositioning2.TabIndex = 68;
		this.lblPositioning2.Text = "Positioning";
		this.lblPositioning2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDashIn2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label185 = this.lblDashIn2;
		location = new System.Drawing.Point(16, 72);
		label185.Location = location;
		this.lblDashIn2.Name = "lblDashIn2";
		System.Windows.Forms.Label label186 = this.lblDashIn2;
		size = new System.Drawing.Size(120, 16);
		label186.Size = size;
		this.lblDashIn2.TabIndex = 67;
		this.lblDashIn2.Text = "Dash In";
		this.lblDashIn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblLinePositioning2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label187 = this.lblLinePositioning2;
		location = new System.Drawing.Point(16, 168);
		label187.Location = location;
		this.lblLinePositioning2.Name = "lblLinePositioning2";
		System.Windows.Forms.Label label188 = this.lblLinePositioning2;
		size = new System.Drawing.Size(120, 16);
		label188.Size = size;
		this.lblLinePositioning2.TabIndex = 66;
		this.lblLinePositioning2.Text = "Line Positioning";
		this.lblLinePositioning2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStriker2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label189 = this.lblStriker2;
		location = new System.Drawing.Point(16, 120);
		label189.Location = location;
		this.lblStriker2.Name = "lblStriker2";
		System.Windows.Forms.Label label190 = this.lblStriker2;
		size = new System.Drawing.Size(120, 16);
		label190.Size = size;
		this.lblStriker2.TabIndex = 65;
		this.lblStriker2.Text = "Striker";
		this.lblStriker2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCommander2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label191 = this.lblCommander2;
		location = new System.Drawing.Point(16, 88);
		label191.Location = location;
		this.lblCommander2.Name = "lblCommander2";
		System.Windows.Forms.Label label192 = this.lblCommander2;
		size = new System.Drawing.Size(120, 16);
		label192.Size = size;
		this.lblCommander2.TabIndex = 64;
		this.lblCommander2.Text = "Commander";
		this.lblCommander2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblPasser2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label193 = this.lblPasser2;
		location = new System.Drawing.Point(16, 104);
		label193.Location = location;
		this.lblPasser2.Name = "lblPasser2";
		System.Windows.Forms.Label label194 = this.lblPasser2;
		size = new System.Drawing.Size(120, 16);
		label194.Size = size;
		this.lblPasser2.TabIndex = 63;
		this.lblPasser2.Text = "Passer";
		this.lblPasser2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCovering2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label195 = this.lblCovering2;
		location = new System.Drawing.Point(16, 312);
		label195.Location = location;
		this.lblCovering2.Name = "lblCovering2";
		System.Windows.Forms.Label label196 = this.lblCovering2;
		size = new System.Drawing.Size(120, 16);
		label196.Size = size;
		this.lblCovering2.TabIndex = 62;
		this.lblCovering2.Text = "Covering";
		this.lblCovering2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblPKKicker2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label197 = this.lblPKKicker2;
		location = new System.Drawing.Point(16, 232);
		label197.Location = location;
		this.lblPKKicker2.Name = "lblPKKicker2";
		System.Windows.Forms.Label label198 = this.lblPKKicker2;
		size = new System.Drawing.Size(120, 16);
		label198.Size = size;
		this.lblPKKicker2.TabIndex = 61;
		this.lblPKKicker2.Text = "PK Kicker";
		this.lblPKKicker2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblDribbler2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label199 = this.lblDribbler2;
		location = new System.Drawing.Point(16, 24);
		label199.Location = location;
		this.lblDribbler2.Name = "lblDribbler2";
		System.Windows.Forms.Label label200 = this.lblDribbler2;
		size = new System.Drawing.Size(120, 16);
		label200.Size = size;
		this.lblDribbler2.TabIndex = 60;
		this.lblDribbler2.Text = "Dribbler";
		this.lblDribbler2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnClose.BackColor = System.Drawing.SystemColors.Control;
		System.Windows.Forms.Button button = this.btnClose;
		location = new System.Drawing.Point(264, 472);
		button.Location = location;
		this.btnClose.Name = "btnClose";
		System.Windows.Forms.Button button2 = this.btnClose;
		size = new System.Drawing.Size(72, 24);
		button2.Size = size;
		this.btnClose.TabIndex = 100;
		this.btnClose.Text = "Close";
		this.lblMiddleShot.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label201 = this.lblMiddleShot;
		location = new System.Drawing.Point(144, 184);
		label201.Location = location;
		this.lblMiddleShot.Name = "lblMiddleShot";
		System.Windows.Forms.Label label202 = this.lblMiddleShot;
		size = new System.Drawing.Size(16, 16);
		label202.Size = size;
		this.lblMiddleShot.TabIndex = 102;
		this.lblMiddleShot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblMiddleShot2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label203 = this.lblMiddleShot2;
		location = new System.Drawing.Point(16, 184);
		label203.Location = location;
		this.lblMiddleShot2.Name = "lblMiddleShot2";
		System.Windows.Forms.Label label204 = this.lblMiddleShot2;
		size = new System.Drawing.Size(120, 16);
		label204.Size = size;
		this.lblMiddleShot2.TabIndex = 101;
		this.lblMiddleShot2.Text = "Middle Shot";
		this.lblMiddleShot2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.grpSpecialAbilities.Controls.Add(this.lblStriker2);
		this.grpSpecialAbilities.Controls.Add(this.lblCommander2);
		this.grpSpecialAbilities.Controls.Add(this.lblPasser2);
		this.grpSpecialAbilities.Controls.Add(this.lblCovering2);
		this.grpSpecialAbilities.Controls.Add(this.lblPKKicker2);
		this.grpSpecialAbilities.Controls.Add(this.lblBackLineControl2);
		this.grpSpecialAbilities.Controls.Add(this.lblMiddleShot);
		this.grpSpecialAbilities.Controls.Add(this.lblMiddleShot2);
		this.grpSpecialAbilities.Controls.Add(this.lblDribbler2);
		this.grpSpecialAbilities.Controls.Add(this.lblKeepDribble);
		this.grpSpecialAbilities.Controls.Add(this.lblSliding);
		this.grpSpecialAbilities.Controls.Add(this.lblBackLineControl);
		this.grpSpecialAbilities.Controls.Add(this.lblManMarking);
		this.grpSpecialAbilities.Controls.Add(this.lblOutside);
		this.grpSpecialAbilities.Controls.Add(this.lblCentrePlayer);
		this.grpSpecialAbilities.Controls.Add(this.lblSidePlayer);
		this.grpSpecialAbilities.Controls.Add(this.lblDirectPlay);
		this.grpSpecialAbilities.Controls.Add(this.lblLongThrow);
		this.grpSpecialAbilities.Controls.Add(this.lblShoot1On1);
		this.grpSpecialAbilities.Controls.Add(this.lblPKKicker);
		this.grpSpecialAbilities.Controls.Add(this.lblCovering);
		this.grpSpecialAbilities.Controls.Add(this.lblPasser);
		this.grpSpecialAbilities.Controls.Add(this.lblCommander);
		this.grpSpecialAbilities.Controls.Add(this.lblStriker);
		this.grpSpecialAbilities.Controls.Add(this.lblLinePositioning);
		this.grpSpecialAbilities.Controls.Add(this.lblDashIn);
		this.grpSpecialAbilities.Controls.Add(this.lblPositioning);
		this.grpSpecialAbilities.Controls.Add(this.lblDribbler);
		this.grpSpecialAbilities.Controls.Add(this.lblLongThrow2);
		this.grpSpecialAbilities.Controls.Add(this.lblDirectPlay2);
		this.grpSpecialAbilities.Controls.Add(this.lblSidePlayer2);
		this.grpSpecialAbilities.Controls.Add(this.lblCentrePlayer2);
		this.grpSpecialAbilities.Controls.Add(this.lblOutside2);
		this.grpSpecialAbilities.Controls.Add(this.lblManMarking2);
		this.grpSpecialAbilities.Controls.Add(this.lblHoldingUpTheBall);
		this.grpSpecialAbilities.Controls.Add(this.lblSliding2);
		this.grpSpecialAbilities.Controls.Add(this.lblShoot1On12);
		this.grpSpecialAbilities.Controls.Add(this.lblKeepDribble2);
		this.grpSpecialAbilities.Controls.Add(this.lblHoldingUpTheBall2);
		this.grpSpecialAbilities.Controls.Add(this.lblPositioning2);
		this.grpSpecialAbilities.Controls.Add(this.lblDashIn2);
		this.grpSpecialAbilities.Controls.Add(this.lblLinePositioning2);
		System.Windows.Forms.GroupBox groupBox = this.grpSpecialAbilities;
		location = new System.Drawing.Point(208, 80);
		groupBox.Location = location;
		this.grpSpecialAbilities.Name = "grpSpecialAbilities";
		System.Windows.Forms.GroupBox groupBox2 = this.grpSpecialAbilities;
		size = new System.Drawing.Size(176, 368);
		groupBox2.Size = size;
		this.grpSpecialAbilities.TabIndex = 103;
		this.grpSpecialAbilities.TabStop = false;
		this.grpSpecialAbilities.Text = "Special Abilites";
		this.grpAbilities.Controls.Add(this.lblBodyBalance2);
		this.grpAbilities.Controls.Add(this.lblDefense2);
		this.grpAbilities.Controls.Add(this.lblLongPassPrecision2);
		this.grpAbilities.Controls.Add(this.lblLongPassSpeed2);
		this.grpAbilities.Controls.Add(this.lblShotPrecision2);
		this.grpAbilities.Controls.Add(this.lblShotPower2);
		this.grpAbilities.Controls.Add(this.lblShotTechnique2);
		this.grpAbilities.Controls.Add(this.lblFreeKickPrecision2);
		this.grpAbilities.Controls.Add(this.lblBend2);
		this.grpAbilities.Controls.Add(this.lblHeading2);
		this.grpAbilities.Controls.Add(this.lblJump2);
		this.grpAbilities.Controls.Add(this.lblTechnique2);
		this.grpAbilities.Controls.Add(this.lblShortPassSpeed2);
		this.grpAbilities.Controls.Add(this.lblAggressiveness2);
		this.grpAbilities.Controls.Add(this.lblMentality2);
		this.grpAbilities.Controls.Add(this.lblStabilityOfPlay2);
		this.grpAbilities.Controls.Add(this.lblGoalKeeperSkill2);
		this.grpAbilities.Controls.Add(this.lblCooperation2);
		this.grpAbilities.Controls.Add(this.lblStabilityOfCondition2);
		this.grpAbilities.Controls.Add(this.lblSecondFootAccuracy2);
		this.grpAbilities.Controls.Add(this.lblAttack);
		this.grpAbilities.Controls.Add(this.lblDefense);
		this.grpAbilities.Controls.Add(this.lblBodyBalance);
		this.grpAbilities.Controls.Add(this.lblAcceleration);
		this.grpAbilities.Controls.Add(this.lblTopSpeed);
		this.grpAbilities.Controls.Add(this.lblStamina);
		this.grpAbilities.Controls.Add(this.lblShortPassSpeed);
		this.grpAbilities.Controls.Add(this.lblShortPassPrecision);
		this.grpAbilities.Controls.Add(this.lblDribbleSpeed);
		this.grpAbilities.Controls.Add(this.lblDribblePrecision);
		this.grpAbilities.Controls.Add(this.lblAgility);
		this.grpAbilities.Controls.Add(this.lblResponse);
		this.grpAbilities.Controls.Add(this.lblMentality);
		this.grpAbilities.Controls.Add(this.lblAggressiveness);
		this.grpAbilities.Controls.Add(this.lblTechnique);
		this.grpAbilities.Controls.Add(this.lblJump);
		this.grpAbilities.Controls.Add(this.lblHeading);
		this.grpAbilities.Controls.Add(this.lblBend);
		this.grpAbilities.Controls.Add(this.lblFreeKickPrecision);
		this.grpAbilities.Controls.Add(this.lblShotTechnique);
		this.grpAbilities.Controls.Add(this.lblShotPower);
		this.grpAbilities.Controls.Add(this.lblShotPrecision);
		this.grpAbilities.Controls.Add(this.lblLongPassSpeed);
		this.grpAbilities.Controls.Add(this.lblLongPassPrecision);
		this.grpAbilities.Controls.Add(this.lblSecondFootAccuracy);
		this.grpAbilities.Controls.Add(this.lblStabilityOfCondition);
		this.grpAbilities.Controls.Add(this.lblCooperation);
		this.grpAbilities.Controls.Add(this.lblGoalKeeperSkill);
		this.grpAbilities.Controls.Add(this.lblStabilityOfPlay);
		this.grpAbilities.Controls.Add(this.lblSecondFootFrequency);
		this.grpAbilities.Controls.Add(this.lblSecondFootFrequency2);
		this.grpAbilities.Controls.Add(this.lblTopSpeed2);
		this.grpAbilities.Controls.Add(this.lblStamina2);
		this.grpAbilities.Controls.Add(this.lblAttack2);
		this.grpAbilities.Controls.Add(this.lblShortPassPrecision2);
		this.grpAbilities.Controls.Add(this.lblDribbleSpeed2);
		this.grpAbilities.Controls.Add(this.lblDribblePrecision2);
		this.grpAbilities.Controls.Add(this.lblAgility2);
		this.grpAbilities.Controls.Add(this.lblResponse2);
		this.grpAbilities.Controls.Add(this.lblAcceleration2);
		System.Windows.Forms.GroupBox groupBox3 = this.grpAbilities;
		location = new System.Drawing.Point(8, 8);
		groupBox3.Location = location;
		this.grpAbilities.Name = "grpAbilities";
		System.Windows.Forms.GroupBox groupBox4 = this.grpAbilities;
		size = new System.Drawing.Size(192, 512);
		groupBox4.Size = size;
		this.grpAbilities.TabIndex = 104;
		this.grpAbilities.TabStop = false;
		this.grpAbilities.Text = "Abilities";
		this.lblPosition2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label205 = this.lblPosition2;
		location = new System.Drawing.Point(16, 24);
		label205.Location = location;
		this.lblPosition2.Name = "lblPosition2";
		System.Windows.Forms.Label label206 = this.lblPosition2;
		size = new System.Drawing.Size(96, 16);
		label206.Size = size;
		this.lblPosition2.TabIndex = 105;
		this.lblPosition2.Text = "Position";
		this.lblPosition2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.GroupBox1.Controls.Add(this.lblPreferredFoot);
		this.GroupBox1.Controls.Add(this.lblPosition);
		this.GroupBox1.Controls.Add(this.lblPreferredFoot2);
		this.GroupBox1.Controls.Add(this.lblPosition2);
		System.Windows.Forms.GroupBox groupBox5 = this.GroupBox1;
		location = new System.Drawing.Point(208, 8);
		groupBox5.Location = location;
		this.GroupBox1.Name = "GroupBox1";
		System.Windows.Forms.GroupBox groupBox6 = this.GroupBox1;
		size = new System.Drawing.Size(176, 64);
		groupBox6.Size = size;
		this.GroupBox1.TabIndex = 106;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "Details";
		this.lblPreferredFoot2.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label207 = this.lblPreferredFoot2;
		location = new System.Drawing.Point(16, 40);
		label207.Location = location;
		this.lblPreferredFoot2.Name = "lblPreferredFoot2";
		System.Windows.Forms.Label label208 = this.lblPreferredFoot2;
		size = new System.Drawing.Size(96, 16);
		label208.Size = size;
		this.lblPreferredFoot2.TabIndex = 106;
		this.lblPreferredFoot2.Text = "Preferred Foot";
		this.lblPreferredFoot2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblPosition.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label209 = this.lblPosition;
		location = new System.Drawing.Point(120, 24);
		label209.Location = location;
		this.lblPosition.Name = "lblPosition";
		System.Windows.Forms.Label label210 = this.lblPosition;
		size = new System.Drawing.Size(48, 16);
		label210.Size = size;
		this.lblPosition.TabIndex = 107;
		this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblPreferredFoot.BackColor = System.Drawing.Color.Transparent;
		System.Windows.Forms.Label label211 = this.lblPreferredFoot;
		location = new System.Drawing.Point(120, 40);
		label211.Location = location;
		this.lblPreferredFoot.Name = "lblPreferredFoot";
		System.Windows.Forms.Label label212 = this.lblPreferredFoot;
		size = new System.Drawing.Size(48, 16);
		label212.Size = size;
		this.lblPreferredFoot.TabIndex = 108;
		this.lblPreferredFoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		size = new System.Drawing.Size(5, 14);
		this.AutoScaleBaseSize = size;
		this.BackColor = System.Drawing.Color.Gray;
		size = new System.Drawing.Size(394, 533);
		this.ClientSize = size;
		this.Controls.Add(this.GroupBox1);
		this.Controls.Add(this.grpAbilities);
		this.Controls.Add(this.grpSpecialAbilities);
		this.Controls.Add(this.btnClose);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		this.Name = "frmWEPES";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Verter - WE/PES Stats";
		this.grpSpecialAbilities.ResumeLayout(false);
		this.grpAbilities.ResumeLayout(false);
		this.GroupBox1.ResumeLayout(false);
		this.ResumeLayout(false);
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		lblAttack.Text = "";
		lblDefense.Text = "";
		lblBodyBalance.Text = "";
		lblAcceleration.Text = "";
		lblTopSpeed.Text = "";
		lblStamina.Text = "";
		lblShortPassSpeed.Text = "";
		lblShortPassPrecision.Text = "";
		lblDribbleSpeed.Text = "";
		lblDribblePrecision.Text = "";
		lblAgility.Text = "";
		lblResponse.Text = "";
		lblMentality.Text = "";
		lblAggressiveness.Text = "";
		lblTechnique.Text = "";
		lblJump.Text = "";
		lblHeading.Text = "";
		lblBend.Text = "";
		lblFreeKickPrecision.Text = "";
		lblShotTechnique.Text = "";
		lblShotPower.Text = "";
		lblShotPrecision.Text = "";
		lblLongPassSpeed.Text = "";
		lblLongPassPrecision.Text = "";
		lblSecondFootAccuracy.Text = "";
		lblStabilityOfCondition.Text = "";
		lblCooperation.Text = "";
		lblGoalKeeperSkill.Text = "50";
		lblStabilityOfPlay.Text = "";
		lblSecondFootFrequency.Text = "";
		lblSliding.Text = "";
		lblBackLineControl.Text = "";
		lblManMarking.Text = "";
		lblOutside.Text = "";
		lblCentrePlayer.Text = "";
		lblSidePlayer.Text = "";
		lblDirectPlay.Text = "";
		lblLongThrow.Text = "";
		lblShoot1On1.Text = "";
		lblPKKicker.Text = "";
		lblCovering.Text = "";
		lblPasser.Text = "";
		lblCommander.Text = "";
		lblStriker.Text = "";
		lblLinePositioning.Text = "";
		lblDashIn.Text = "";
		lblPositioning.Text = "";
		lblHoldingUpTheBall.Text = "";
		lblKeepDribble.Text = "";
		lblDribbler.Text = "";
		lblMiddleShot.Text = "";
		Hide();
	}
}
