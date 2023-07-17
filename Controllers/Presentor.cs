using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaketballGameSimulator2._0.Model;
using BaketballGameSimulator2._0.Views;


using Microsoft.EntityFrameworkCore.Internal;
using Org.BouncyCastle.Crypto;

namespace BaketballGameSimulator2._0.Controllers
{
    class Presentor
    {
       
        playersEntities context = new playersEntities();
        
        Iteamsinfo iteamsinfo;
        Iplayer_character iplayer_Character;
        Iparametars_table iparametars_Table;
        public Presentor(Iteamsinfo view)
        {
            iteamsinfo = view;

        }
        public Presentor() { }

        public Presentor(Iplayer_character view)
        {
            iplayer_Character = view;
        }

        public Presentor(Iparametars_table view)
        {
            iparametars_Table = view;
        }

        //*******************************CRUD for TeamOptions Menu***********************************//
        public void AddFunctionForTeamOptions()
        {
            using (context)
            {
                teamsinfo team = new teamsinfo
                {
                    Name = iteamsinfo.Name,
                    Location = iteamsinfo.Location,
                    Coach = iteamsinfo.Coach,
                    Manager = iteamsinfo.Manager,
                    Owner = iteamsinfo.Owner,
                    EstablishmentDate = int.Parse(iteamsinfo.EstablishmentDate),
                   
                };
                context.teamsinfo.Add(team);
                context.SaveChanges();
                MessageBox.Show("New team has succefully been created");
            }
        }
        public void RetrieveForTeamOptions(DataGridView dataGridView1)
        {
            
                List<teamsinfo> teams = new playersEntities().teamsinfo.ToList();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = teams;
            

        }

        public void DeleteForTeamOptions(int id)
        {
            using (context)
            {
                var query = context.teamsinfo.Where(s => s.Team_id == id).FirstOrDefault<teamsinfo>();
                if (MessageBox.Show("Are you sure ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    context.teamsinfo.Remove(query);
                    context.SaveChanges();
                    MessageBox.Show("The information was successfully deleted");
                }



            }
        }
        public void UpdateForTeamOptions(int id)
        {
            using (context)
            {
                teamsinfo Updateteam = context.teamsinfo.Where(s => s.Team_id == id).FirstOrDefault();


                Updateteam.Name = iteamsinfo.Name;
                Updateteam.Location = iteamsinfo.Location;
                Updateteam.Coach = iteamsinfo.Coach;
                Updateteam.Manager = iteamsinfo.Manager;
                Updateteam.Owner = iteamsinfo.Owner;
                Updateteam.EstablishmentDate = int.Parse(iteamsinfo.EstablishmentDate);
                
                context.SaveChanges();
                MessageBox.Show("The team was successfully updated");
            }
        }
        //*******************************CRUD for PlayerOptions Menu***********************************//
        public void AddFunctionForPlayerOptions()
        {
            using (context)
            {
                player_character player = new player_character
                {
                    Firstname = iplayer_Character.Firstname,
                    Lastname = iplayer_Character.Lastname,
                    Positon = iplayer_Character.Positon,
                    Team = iplayer_Character.Team,
                    DateOfBirth = DateTime.Parse(iplayer_Character.DateOfBirth),
                    DateOfDraft = DateTime.Parse(iplayer_Character.DateOfDraft),
                    DeclineDate = DateTime.Parse(iplayer_Character.DeclineDate),
                    RetireDate = DateTime.Parse(iplayer_Character.RetireDate),
                    DraftOverall = int.Parse(iplayer_Character.DraftOverall),
                    MaximumOverall = int.Parse(iplayer_Character.MaximumOverall),
                    DeclineFactor = double.Parse(iplayer_Character.DeclineFactor),
                    RaiseFactor = double.Parse(iplayer_Character.RaiseFactor),
                    EmotionalConst = double.Parse(iplayer_Character.EmotionalConst),
                    PhysicalConst = double.Parse(iplayer_Character.PhysicalConst),
                    IntellectualConst = double.Parse(iplayer_Character.IntellectualConst),
                    DailyStatus = double.Parse(iplayer_Character.DailyStatus),
                    PeakTimeDay = TimeSpan.Parse(iplayer_Character.PeakTimeDay)


                };
                
                context.player_character.Add(player);
                context.SaveChanges();
                MessageBox.Show("New player has succefully been created");
            }
        }
        public void DeleteForPlayerOptions(int id)
        {
            using (context)
            {
                var query = context.player_character.Where(s => s.Personal_id == id).FirstOrDefault<player_character>();
                if (MessageBox.Show("Are you sure ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    context.player_character.Remove(query);
                    context.SaveChanges();
                    MessageBox.Show("The information was successfully deleted");
                }

            }
        }
        public void RetrieveForPlayerOptions(DataGridView dataGridView1)
        {
            using (context)
            {
                List<player_character> player = context.player_character.ToList();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = player;
            }
        }

        public int RetrieveRestrictionsForPlayer(string parametar)
        {
            using (context)
            {
                int option = 0;
                parametars_table player = context.parametars_table.FirstOrDefault();
                if (parametar == "age")
                {
                    var blog = context.parametars_table.Select(s => s.MinimalAgeForDraft).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "minEff")
                {
                    var blog = context.parametars_table.Select(s => s.MinimalAllowedEfficiancy).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "maxEff")
                {
                    var blog = context.parametars_table.Select(s => s.MaximumAllowedEfficiancy).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "maxRaiseEff")
                {
                    var blog = context.parametars_table.Select(s => s.EfficiancyRaiseMaximum).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "minRaiseEff")
                {
                    var blog = context.parametars_table.Select(s => s.EfficiancyRaiseMinimum).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "maxDeclineEff")
                {
                    var blog = context.parametars_table.Select(s => s.EfficiancyDeclineMaximum).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "minDeclineEff")
                {
                    var blog = context.parametars_table.Select(s => s.EfficiancyDeclineMinimum).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "emotion")
                {
                    var blog = context.parametars_table.Select(s => s.EmotionalConst).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "intellect")
                {
                    var blog = context.parametars_table.Select(s => s.IntellectuallConst).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "physics")
                {
                    var blog = context.parametars_table.Select(s => s.PhysicalConst).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }
                if (parametar == "dailystatus")
                {
                    var blog = context.parametars_table.Select(s => s.DailyStatus).FirstOrDefault();
                    option = int.Parse(blog.ToString());
                }


                return option;
            }
            

        }

        public void UpdateForPlayerOptions(int id)
        {
            using (context)
            {
                player_character Updateplayer = context.player_character.Where(s => s.Personal_id == id).FirstOrDefault();


                Updateplayer.Firstname = iplayer_Character.Firstname;
                Updateplayer.Lastname = iplayer_Character.Lastname;
                Updateplayer.Positon = iplayer_Character.Positon;
                Updateplayer.Team = iplayer_Character.Team;
                Updateplayer.DateOfBirth = DateTime.Parse(iplayer_Character.DateOfBirth);
                Updateplayer.DateOfDraft = DateTime.Parse(iplayer_Character.DateOfDraft);
                Updateplayer.DeclineDate = DateTime.Parse(iplayer_Character.DeclineDate);
                Updateplayer.RetireDate = DateTime.Parse(iplayer_Character.RetireDate);
                Updateplayer.DraftOverall = int.Parse(iplayer_Character.DraftOverall);
                Updateplayer.MaximumOverall = int.Parse(iplayer_Character.MaximumOverall);
                Updateplayer.DeclineFactor = double.Parse(iplayer_Character.DeclineFactor);
                Updateplayer.RaiseFactor = double.Parse(iplayer_Character.RaiseFactor);
                Updateplayer.EmotionalConst = double.Parse(iplayer_Character.EmotionalConst);
                Updateplayer.PhysicalConst = double.Parse(iplayer_Character.PhysicalConst);
                Updateplayer.IntellectualConst = double.Parse(iplayer_Character.IntellectualConst);
                Updateplayer.DailyStatus = double.Parse(iplayer_Character.DailyStatus);
                Updateplayer.PeakTimeDay = TimeSpan.Parse(iplayer_Character.PeakTimeDay);
                context.SaveChanges();
                MessageBox.Show("The team was successfully updated");
            }
        }

        public void FilterMethod(string filter, DataGridView dataGridView1)
        {
            using (context)
            {
                List<player_character> playerSource = context.player_character.ToList();
                if (string.IsNullOrEmpty(filter))
                    dataGridView1.DataSource = playerSource;
                else
                {
                    var query = from o in context.player_character
                                where o.Firstname.Contains(filter) || o.Lastname.Contains(filter) || o.Positon.Contains(filter) || o.Team.Contains(filter)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
            }

        }
        public void FillingComboBox(ComboBox listOfPositionsComboBox, ComboBox listOfTeamsComboBox)
        {
            listOfPositionsComboBox.Items.Clear();
            listOfTeamsComboBox.Items.Clear();
            using (context)
            {

                List<teamsinfo> teamslist = context.teamsinfo.ToList();
                foreach (teamsinfo o in teamslist)
                {
                    listOfTeamsComboBox.Items.Add(o.Name);
                }

                List<position_of_players_table> positonlist = context.position_of_players_table.ToList();
                foreach (position_of_players_table o in positonlist)
                {
                    listOfPositionsComboBox.Items.Add(o.Position);
                }
            }

        }
        //*******************************CRUD for Parametars Menu***********************************//
        public void RetriveForParametarsSettings(DataGridView dataGridView1)
        {
            using (context)
            {
                List<parametars_table> settings = context.parametars_table.ToList();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = settings;
            }

        }
        public void UpdateForParametarsSettings(int id)
        {
            using (context)
            {
                parametars_table updateSettings = context.parametars_table.Where(s => s.Primary_id == id).FirstOrDefault();

                updateSettings.EfficiancyRaiseMinimum = int.Parse(iparametars_Table.EfficiancyRaiseMinimum);
                updateSettings.EfficiancyRaiseMaximum = int.Parse(iparametars_Table.EfficiancyRaiseMaximum);
                updateSettings.EfficiancyDeclineMinimum = int.Parse(iparametars_Table.EfficiancyDeclineMinimum);
                updateSettings.EfficiancyDeclineMaximum = int.Parse(iparametars_Table.EfficiancyDeclineMaximum);
                updateSettings.MinimalAgeForDraft = int.Parse(iparametars_Table.MinimalAgeForDraft);
                updateSettings.MinimalAllowedEfficiancy = int.Parse(iparametars_Table.MinimalAllowedEfficiancy);
                updateSettings.MaximumAllowedEfficiancy = int.Parse(iparametars_Table.MaximumAllowedEfficiancy);
                updateSettings.EmotionalConst = int.Parse(iparametars_Table.EmotionalConst);
                updateSettings.PhysicalConst = int.Parse(iparametars_Table.PhysicalConst);
                updateSettings.IntellectuallConst = int.Parse(iparametars_Table.IntellectuallConst);
                updateSettings.DailyStatus = int.Parse(iparametars_Table.DailyStatus);
                context.SaveChanges();
                MessageBox.Show("The changes were successfully applied");
            }
        }
        //******************************* Game Menu***********************************//
        public void FillingForGameComboBox(ComboBox listOfTeamsComboBox)
        {

            listOfTeamsComboBox.Items.Clear();
            using (context)
            {

                List<teamsinfo> teamslist = context.teamsinfo.ToList();
                foreach (teamsinfo o in teamslist)
                {
                    listOfTeamsComboBox.Items.Add(o.Name);
                }


            }

        }
        public void RetrieveForGameTableS(DataGridView dataGridView1, string team)
        {
            using (context)
            {
                List<player_character> player = context.player_character.Where(s => s.Team == team).ToList();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = player;
            }

        }
        public void RetriveCoach(TextBox coach, string team)
        {
            using (context)
            {
                teamsinfo player = context.teamsinfo.Where(s => s.Name == team).FirstOrDefault();
                coach.Text = player.Coach;
            }
        }
        public void UpdatePlayerEfficiancyForHost(DataGridView hostTeamDataGridView,DateTimePicker gameTimePicker1,
            Button gameButton,DateTimePicker gameTimePicker2,int countOfPlayers)
        {
           
            using (context)
            {
               
                var itemsToDelete = context.Set<game_table_host>();
                context.game_table_host.RemoveRange(itemsToDelete);
                var query = context.Database.ExecuteSqlCommand("ALTER TABLE game_table_host AUTO_INCREMENT = 1");
                context.SaveChanges();

                for (int id = 0; id < countOfPlayers; id++)
                {
                    string nameOfPlayer = hostTeamDataGridView.Rows[id].Cells[1].Value.ToString();
                    nameOfPlayer = nameOfPlayer + " " + hostTeamDataGridView.Rows[id].Cells[2].Value.ToString();
                    
                        game_table_host player = new game_table_host
                        {
                            Name= nameOfPlayer,
                            EfficiencyAtTheTime= GetPlayerEfficiency(hostTeamDataGridView, gameTimePicker1, gameButton, gameTimePicker2, id)

                        };
                        context.game_table_host.Add(player);
                        context.SaveChanges();                    
                    
                    
                }
            }
        }
        public void UpdatePlayerEfficiancyForGuest(DataGridView guestTeamDataGridView, DateTimePicker gameTimePicker1,
            Button gameButton, DateTimePicker gameTimePicker2, int countOfPlayers)
        {
            using (context)
            {
                var itemsToDelete = context.Set<game_table_guest>();
                context.game_table_guest.RemoveRange(itemsToDelete);
                context.SaveChanges();

                for (int id = 0; id < countOfPlayers; id++)
                {
                    string nameOfPlayer = guestTeamDataGridView.Rows[id].Cells[1].Value.ToString();
                    nameOfPlayer = nameOfPlayer + " " + guestTeamDataGridView.Rows[id].Cells[2].Value.ToString();

                    game_table_guest player = new game_table_guest
                    {
                        Name = nameOfPlayer,
                        EfficiencyAtTheTime = GetPlayerEfficiency(guestTeamDataGridView, gameTimePicker1, gameButton, gameTimePicker2, id)

                    };
                    context.game_table_guest.Add(player);
                    context.SaveChanges();


                }

            }


        }


        //******************************* The Player Efficiancy Function ***********************************//
        public double GetPlayerEfficiency(DataGridView dataGridViewForPlayer, DateTimePicker dateTimePicker1,
            Button calculateButton, DateTimePicker dateTimePickerHourAndMinutesOnly, int id)
        {
            bool flagActive = true;
            DateTime birthday = Convert.ToDateTime(dataGridViewForPlayer.Rows[id].Cells[5].Value.ToString());

            double pEfficiencyToDate = 0.0;

            DateTime draftdate = Convert.ToDateTime(dataGridViewForPlayer.Rows[id].Cells[6].Value.ToString());

            string declinedateInString = dataGridViewForPlayer.Rows[id].Cells[7].Value.ToString();
            DateTime declinedate = DateTime.Parse(declinedateInString);
            string retiredateInString = dataGridViewForPlayer.Rows[id].Cells[8].Value.ToString();
            DateTime retiredate = DateTime.Parse(retiredateInString);
            double draftoverall = float.Parse(dataGridViewForPlayer.Rows[id].Cells[9].Value.ToString());
            double maxoverall = float.Parse(dataGridViewForPlayer.Rows[id].Cells[10].Value.ToString());
            double declinefactor = float.Parse(dataGridViewForPlayer.Rows[id].Cells[11].Value.ToString());
            double raisefactor = float.Parse(dataGridViewForPlayer.Rows[id].Cells[12].Value.ToString());
            TimeSpan timeSpanPlaying = dateTimePicker1.Value - draftdate;
            double timeDifofPlaying = timeSpanPlaying.Days + 1;
            TimeSpan timeSpanPlayingDown = dateTimePicker1.Value - declinedate;
            double timeDifofPlayingDown = timeSpanPlayingDown.Days + 1;
            declinefactor = declinefactor / 365;
            raisefactor = raisefactor / 365;


            if (dateTimePicker1.Value > draftdate)
            {
                if (declinedateInString != "")
                {
                    if (dateTimePicker1.Value < declinedate)
                    {

                        pEfficiencyToDate = timeDifofPlaying * raisefactor + draftoverall;
                        if (pEfficiencyToDate > maxoverall)
                        {
                            pEfficiencyToDate = maxoverall;
                        }
                    }
                    else if (dateTimePicker1.Value > declinedate)
                    {
                        if (retiredateInString == "")
                        {
                            pEfficiencyToDate = timeDifofPlayingDown * declinefactor + maxoverall;
                            if (pEfficiencyToDate < draftoverall)
                            {
                                pEfficiencyToDate = draftoverall;
                            }
                        }
                        else
                        {
                            if (dateTimePicker1.Value < retiredate)
                            {
                                pEfficiencyToDate = timeDifofPlayingDown * declinefactor + maxoverall;
                                if (pEfficiencyToDate < draftoverall)
                                {
                                    pEfficiencyToDate = draftoverall;
                                }
                            }

                            else
                            {
                                flagActive = false;
                                //MessageBox.Show("The player is retied to date");

                            }
                        }


                    }

                }
                else
                {
                    pEfficiencyToDate = timeDifofPlaying * raisefactor + draftoverall;
                    if (pEfficiencyToDate > maxoverall)
                    {
                        pEfficiencyToDate = maxoverall;
                    }
                }
            }
            else
            {
                flagActive = false;
               // MessageBox.Show("The player is too young to delcare for draft");
                

            }



            double emothionalPeriod = 23;
            double physicalPeriod = 28;
            double intelectualPeriod = 33;


            TimeSpan timedifference = dateTimePicker1.Value - birthday;
            double timeChislo = timedifference.Days + 1;
            //daily status is not used
            string emotion = dataGridViewForPlayer.Rows[id].Cells[13].Value.ToString();
            string physicality = dataGridViewForPlayer.Rows[id].Cells[14].Value.ToString();
            string intelect = dataGridViewForPlayer.Rows[id].Cells[15].Value.ToString();
            string dailystatusString = dataGridViewForPlayer.Rows[id].Cells[16].Value.ToString();
            double dailystatus = double.Parse(dailystatusString);
            string peakdaytimeString = dataGridViewForPlayer.Rows[id].Cells[17].Value.ToString();
            string currentTimeString = dateTimePickerHourAndMinutesOnly.Value.ToString();
            DateTime peakdaytime = DateTime.Parse(peakdaytimeString);
            DateTime currentTime = DateTime.Parse(currentTimeString);
            double hourPeak = peakdaytime.Hour;
            double minutePeak = peakdaytime.Minute;
            double totalMinutesPeak = hourPeak * 60 + minutePeak;
            double currentHour = currentTime.Hour;
            double currentMinute = currentTime.Minute;
            double totalMinutesCurrent = currentHour * 60 + currentMinute;
            double emothionalconst = double.Parse(emotion);
            double physicconsatnt = double.Parse(physicality);
            double intellectualconst = double.Parse(intelect);

            double argument = ((totalMinutesPeak - totalMinutesCurrent) * Math.PI * 2) / 1440;
            double effiecencyEmotionalCorection = emothionalconst * Math.Sin((timeChislo % emothionalPeriod) / emothionalPeriod * Math.PI * 2);
            double effiecencyPhysicalCorection = physicconsatnt * Math.Sin((timeChislo % physicalPeriod) / physicalPeriod * Math.PI * 2);
            double effiecencyIntellectualCorection = intellectualconst * Math.Sin((timeChislo % intelectualPeriod) / intelectualPeriod * Math.PI * 2);
            double CorrectionEfficiency = dailystatus * Math.Cos(argument);

            double totalEfficiencBioCorrection = effiecencyEmotionalCorection + effiecencyIntellectualCorection + effiecencyPhysicalCorection + CorrectionEfficiency;

            pEfficiencyToDate += totalEfficiencBioCorrection;

            if (flagActive == true)
            {
                return pEfficiencyToDate;
            }
            else
            {
                return 0.0;
            }
        }

        //******************************* The Game Function ***********************************//

        public void GameFunction(TextBox resultOfGuestTexttBox, TextBox resultOfHostTextBox)
        {
            var teameffHost = new List<double>();
            var teameffGuest = new List<double>();
            using (context)
            {
                List<game_table_host> playerHostList = context.game_table_host.ToList();
                foreach (game_table_host o in playerHostList)
                {
                    var blog = o.EfficiencyAtTheTime;
                   double option = double.Parse(blog.ToString());
                    teameffHost.Add(option);
                   
                }
                List<game_table_guest> playerGuestList = context.game_table_guest.ToList();
                foreach (game_table_guest o in playerGuestList)
                {
                    //MessageBox.Show("id of guest players is " + o.Id.ToString());
                    var blog = o.EfficiencyAtTheTime;
                    double option = double.Parse(blog.ToString());
                    teameffGuest.Add(option);
                }
            }
            teameffHost.Sort();
            teameffHost.Reverse();
            teameffGuest.Sort();
            teameffGuest.Reverse();
            double constforstartes = 0;
            double constforbench = 0;
            double constEffForStarters = 2;
            double constEffForBench = 1;
            double constCryStarters = 1.5;
            double constCryBench = 1;
            double totalefGuest = 0.0;
            for (int i = 0; i < teameffGuest.Count; i++)
            {
                if (i != 5)
                {
                    totalefGuest = totalefGuest + (teameffGuest[i] * constEffForStarters);
                    constforstartes = constforstartes + constCryStarters;
                }
                else
                {
                    totalefGuest = totalefGuest + (teameffGuest[i] * constEffForBench);
                    constforbench = constforbench + constCryBench;
                }

            }
            // MessageBox.Show("TOTAL EF FO GUEST TEAM IS :" + totalefGuest.ToString());
            totalefGuest = totalefGuest / (constforstartes + constforbench)*1.4;
            totalefGuest = Math.Round(totalefGuest, 0);
            resultOfGuestTexttBox.Text = totalefGuest.ToString();


            double teameffHostTotal = 0.0;
            double constforstartesHOst = 0;
            double constforbenchHOst = 0;

            for (int i = 0; i < teameffHost.Count; i++)
            {
                if (i != 5)
                {
                    teameffHostTotal = teameffHostTotal + (teameffHost[i] * constEffForStarters);
                    constforstartesHOst = constforstartesHOst + constCryStarters;
                }
                else
                {
                    teameffHostTotal = teameffHostTotal + (teameffHost[i] * constEffForBench);
                    constforbenchHOst = constforbenchHOst + constCryBench;
                }

            }
            //MessageBox.Show("TOTAL EF FO Host TEAM IS :" + teameffHostTotal.ToString());\
            teameffHostTotal = teameffHostTotal / (constforbenchHOst + constforstartesHOst) * 1.4;
            teameffHostTotal = Math.Round(teameffHostTotal, 0);
            resultOfHostTextBox.Text = teameffHostTotal.ToString();


            
        }

    }
}
