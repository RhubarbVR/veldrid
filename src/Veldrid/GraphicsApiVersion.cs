
namespace Veldrid
{
    /// <summary>
    /// Graphics api version info
    /// </summary>
    public readonly struct GraphicsApiVersion
    {
        /// <summary>
        /// Graphics Unknown state static value
        /// </summary>
        public static GraphicsApiVersion Unknown => default;
        /// <summary>
        /// Major Version Number
        /// </summary>
        public int Major { get; }
        /// <summary>
        /// Minor Version Number
        /// </summary>
        public int Minor { get; }
        /// <summary>
        /// Subminor Version Number
        /// </summary>
        public int Subminor { get; }
        /// <summary>
        /// Patch Version Number
        /// </summary>
        public int Patch { get; }
        /// <summary>
        /// False if all of the vershion numbers are 0
        /// </summary>
        public bool IsKnown => Major != 0 && Minor != 0 && Subminor != 0 && Patch != 0;
        /// <summary>
        /// Graphics Api Version
        /// </summary>
        /// <param name="major">Major Version Number</param>
        /// <param name="minor">Minor Version Number</param>
        /// <param name="subminor">Subminor Version Number</param>
        /// <param name="patch">Patch Version Number</param>
        public GraphicsApiVersion(int major, int minor, int subminor, int patch)
        {
            Major = major;
            Minor = minor;
            Subminor = subminor;
            Patch = patch;
        }
        /// <summary>
        /// Creates vershion string as {Major}.{Minor}.{Subminor}.{Patch}
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Major}.{Minor}.{Subminor}.{Patch}";
        }

        /// <summary>
        /// Parses OpenGL version strings with either of following formats:
        /// <list type="bullet">
        ///   <item>
        ///     <description>major_number.minor_number</description>
        ///   </item>
        ///   <item>
        ///     <description>major_number.minor_number.release_number</description>
        ///   </item>
        /// </list>
        /// </summary>
        /// <param name="versionString">The OpenGL version string.</param>
        /// <param name="version">The parsed <see cref="GraphicsApiVersion"/>.</param>
        /// <returns>True whether the parse succeeded; otherwise false.</returns>
        public static bool TryParseGLVersion(string versionString, out GraphicsApiVersion version)
        {
            string[] versionParts = versionString.Split(' ')[0].Split('.');

            if (!int.TryParse(versionParts[0], out int major) ||
               !int.TryParse(versionParts[1], out int minor))
            {
                version = default;
                return false;
            }

            int releaseNumber = 0;
            if (versionParts.Length == 3)
            {
                if (!int.TryParse(versionParts[2], out releaseNumber))
                {
                    version = default;
                    return false;
                }
            }

            version = new GraphicsApiVersion(major, minor, 0, releaseNumber);
            return true;
        }
    }
}
