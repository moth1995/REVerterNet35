using System;
using System.Windows.Forms;

namespace Verter
{
    public partial class frmWEPES : Form
    {
	    public frmWEPES()
	    {
		    InitializeComponent();
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

        private void btnCopyStats_Click(object sender, EventArgs e)
        {
		    string foot = lblPreferredFoot.Text == "Right" || lblPreferredFoot.Text == "Either" ? "R" : "L";
		    string specialAbilitiesString = "";

		    if (!string.IsNullOrEmpty(lblDribbler.Text))
		    {
                specialAbilitiesString += "* Dribbling\n";
            }
            if (!string.IsNullOrEmpty(lblKeepDribble.Text))
            {
                specialAbilitiesString += "* Tactical dribble\n";
            }
            if (!string.IsNullOrEmpty(lblPositioning.Text))
            {
                specialAbilitiesString += "* Positioning\n";
            }
            if (!string.IsNullOrEmpty(lblDashIn.Text))
            {
                specialAbilitiesString += "* Reaction\n";
            }
            if (!string.IsNullOrEmpty(lblCommander.Text))
            {
                specialAbilitiesString += "* Playmaking\n";
            }
            if (!string.IsNullOrEmpty(lblPasser.Text))
            {
                specialAbilitiesString += "* Passing\n";
            }
            if (!string.IsNullOrEmpty(lblStriker.Text))
            {
                specialAbilitiesString += "* Scoring\n";
            }
            if (!string.IsNullOrEmpty(lblShoot1On1.Text))
            {
                specialAbilitiesString += "* 1-1 Scoring\n";
            }
            if (!string.IsNullOrEmpty(lblHoldingUpTheBall.Text))
            {
                specialAbilitiesString += "* Post player\n";
            }
            if (!string.IsNullOrEmpty(lblLinePositioning.Text))
            {
                specialAbilitiesString += "* Lines\n";
            }
            if (!string.IsNullOrEmpty(lblMiddleShot.Text))
            {
                specialAbilitiesString += "* Middle shooting\n";
            }
            if (!string.IsNullOrEmpty(lblSidePlayer.Text))
            {
                specialAbilitiesString += "* Side\n";
            }
            if (!string.IsNullOrEmpty(lblCentrePlayer.Text))
            {
                specialAbilitiesString += "* Centre\n";
            }
            if (!string.IsNullOrEmpty(lblPKKicker.Text))
            {
                specialAbilitiesString += "* Penalties\n";
            }
            if (!string.IsNullOrEmpty(lblDirectPlay.Text))
            {
                specialAbilitiesString += "* 1-Touch pass\n";
            }
            if (!string.IsNullOrEmpty(lblOutside.Text))
            {
                specialAbilitiesString += "* Outside\n";
            }
            if (!string.IsNullOrEmpty(lblManMarking.Text))
            {
                specialAbilitiesString += "* Marking\n";
            }
            if (!string.IsNullOrEmpty(lblSliding.Text))
            {
                specialAbilitiesString += "* Sliding\n";
            }
            if (!string.IsNullOrEmpty(lblCovering.Text))
            {
                specialAbilitiesString += "* Covering\n";
            }
            if (!string.IsNullOrEmpty(lblBackLineControl.Text))
            {
                specialAbilitiesString += "* D-Line control\n";
            }
            if (!string.IsNullOrEmpty(lblLongThrow.Text))
            {
                specialAbilitiesString += "* Long throw\n";
            }

            string position = lblPosition.Text == "ST/CF" ? "CF" : lblPosition.Text;
            string s = $@"Foot: {foot}
Positions: {position}*

STATS:
Attack: {lblAttack.Text}
Defence: {lblDefense.Text}
Balance: {lblBodyBalance.Text}
Stamina: {lblStamina.Text}
Top Speed: {lblTopSpeed.Text}
Acceleration: {lblAcceleration.Text}
Response: {lblResponse.Text}
Agility: {lblAgility.Text}
Dribble Accuracy: {lblDribblePrecision.Text}
Dribble Speed: {lblDribbleSpeed.Text}
Short Pass Accuracy: {lblShortPassPrecision.Text}
Short Pass Speed: {lblShortPassSpeed.Text}
Long Pass Accuracy: {lblLongPassPrecision.Text}
Long Pass Speed: {lblLongPassSpeed.Text}
Shot Accuracy: {lblShotPrecision.Text}
Shot Power: {lblShotPower.Text}
Shot Technique: {lblShotTechnique.Text}
Free Kick Accuracy: {lblFreeKickPrecision.Text}
Curling: {lblBend.Text}
Header: {lblHeading.Text}
Jump: {lblJump.Text}
Technique: {lblTechnique.Text}
Aggression: {lblAggressiveness.Text}
Mentality: {lblMentality.Text}
Keeper Skills: {lblGoalKeeperSkill.Text}
Teamwork: {lblCooperation.Text}
Consistency: {lblStabilityOfPlay.Text}
Condition/Fitness: {lblStabilityOfCondition.Text}
Weak Foot Accuracy: {lblSecondFootAccuracy.Text}
Weak Foot Frequency: {lblSecondFootFrequency.Text}

SPECIAL ABILITIES:
{specialAbilitiesString}";

            Clipboard.SetText(s);
        
		    MessageBox.Show("Stats copied correctly!", "Verter - WE/PES Stats");
        }
    }
}
