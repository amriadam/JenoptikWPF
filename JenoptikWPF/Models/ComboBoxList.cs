namespace JenoptikWPF.Models
{
    public static class ComboBoxList
    {
        public static IEnumerable<string> BeamShapeOptions { get; } = ["Gaussian", "V2"];
        public static IEnumerable<string> AssistGazOptions { get; } = ["Nitrogen", "CO2"];
        public static IEnumerable<string> MaterialOptions { get; } = ["Plastic", "Stainless Steal"];
    }
}
