namespace Fractalizer.Common
{
    /// <summary>
    /// Basic static class which holds the application constants
    /// </summary>
    public static class FractalsConstants
    {
        public const int BitmapWidth = 400; // Move to form constants
        public const int BitmapHeight = 400;
        public const double XRange = 4.5;
        public const double YRange = 4.5;
        public const double StartValueX = -2.75;   // TODO : Find some kind of math dependency
        public const double StartValueY = -1.20;
        public const double StartOffsetX = 0.005;
        public const double StartOffsetY = 0.005;
        public const int MinIterations = 0;
        public const int DefaultIterations = 128;
        public const int MaxIterations = 5000;
        public const double RangeRadius = 2.0;
        public const int ColorsInterval = 100;

    }
}