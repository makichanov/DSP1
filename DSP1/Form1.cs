using Microsoft.VisualBasic.FileIO;
using System.Runtime.InteropServices;

namespace DSP1
{
    public partial class Form1 : Form
    {
        private SignalGenerator signalGenerator = new SignalGenerator();
        private WavFileWriter wavFileWriter = new WavFileWriter();
        private uint wavFileSampling = 44100;
        private List<double[]> polyharmonicData = new List<double[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] data = new double[0];
            ModulationData modulationData = new ModulationData(ModulationType.NONE, new double[0]);
            bool success = false;

            if (AmpModulationRb.Checked)
            {
                double[] modulatingSignal = new double[0];

                success = GenerateSignal(out modulatingSignal, true, modulationData);

                modulationData.Data = modulatingSignal;
                modulationData.Type = ModulationType.AMPLITUDE;

                success &= GenerateSignal(out data, false, modulationData);
            }
            else if (freqModulationRb.Checked)
            {
                double[] modulatingSignal = new double[0];

                success = GenerateSignal(out modulatingSignal, true, modulationData);

                modulationData.Data = modulatingSignal;
                modulationData.Type = ModulationType.FREQUENCY;

                success &= GenerateSignal(out data, false, modulationData);
            }
            else
            {
                success = GenerateSignal(out data, false, modulationData);
            }

            if (success)
            {
                wavFileWriter.WriteFile("output.wav", wavFileSampling, data);
                MessageBox.Show("Wav file output.wav successfully created in project folder.");
            }
            else
            {
                MessageBox.Show("Unable to create wav file, there are unhandled errors.");
            }
        }

        private bool GenerateSignal(out double[] data, bool useModulatingFields, ModulationData modulationData) 
        {
            bool success;
            double[] result = new double[0];

            ComboBox operatingCb = useModulatingFields
                ? comboBox2
                : comboBox1;

            TextBox ampField = useModulatingFields
                ? amplitudeModulationField
                : amplitudeField;

            TextBox freqField = useModulatingFields
                ? frequencyModulationField
                : frequencyField;

            TextBox initPhaseField = useModulatingFields
                ? initPhaseModulationField
                : initialPhaseField;

            TextBox fillFactorField = useModulatingFields
                ? fillFactorModulationField
                : this.fillFactorField;

            switch (operatingCb.GetItemText(operatingCb.SelectedItem))
            {
                case "Sinusoid":
                    success = forSinusoid(out result, ampField, freqField, initPhaseField, modulationData);
                    break;

                case "Pulse":
                    success = forPulse(out result, ampField, freqField, initPhaseField, fillFactorField, modulationData);
                    break;

                case "Triangle":
                    success = forTriangle(out result, ampField, freqField, initPhaseField, modulationData);
                    break;

                case "Sawtooth":
                    success = forSawtooth(out result, ampField, freqField, initPhaseField, modulationData);
                    break;

                case "White noise":
                    success = forWhiteNoise(out result, ampField, modulationData);
                    break;

                default:
                    success = false;
                    break;
            }

            data = result;

            return success;
        }

        private bool forSinusoid(out double[] data, TextBox ampField, TextBox freqField, TextBox initPhaseField, ModulationData modulationData)
        {
            try
            {
                double amplitude = Double.Parse(ampField.Text);
                int frequencty = Int32.Parse(freqField.Text);
                double initialPhase = Double.Parse(initPhaseField.Text);
                int sampling = Int32.Parse(samplingField.Text);

                data = signalGenerator.GenerateSinusoid(amplitude, frequencty, initialPhase, sampling, 10, modulationData);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private bool forPulse(out double[] data, TextBox ampField, TextBox freqField, TextBox initPhaseField, TextBox fillFactorField, ModulationData modulationData)
        {
            try
            {
                double amplitude = Double.Parse(ampField.Text);
                int frequencty = Int32.Parse(freqField.Text);
                double initialPhase = Double.Parse(initPhaseField.Text);
                int sampling = Int32.Parse(samplingField.Text);
                double fillFactor = Double.Parse(fillFactorField.Text);

                data = signalGenerator.GeneratePulse(amplitude, frequencty, initialPhase, sampling, fillFactor, 10, modulationData);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private bool forTriangle(out double[] data, TextBox ampField, TextBox freqField, TextBox initPhaseField, ModulationData modulationData)
        {
            try
            {
                double amplitude = Double.Parse(ampField.Text);
                int frequencty = Int32.Parse(freqField.Text);
                double initialPhase = Double.Parse(initPhaseField.Text);
                int sampling = Int32.Parse(samplingField.Text);

                data = signalGenerator.GenerateTriangle(amplitude, frequencty, initialPhase, sampling, 10, modulationData);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private bool forSawtooth(out double[] data, TextBox ampField, TextBox freqField, TextBox initPhaseField, ModulationData modulationData)
        {
            try
            {
                double amplitude = Double.Parse(ampField.Text);
                int frequencty = Int32.Parse(freqField.Text);
                double initialPhase = Double.Parse(initPhaseField.Text);
                int sampling = Int32.Parse(samplingField.Text);

                data = signalGenerator.GenerateSawtooth(amplitude, frequencty, initialPhase, sampling, 10, modulationData);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private bool forWhiteNoise(out double[] data, TextBox ampField, ModulationData modulationData)
        {
            try
            {
                double amplitude = Double.Parse(ampField.Text);
                int sampling = Int32.Parse(samplingField.Text);

                data = signalGenerator.GenerateWhiteNoise(amplitude, sampling, 10, modulationData);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void samplingField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fillFactorModulationField_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPolyharm_Click(object sender, EventArgs e)
        {
            double[] data = new double[0];
            bool success = GenerateSignal(out data, false, new ModulationData(ModulationType.NONE, new double[0]));
            if (success)
            {
                polyharmonicData.Add(data);
                MessageBox.Show("Signal added");
            }
            else
            {
                MessageBox.Show("Failed to add signal");
            }
        }

        private void clearPolyharm_Click(object sender, EventArgs e)
        {
            polyharmonicData.Clear();
            MessageBox.Show("Cleared");
        }

        private void generatePolyharm_Click(object sender, EventArgs e)
        {
            if (polyharmonicData.Count == 0)
            {
                MessageBox.Show("Polyharmonic data list is empty");
                return;
            }

            int size = polyharmonicData[0].Length;
            for (int i = 1; i < polyharmonicData.Count; i++)
            {
                if (size > polyharmonicData[i].Length) size = polyharmonicData[i].Length;
            }

            double[] data = new double[size];

            for (int i = 0; i < size; i++)
            {
                foreach (double[] polyharmData in polyharmonicData)
                {
                    data[i] += polyharmData[i];
                }
            }
            wavFileWriter.WriteFile("output.wav", wavFileSampling, data);
            MessageBox.Show("Wav file output.wav successfully created in project folder.");
        }
    }
}