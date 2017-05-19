using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_exam_movie.Model.Entities
{
    public class MovieItem
    {
        public int MovieItemID{get;set;}
        public string MovieTitle{get;set;}
        public DateTime YearPublished{get;set;}
        public string Genre{get;set;}
        public string Director{get;set;}
        public TimeSpan MovieLength{get;set;}
        public string MoviePlot{get;set;}
        public int Rating{get;set;}

    }
}