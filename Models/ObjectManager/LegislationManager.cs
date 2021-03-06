﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Politiq.Models.ObjectModel;
using Politiq.Models;
using System.Data.SqlTypes;
using Politiq.Helpers;
using System.Collections.ObjectModel;

namespace Politiq.Models.ObjectManager
{
    public class LegislationManager
    {
        DAL db = new DAL();

        public int Save(NewLegislationView legislation)
        {
            var currentSession = db.CommonsSessions.Where(p => p.Ending > DateTime.Now);
            
            if (currentSession.Any())
            {
                Legislation newLegislation = new Legislation();

                // Simple transfers
                newLegislation.ShortTile = legislation.ShortTile;
                newLegislation.LongTitle = legislation.LongTitle;
                newLegislation.BillType = legislation.BillType;
                newLegislation.OriginatingChamber = legislation.OriginatingChamber;
                newLegislation.Preamble = legislation.Preamble;
           
                // More complicated properties
                this.NumberBill(newLegislation); // Provides bill number
                newLegislation.Parliament = currentSession.First();
                newLegislation.Sponsor = db.Members.Single(m => m.Username == HttpContext.Current.User.Identity.Name);

                // Initialize its stage
                newLegislation.Stage = new Stage
                {
                    Reading = 0,
                    LastMovement = DateTime.Now
                };

                // Initialize new list of provisions
                newLegislation.Provisions = new Collection<Provision>();

                // And save
                db.Legislations.Add(newLegislation);
                db.SaveChanges();

                // Check for Short titles
                this.IncludeShortTitle(newLegislation);

                // return the saved legislation
                return newLegislation.LegislationID;
            }
            else
            {  
                return 0;
            }
        }

        public int Include(NewProvisionView article, int bill)
        {
            var legislation = db.Legislations.Find(bill);

            if (legislation != null)
            {
                try
                {
                    var provision = new Provision
                    {
                        Article = Numbers.CountOrNull(legislation.Provisions) + 1,
                        Text = article.Text,
                        Enactment = new Enactment
                        {
                            EnactmentType = 1,
                            EnactingOrder = null,
                            EnactingDate = DateTime.Parse(article.EnactingDate)
                        },
                        Proponent = db.Members.SingleOrDefault(m => m.Username == HttpContext.Current.User.Identity.Name)
                    };

                    legislation.Provisions.Add(provision);
                    db.SaveChanges();

                    return provision.ProvisionID;
                }
                catch (Exception)
                {     
                    return 0;
                }
            }
            else
            {
                return 0;
            } 
        }

        public void NumberBill(Legislation legislation)
        {
            switch (legislation.BillType)
            {
            case 1:
                    var currentPublicBills = db.Legislations.Where(l => l.BillType == 1 & l.Parliament.Ending > DateTime.Now);

                    legislation.BillNumber = Numbers.CountOrNull(currentPublicBills) + 1;
                    break;
            case 2:
                    var currentPrivateBills = db.Legislations.Where(l => l.BillType == 2 & l.Parliament.Ending > DateTime.Now);

                    legislation.BillNumber = Numbers.CountOrNull(currentPrivateBills) + 201;
                    break;
            }
        }

        public static string GenerateStyle(Legislation legislation)
        {
            string style_letter = (legislation.OriginatingChamber == 2) ? "S" : "C";  
            return style_letter + "-" + legislation.BillNumber.ToString();
        }

        public void IncludeShortTitle(Legislation legislation)
        {
            if (legislation.ShortTile.ToString().Length >= 5)
            {       
                string shortTitle = "This Act may be cited as the <i>" + legislation.ShortTile.ToString() + "</i>.";
                var provision = new Provision
                {
                    Article = Numbers.CountOrNull(legislation.Provisions) + 1,
                    Proponent = legislation.Sponsor,
                    Text = shortTitle,
                    Enactment = new Enactment
                    {
                        EnactingOrder = null,
                        EnactmentType = 1,
                        EnactingDate = DateTime.MaxValue
                    }
                };
                legislation.Provisions.Add(provision);
                db.SaveChanges();
            }
        }
    }
}