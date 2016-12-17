using System;
namespace InstagramCSharp.Core.Models
{
    [Obsolete("LocationInfo class is deprecated, please use Envelope<Location> instead.")]
    public class LocationInfo : Envelope<Location>
    {
    }
}
