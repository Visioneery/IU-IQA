using System;

namespace UpscalingAndQualityAssessmentForm.Upscale
{
    public enum ModelEnum
    {
        EDSR,
        LapSRN,
        FSRCNN
    }

    public static class Model
    {
        public static T GetEnumFromString<T>(string inputString) where T : struct
        {
            // Check if T is an enum type
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enum type");
            }

            // Get all the enum values
            T[] enumValues = (T[])Enum.GetValues(typeof(T));

            // Iterate through the enum values and find a match with the input string
            foreach (T enumValue in enumValues)
            {
                if (inputString.Contains(enumValue.ToString()))
                {
                    return enumValue;
                }
            }

            return default(T);
        }
    }
}
