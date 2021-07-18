using BroadageSportsWeb.Data;
using BroadageSportWeb.Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BroadageSportWeb.Controllers
{
    public class GetMatchAllListController : Controller

    {
        private readonly BroadageSportsContext _broadageSportsContext;
        public GetMatchAllListController(BroadageSportsContext broadageSportsContext)
        {
            _broadageSportsContext = broadageSportsContext;
        }
        public IActionResult Index()
        {
            List<Match> matchAllList = _broadageSportsContext.Matches.Include(x => x.HomeTeam).Include(x => x.AwayTeam).Include(x => x.Stage).Include(x => x.Status).Include(x => x.Round).Include(x => x.Tournament).ToList();

            return View(matchAllList);
        }
    }
}
