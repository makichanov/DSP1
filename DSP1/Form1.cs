namespace DSP1
{
    public partial class Form1 : Form
    {

        private SignalGenerator signalGenerator = new SignalGenerator();
        private WavFileWriter wavFileWriter = new WavFileWriter();
        private uint wavFileSampling = 44100;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] data = new double[0];
            bool success;

            switch (comboBox1.GetItemText(comboBox1.SelectedItem))
            {
                case "Sinusoid":
                    success = forSinusoid(out data);
                    break;

                case "Pulse":
                    success = forPulse(out data);
                    break;

                case "Triangle":
                    success = forTriangle(out data);
                    break;

                case "Sawtooth":
                    success = forSawtooth(out data);
                    break;

                case "White noise":
                    success = forWhiteNoise(out data);
                    break;

                default:
                    success = false;
                    break;
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

        private bool forSinusoid(out double[] data)
        {
            try
            {
                int amplitude = Int32.Parse(amplitudeField.Text);
                int frequencty = Int32.Parse(frequencyField.Text);
                double initialPhase = Double.Parse(initialPhaseField.Text);
                int sampling = Int32.Parse(samplingField.Text);

                data = signalGenerator.GenerateSinusoid(amplitude, frequencty, initialPhase, sampling);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private bool forPulse(out double[] data)
        {
            try
            {
                int amplitude = Int32.Parse(amplitudeField.Text);
                int frequencty = Int32.Parse(frequencyField.Text);
                double initialPhase = Double.Parse(initialPhaseField.Text);
                int sampling = Int32.Parse(samplingField.Text);
                double fillFactor = Double.Parse(fillFactorField.Text);

                data = signalGenerator.GeneratePulse(amplitude, frequencty, initialPhase, sampling, fillFactor);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private bool forTriangle(out double[] data)
        {
            try
            {
                int amplitude = Int32.Parse(amplitudeField.Text);
                int frequencty = Int32.Parse(frequencyField.Text);
                double initialPhase = Double.Parse(initialPhaseField.Text);
                int sampling = Int32.Parse(samplingField.Text);

                data = signalGenerator.GenerateTriangle(amplitude, frequencty, initialPhase, sampling);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private bool forSawtooth(out double[] data)
        {
            try
            {
                int amplitude = Int32.Parse(amplitudeField.Text);
                int frequencty = Int32.Parse(frequencyField.Text);
                double initialPhase = Double.Parse(initialPhaseField.Text);
                int sampling = Int32.Parse(samplingField.Text);

                data = signalGenerator.GenerateSawtooth(amplitude, frequencty, initialPhase, sampling);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Input mismatch for one of the fields. Check input.");

                data = new double[0];

                return false;
            }
        }

        private bool forWhiteNoise(out double[] data)
        {
            try
            {
                int amplitude = Int32.Parse(amplitudeField.Text);
                int sampling = Int32.Parse(samplingField.Text);

                data = signalGenerator.GenerateWhiteNoise(amplitude, sampling);

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
    }
}