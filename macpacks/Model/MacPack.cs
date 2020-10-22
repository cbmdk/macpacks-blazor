using System.Collections.Generic;

namespace macpacks.Model
{
     public class Versions    {
        public string stable { get; set; } 
        public object head { get; set; } 
        public bool bottle { get; set; } 
    }

    public class Stable    {
        public string url { get; set; } 
        public object tag { get; set; } 
        public object revision { get; set; } 
    }

    public class Urls    {
        public Stable stable { get; set; } 
    }

    public class Catalina    {
        public string url { get; set; } 
        public string sha256 { get; set; } 
    }

    public class Mojave    {
        public string url { get; set; } 
        public string sha256 { get; set; } 
    }

    public class HighSierra    {
        public string url { get; set; } 
        public string sha256 { get; set; } 
    }

    public class Sierra    {
        public string url { get; set; } 
        public string sha256 { get; set; } 
    }

    public class ElCapitan    {
        public string url { get; set; } 
        public string sha256 { get; set; } 
    }

    public class Files    {
        public Catalina catalina { get; set; } 
        public Mojave mojave { get; set; } 
        public HighSierra high_sierra { get; set; } 
        public Sierra sierra { get; set; } 
        public ElCapitan el_capitan { get; set; } 
    }

    public class Stable2    {
        public int rebuild { get; set; } 
        public string cellar { get; set; } 
        public string prefix { get; set; } 
        public string root_url { get; set; } 
        public Files files { get; set; } 
    }

    public class Bottle    {
        public Stable2 stable { get; set; } 
    }

    public class MacPack    {
        public string name { get; set; } 
        public string full_name { get; set; } 
        public object oldname { get; set; } 
        public List<object> aliases { get; set; } 
        public List<object> versioned_formulae { get; set; } 
        public string desc { get; set; } 
        public string license { get; set; } 
        public string homepage { get; set; } 
        public Versions versions { get; set; } 
        public Urls urls { get; set; } 
        public int revision { get; set; } 
        public int version_scheme { get; set; } 
        public Bottle bottle { get; set; } 
        public bool keg_only { get; set; } 
        public bool bottle_disabled { get; set; } 
        public List<object> options { get; set; } 
        public List<object> build_dependencies { get; set; } 
        public List<object> dependencies { get; set; } 
        public List<object> recommended_dependencies { get; set; } 
        public List<object> optional_dependencies { get; set; } 
        public List<object> uses_from_macos { get; set; } 
        public List<object> requirements { get; set; } 
        public List<object> conflicts_with { get; set; } 
        public object caveats { get; set; } 
        public List<object> installed { get; set; } 
        public object linked_keg { get; set; } 
        public bool pinned { get; set; } 
        public bool outdated { get; set; } 
        public bool deprecated { get; set; } 
        public bool disabled { get; set; } 
    }
}