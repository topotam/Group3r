﻿using Group3r.Options.AssessmentOptions;
using LibSnaffle.ActiveDirectory;

namespace Group3r.Assessment.Analysers
{
    public class DeviceAnalyser : Analyser
    {
        public DeviceSetting setting { get; set; }

        public override SettingResult Analyse(AssessmentOptions assessmentOptions)
        {
            // No 'finding' level issues in this area.

            SettingResult.Setting = setting;

            return SettingResult;
        }
    }
}
