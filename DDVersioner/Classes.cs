using System.Collections.Generic;

public class VersionFile
{
    public IList<version> versions { get; set; }
    public VersionFile(IList<version> _versions)
    {
        this.versions = _versions;
    }
}
public class version
{
    public string title { get; set; }
    public metadata metadata { get; set; }
    public IList<content> contents { get; set; }
    public version(string _title, metadata _metadata, IList<content> _contents)
    {
        this.title = _title;
        this.metadata = _metadata;
        this.contents = _contents;
    }

    public override string ToString()
    {
        return this.title;
    }
}

public class metadata
{
    public string artwork_url { get; set; }
    public string description { get; set; }
    public metadata(string _artwork_url, string _description)
    {
        this.artwork_url = _artwork_url;
        this.description = _description;
    }

    public override string ToString()
    {
        return "Artwork: " + this.artwork_url + "\n-Description-\n" + this.description;
    }
}
public class content
{
    public string appId { get; set; }
    public string depotId { get; set; }
    public string manifestId { get; set; }
    public content(string _appId, string _depotId, string _manifestId)
    {
        this.appId = _appId;
        this.depotId = _depotId;
        this.manifestId = _manifestId;
    }

    public override string ToString()
    {
        return this.appId + ":" + this.depotId + ":" + this.manifestId;
    }
}