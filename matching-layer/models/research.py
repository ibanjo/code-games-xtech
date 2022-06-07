class Research(object):
    def __init__(self, ResearchID, LanguageID, LanguageLevel, FEBEDevops, WebMobile, Technology, SkillLevel):
        self.ResearchID = ResearchID
        self.LanguageID = LanguageID
        self.LanguageLevel = LanguageLevel
        self.FEBEDevops = FEBEDevops
        self.WebMobile = WebMobile
        self.Technology = Technology
        self.SkillLevel = SkillLevel

    def __getitem__(self, item):
        return self[item]
