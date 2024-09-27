using Gpx;
using System;
using System.Collections.Generic;
using System.IO;

namespace _323_matvelickov_rando
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            List<Trackpoint> list = new List<Trackpoint>
            {
                new Trackpoint(46.38370046345517, 7.625410038046539, 1423.1999816894531),
                new Trackpoint(46.38370046345517, 7.625410038046539, 1423.1999816894531),
                new Trackpoint(46.38370046345517, 7.625410038046539, 1423.1999816894531),
                new Trackpoint(46.38370046345517, 7.625410038046539, 1423.1999816894531),
                new Trackpoint(46.38370046345517, 7.625410038046539, 1423.1999816894531)
            };

            FileStream a = GpxReader();
            using (GpxReader reader = new GpxReader(input))
            {
                using (GpxWriter writer = new GpxWriter(output))
                {
                    while (reader.Read())
                    {
                        switch (reader.ObjectType)
                        {
                            case GpxObjectType.Metadata:
                                writer.WriteMetadata(reader.Metadata);
                                break;
                            case GpxObjectType.WayPoint:
                                writer.WriteWayPoint(reader.WayPoint);
                                break;
                            case GpxObjectType.Route:
                                writer.WriteRoute(reader.Route);
                                break;
                            case GpxObjectType.Track:
                                writer.WriteTrack(reader.Track);
                                break;
                        }
                    }
                }
            }
        }

        
    }
}
