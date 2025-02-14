﻿using Group3r.Options.AssessmentOptions;
using LibSnaffle.ActiveDirectory;

namespace Group3r.Assessment.Analysers
{
    public class IniFileAnalyser : Analyser
    {
        public IniFileSetting setting { get; set; }

        public override SettingResult Analyse(AssessmentOptions assessmentOptions)
        {
            /*
            List<GpoFinding> findings = new List<GpoFinding>();

            findings.Add(new GpoFinding()
            {
                //GpoSetting = setting,
                FindingReason = "IniFile analyser not implemented.",
                FindingDetail = "IniFile analyser not implemented.",
                Triage = Constants.Triage.Green
            });
            // put findings in settingResult
            SettingResult.Findings = findings;

            // make a new setting object minus the ugly bits we don't care about.
            SettingResult.Setting = new IniFileSetting();
            */
            SettingResult.Setting = setting;

            return SettingResult;
        }
    }
}