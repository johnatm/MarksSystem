using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace OOP2
{
    public partial class MainForm : Form
    {
        String curLevelID = "4";
        Entities db = new Entities();

        Dictionary<string, Nullable<int>> levelAverageMap = new Dictionary<string, Nullable<int>>();
        Dictionary<string, Dictionary<string, Nullable<int>>> levels = new Dictionary<string, Dictionary<string, Nullable<int>>>();

        Dictionary<string, ModuleControl> moduleControlMap = new Dictionary<string, ModuleControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            levels.Add("4", new Dictionary<string, int?>());
            levels.Add("5", new Dictionary<string, int?>());
            levels.Add("6", new Dictionary<string, int?>());
            calculateMarks();
            displayLevelAverage();
            calculateAward();
            cmbLevel.SelectedIndex = 0;
        }

        public void calculateMarks()
        {
                foreach (Level level in db.Levels)
                {
                    int levelMarks = 0, moduleCount = 0;
                    foreach (Module module in level.Modules)
                    {
                        double moduleMark = 0;
                        Boolean missingComponent = false;
                        foreach (Component component in module.Components)
                        {
                            if (!(component.Marks == null))
                            {
                                moduleMark += ((component.Weightage / 100.0) * (component.Marks ?? 0));
                            }
                            else
                            {
                                missingComponent = true;
                                break;
                            }
                        }

                        Dictionary<string, Nullable<int>> moduleMarksMap = null;
                        levels.TryGetValue(level.LevelID, out moduleMarksMap);

                        if (missingComponent)
                        {
                            moduleMarksMap.Add(module.ModuleID, null);
                        }
                        else
                        {
                            moduleMarksMap.Add(module.ModuleID, (Int32)moduleMark);
                            moduleCount++;
                        }
                        levelMarks += (Int32)moduleMark;

                    }

                    if (moduleCount != 0)
                    {
                        levelAverageMap.Add(level.LevelID, levelMarks / moduleCount);
                    }
                    else
                    {
                        levelAverageMap.Add(level.LevelID, null);
                    }

                }
        }

        public void displayModuleMarks()
        {
            foreach (var module in moduleControlMap)
            {
                Dictionary<string, Nullable<int>> moduleMarksMap = null;
                levels.TryGetValue(curLevelID, out moduleMarksMap);

                Nullable<int> marks = 30;
                moduleMarksMap.TryGetValue(module.Key, out marks);
                if (marks != null)
                {
                    module.Value.marks = marks.ToString();
                }
                else
                {
                    module.Value.marks = "Incomplete";
                }
            }
        }

        public void moduleChange(Module module)
        {
            Level level = module.Level;
            Dictionary<string, Nullable<int>> moduleMarksMap = null;
            levels.TryGetValue(level.LevelID, out moduleMarksMap);

            //Calculate marks for module
            double moduleMark = 0;
            Boolean missingComponent = false;
            foreach (Component component in module.Components)
            {
                if (!(component.Marks == null))
                {
                    moduleMark += (component.Weightage / 100.0) * (component.Marks ?? 0);
                }
                else
                {
                    missingComponent = true;
                    break;
                }
            }
            moduleMarksMap[module.ModuleID] = (Int32) moduleMark;
            moduleControlMap[module.ModuleID].marks = ((Int32)moduleMark).ToString();
            
            //Calculate marks for level
            if (!missingComponent)
            {
                int levelMarks = 0, moduleCount = 0;
                foreach (Module mod in level.Modules)
                {
                    Nullable<int> mark = null;
                    moduleMarksMap.TryGetValue(mod.ModuleID, out mark);
                    if (mark != null)
                    {
                        levelMarks += mark ?? 0;
                        moduleCount++;
                    }
                }
                levelAverageMap[level.LevelID] = levelMarks / moduleCount;
            }
            else
            {
                levelAverageMap[level.LevelID] = null;
            }

            displayLevelAverage();
            calculateAward();
        }


        public void displayLevelAverage()
        {
            Nullable<int> level4, level5, level6;
            levelAverageMap.TryGetValue("4", out level4);
            lblLevel4.Text = level4 != null ? level4.ToString() : "Pending";

            levelAverageMap.TryGetValue("5", out level5);
            lblLevel5.Text = level5 != null ? level5.ToString() : "Pending";

            levelAverageMap.TryGetValue("6", out level6);
            lblLevel6.Text = level6 != null ? level6.ToString() : "Pending";
        }


        public void calculateAward()
        {
            Nullable<int> level = null;
            for (int i = 4; i <= 6; i++)
            {
                levelAverageMap.TryGetValue(i.ToString(), out level);
                if (level == null)
                {
                    lblAward.Text = "Incomplete";
                    return;
                }
            }

            Dictionary<string, Nullable<int>> level5;
            levels.TryGetValue("5", out level5);
            var slevel5 = level5.OrderBy(mark => mark.Value);

            Dictionary<string, Nullable<int>> level6;
            levels.TryGetValue("5", out level6);
            var slevel6 = level6.OrderBy(mark => mark.Value);

            int creditSum = 0, bestCount = 0, nextBestCount = 0, bestTotal = 0, nextBestTotal = 0;

                //Best 105 credit modules
                while (creditSum < 105)
                {
                    var current = slevel6.Skip(bestCount).FirstOrDefault();
                    bestTotal += current.Value ?? 0;
                    creditSum += db.Modules.Find(current.Key).Credits ?? 0;
                    bestCount++;
                }

                creditSum = 0;
                //Next best 105 modules
                var nextBest = slevel6.Skip(bestCount).Union(slevel5).OrderBy(mark => mark.Value);
                while (creditSum < 105)
                {
                    var current = nextBest.Skip(nextBestCount).FirstOrDefault();
                    nextBestTotal += current.Value ?? 0;
                    creditSum += db.Modules.Find(current.Key).Credits ?? 0;
                    nextBestCount++;
                }

                int bestAvg = bestTotal / bestCount;
                int nextBestAvg = nextBestTotal / nextBestCount;


                if (bestAvg >= 70 && nextBestAvg >= 60)
                {
                    lblAward.Text = "First";
                }
                else if (bestAvg >= 60 && nextBestAvg >= 50)
                {
                    lblAward.Text = "Upper second";
                }
                else if (bestAvg >= 50 && nextBestAvg >= 40)
                {
                    lblAward.Text = "Lower second";
                }
                else
                {
                    var mergeLevel = slevel5.Union(slevel6).OrderBy(mark => mark.Value);
                    creditSum = 0;
                    int count = 0, total = 0;
                    while (creditSum < 210)
                    {
                        var current = nextBest.Skip(count).FirstOrDefault();
                        total += current.Value ?? 0;
                        creditSum += db.Modules.Find(current.Key).Credits ?? 0;
                        count++;
                    }

                    int avg = total / count;
                    if (avg >= 40)
                    {
                        lblAward.Text = "Third";
                    }
                    else
                    {
                        lblAward.Text = "Fail";
                    }

                }

        }


        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var level = from b in db.Modules where b.LevelID == "4" select b;
            switch (cmbLevel.SelectedIndex)
            {
                case 0:
                    level = from b in db.Modules where b.LevelID == "4" select b;
                    curLevelID = "4";
                    break;

                case 1:
                    level = from b in db.Modules where b.LevelID == "5" select b;
                    curLevelID = "5";
                    break;

                case 2:
                    level = from b in db.Modules where b.LevelID == "6" select b;
                    curLevelID = "6";
                    break;

            }

            panelModule.Controls.Clear();
            moduleControlMap = new Dictionary<string, ModuleControl>();

            foreach (Module module in level)
            {
                ModuleControl mdlc = new ModuleControl(module);
                moduleControlMap.Add(module.ModuleID, mdlc);
                panelModule.Controls.Add(mdlc);
                mdlc.childComponentChanged += new ModuleControl.ComponentChanged(moduleChange);
            }
            displayModuleMarks();
        }

        private void On_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("You have unsaved changes. Would you like to save them?", "Close", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                 db.SaveChanges();
            }
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            AddModuleForm addForm = new AddModuleForm(this);
            addForm.Show();
        }

        public void addModule(Module mod)
        {
            ModuleControl control = new ModuleControl(mod);
            panelModule.Controls.Add(control);
        }
    }
}
