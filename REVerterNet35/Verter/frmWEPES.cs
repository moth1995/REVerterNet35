using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace REVerterNet35.Verter
{
    public partial class frmWEPES : Form
    {
        public string PlayerName { get; set; }
	    public frmWEPES()
	    {
		    InitializeComponent();
            PlayerName = "";
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

            string s = $@"Name: {PlayerName}
Shirt Name: {NameToShirtName(PlayerName)}
Foot: {foot}
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
        public string NameToShirtName(string name)
        {
            string[] nameParts = name.Split(' ');
            string lastName = nameParts[nameParts.Length - 1].ToUpper();

            Dictionary<char, char> translationMap = new Dictionary<char, char>
            {
                {'Á', 'A'},
                {'À', 'A'},
                {'Â', 'A'},
                {'Ä', 'A'},
                {'Ã', 'A'},
                {'É', 'E'},
                {'È', 'E'},
                {'Ê', 'E'},
                {'Ë', 'E'},
                {'Í', 'I'},
                {'Ì', 'I'},
                {'Î', 'I'},
                {'Ï', 'I'},
                {'Ó', 'O'},
                {'Ò', 'O'},
                {'Ô', 'O'},
                {'Ö', 'O'},
                {'Õ', 'O'},
                {'Ú', 'U'},
                {'Ù', 'U'},
                {'Û', 'U'},
                {'Ü', 'U'},
                {'Ñ', 'N'},
                {'Ç', 'C'},
                {'Ć', 'C'},
                {'Å', 'A'}
            };

            char[] translatedChars = new char[lastName.Length];
            for (int i = 0; i < lastName.Length; i++)
            {
                char c = lastName[i];
                translatedChars[i] = translationMap.ContainsKey(c) ? translationMap[c] : c;
            }

            string translatedLastName = new string(translatedChars);

            if (translatedLastName.Length > 16)
            {
                translatedLastName = translatedLastName.Substring(0, 15);
            }
            else if (translatedLastName.Length < 5)
            {
                string[] charArrayToStringArray = new string[translatedLastName.Length];
                for (int i = 0; i < translatedLastName.Length; i++)
                {
                    charArrayToStringArray[i] = translatedLastName[i].ToString();
                }
                translatedLastName = string.Join("  ", charArrayToStringArray);
            }
            else if (translatedLastName.Length < 9)
            {
                string[] charArrayToStringArray = new string[translatedLastName.Length];
                for (int i = 0; i < translatedLastName.Length; i++)
                {
                    charArrayToStringArray[i] = translatedLastName[i].ToString();
                }
                translatedLastName = string.Join(" ", charArrayToStringArray);
            }

            return translatedLastName;
        }
    }
}
