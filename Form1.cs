using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

//Een autoverhuurbedrijf hanteert de volgende tarieven:
//  1) Voor personenauto’s: Per gereden kilometer een bedrag van € 0,20 
//      (voor elke dag dat de auto verhuurd is zijn de eerste 100 km vrij). Daarnaast een bedrag van € 50,= per dag.
//  2) Voor personenbusjes bedraagt de kilometerprijs € 0,30 en het dagtarief € 95,=.

//  De auto wordt uitgegeven met een volle tank benzine.Bij het inleveren van de auto wordt de tank weer volledig gevuld.
//  De te ontwikkelen software moet aan de hand van de verhuurgegevens het verschuldigde bedrag berekenen.
//  Het aantal dagen moet worden bepaald aan de hand van begin- en einddatum verhuurperiode.
//  Je mag er vanuit gaan dat elke maand 30 dagen telt. 
//  Bij het bepalen van de kosten moet onderweg getankte benzine ook betrokken worden.

namespace Autoverhuur
{
    public partial class Autoverhuur : Form
    {
        public Autoverhuur()
        {
            InitializeComponent();
        }

        decimal autoKilometerPrijs = 0.20m, autoDagPrijs = 50.00m; // zie tarieven hierboven > betreft prijzen voor huur auto
        decimal busKilometerPrijs = 0.30m, busDagPrijs = 95.00m; // zie tarieven hierboven > betreft prijzen voor huur bus
        decimal subtotaal, totaal, brandstof, tempKilometerPrijs, kilometerKorting, kilometerPrijs;
        int kilometers, startJaar, eindJaar, startMaand, eindMaand, startDag, eindDag, totaalDagen = 0;

        private void defaultState()
        {
            foreach (var cb in Controls.OfType<ComboBox>())
            {
                cb.SelectedIndex = 0;
            }

            textBoxTotaalPrijs.Text = "";
            textBoxKilometerInput.Text = "";
            textBoxFout.Text = "";
            textBoxFoutStartDatum.Text = "";
            textBoxFoutEindDatum.Text = "";
            textBoxBrandstofInput.Text = "";
            textBoxFoutEindDatum.Text = "";
            textBoxFoutStartDatum.Text = "";
            textBoxFoutEindDatum.BackColor = Color.LightGray;
            textBoxFoutStartDatum.BackColor = Color.LightGray;
            textBoxFout.BackColor = Color.LightGray;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            startJaar = Convert.ToInt16(comboBoxStartJaar.Text);
            eindJaar = Convert.ToInt16(comboBoxEindJaar.Text);
            startMaand = (Convert.ToInt16(comboBoxStartMaand.SelectedIndex)) + 1;
            eindMaand = (Convert.ToInt16(comboBoxEindMaand.SelectedIndex)) + 1;
            startDag = Convert.ToInt16(comboBoxStartDag.Text);
            eindDag = Convert.ToInt16(comboBoxEindDag.Text);

            if (startJaar == eindJaar && startMaand == eindMaand)
            {
                totaalDagen = (eindDag - startDag) + 1;
            }
            else if (startJaar == eindJaar && startMaand != eindMaand)
            {
                int subtotaalStartDag = 30 - startDag;
                int subtotaalEindDag = ((eindMaand - startMaand) * 30) - 30 + eindDag;
                totaalDagen = (subtotaalStartDag + subtotaalEindDag) + 1;
            }
            else if (startJaar < eindJaar)
            {
                int subtotaalJaren = eindJaar - startJaar;
                int subtotaalMaanden = (startMaand -1) * 30;
                totaalDagen = ((subtotaalJaren * 360) - (subtotaalMaanden) - startDag + eindDag + 1);
            }

            textBoxFout.Text = "";
            textBoxFoutEindDatum.Text = "";
            textBoxFoutStartDatum.Text = "";
            textBoxFoutEindDatum.BackColor = Color.LightGray;
            textBoxFoutStartDatum.BackColor = Color.LightGray;
            textBoxFout.BackColor = Color.LightGray;
            bool inputSucces = (Decimal.TryParse(textBoxBrandstofInput.Text, out brandstof)) && (int.TryParse(textBoxKilometerInput.Text, out kilometers));
            bool foutieveCombobox = startJaar > eindJaar || (startJaar == eindJaar && startMaand > eindMaand) || (startJaar == eindJaar && startMaand == eindMaand && startDag > eindDag);
            
            if (inputSucces)
            {
                if (foutieveCombobox != true)
                {
                    if (comboBoxAutoOfBus.Text == "Personenauto")
                    {
                        kilometerKorting = (totaalDagen * 100 * autoKilometerPrijs);
                        tempKilometerPrijs = (kilometers * autoKilometerPrijs);

                        if (kilometerKorting >= tempKilometerPrijs)
                        {
                            kilometerPrijs = 0.00m;
                        }
                        else
                        {
                            kilometerPrijs = tempKilometerPrijs - kilometerKorting;
                        }
                                                
                        subtotaal = kilometerPrijs + (totaalDagen * autoDagPrijs);
                        totaal = subtotaal + brandstof;
                        textBoxTotaalPrijs.Text = "De totaalprijs is " + totaal.ToString("C");
                    }
                    else if (comboBoxAutoOfBus.Text == "Personenbusje")
                    {
                        kilometerKorting = (totaalDagen * 100 * busKilometerPrijs);
                        tempKilometerPrijs = (kilometers * busKilometerPrijs);

                        if (kilometerKorting >= tempKilometerPrijs)
                        {
                            kilometerPrijs = 0.00m;
                        }
                        else
                        {
                            kilometerPrijs = tempKilometerPrijs - kilometerKorting;
                        }
                        subtotaal = kilometerPrijs + (totaalDagen * busDagPrijs);
                        totaal = subtotaal + brandstof;
                        textBoxTotaalPrijs.Text = "De totaalprijs is " + totaal.ToString("C");
                    }
                }
                else
                {
                    textBoxFout.BackColor = Color.MistyRose;
                    textBoxFout.Text = "foutieve invoer: einddatum ligt na startdatum";
                    textBoxFoutEindDatum.BackColor = Color.MistyRose;
                    textBoxFoutEindDatum.Text = "< <<  <<<";
                    textBoxFoutStartDatum.BackColor= Color.MistyRose;
                    textBoxFoutStartDatum.Text = "< <<  <<<";
                }
            }
            else
            {
                textBoxFout.BackColor = Color.MistyRose;
                textBoxFout.Text = "foutieve invoer: geef alleen hele kilometers op en geef een geldig bedrag op voor de getankte brandstof";
            }
        }

        private void Autoverhuur_Load(object sender, EventArgs e)
        {
            defaultState();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            defaultState();
        }
    }    
}