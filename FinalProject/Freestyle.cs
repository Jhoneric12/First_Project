using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Freestyle
    {
        string choice { get; set; }
        string choice1 { get; set; }
        fonts f = new fonts();

        public void galactechApp()
        {

            //do
           // {
            start:
                Console.Clear();
                f.thirtyeight();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t                                                                                      ________________________________________________________ ");
                Console.WriteLine("\t\t\t\t\t                                                                                     |                                                        |");
                Console.WriteLine("\t\t\t\t\t                                                                                     |________________________________________________________|");
                Console.WriteLine("\t\t\t\t\t=====================================================================================|                                                        |");
                Console.WriteLine("\t\t\t\t\t|     CODE                   CONTENTS                                   CODE         |                                                        |");
                Console.WriteLine("\t\t\t\t\t=====================================================================================|                                                        |");
                Console.WriteLine("\t\t\t\t\t|      1                   URS VISION                                    1           |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      2                   URS MISSION                                   2           |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      3                   URS CORE VALUES                               3           |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      4                   URS HISTORY                                   4           |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      5                   CCS GOALS                                     5           |                    PROF. ALKING SUNGA                  |");
                Console.WriteLine("\t\t\t\t\t|      6                   CCS HISTORY                                   6           |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      7                   CCS LOGO                                      7           |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      8                   BSIT PROGRAM DESCRIPTION                      8           |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      9                   BSIT OBJECTIVES                               9           |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      10                  BSIS PROGRAM DESCRIPTION                      10          |                                                        |");
                Console.WriteLine("\t\t\t\t\t|      11                  BSIS OBJECTIVES                               11          |                                                        |");
                Console.WriteLine("\t\t\t\t\t|____________________________________________________________________________________|________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  ENTER CODE    :    ");
                choice = Console.ReadLine();

                if (choice.Equals("1", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("urs vision", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.thirtyseven();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t   >>    THE LEADING UNIVERSITY IN HUMAN RESOURCE DEVELOPMENT ");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t         KNOWLEDGE AND TECHNOLOGY GENERATION AND ENVIRONMENTAL");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t         STEWARDSHIP.");
                }
                else if (choice.Equals("2", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("urs mission", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.thirtynine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t   >>    THE UNIVERSITY OF RIZAL SYSTEM IS COMMITED TO NURTURE AND PRODUCE UPRIGHT AND");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         COMPETENT GRADUATES AND EMPOWERED COMMUNITY THROUGH RELEVANT AND SUSTAINABLE HIGHER");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         PROFESSIONAL AND TECHNICAL INSTRUCTIONS, RESEARCH, EXTENSION, AND PRODUCTION SERVICES");
                }
                else if (choice.Equals("3", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("urs core values", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthy();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t   >>    R  -  RESPONSIVENESS");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t   >>    I  -  INTEGRITY");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t   >>    S  -  SERVICES");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t   >>    E  -  EXCELLENCE");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t   >>    S  -  SOCIAL RESPONSIBILITY");
                }
                else if (choice.Equals("4", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("urs history", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthyone();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t   >>    THE UNIVERSITY OF RIZAL SYSTEM IS A MERGER OF TWO (2) STATE COLLEGES AND A UNIVERSITY EXTENSION");
                    Console.WriteLine("\t\t\t\t\t\t      CAMPUS - THE RIZAL STATE COLLEGE, AND THE RIZAL TECHNOLOGICAL UNIVERSITY EXTENSION CAMPUS. THE REPUBLIC");
                    Console.WriteLine("\t\t\t\t\t\t      ACT 9157 LAPSED INTO LAW ON AUGUST 11, 2001, ESTABLISHED AS A STATE UNIVERSITY IN THE PROVINCE OF RIZAL");
                    Console.WriteLine("\t\t\t\t\t\t      TO BE KNOWN AS THE UNIVERSITY OF RIZAL SYSTEM, BY INTEGRATING THE RIZAL STATE COLLEGE AND ITS EXTENSION");
                    Console.WriteLine("\t\t\t\t\t\t      CAMPUSES IN ANGONO, BINANGONAN, PILILLA, AND RODRIQUEZ, THE RIZAL POLYTECHNIC COLLEGE AND ITS EXTENSION");
                    Console.WriteLine("\t\t\t\t\t\t      CAMPUS IN CAINTA AND RIZAL TECHNOLOGICAL UNIVERSITY - ANTIPOLO ANNEX, ALL IN THE PROVINCE OF RIZAL. ON");
                    Console.WriteLine("\t\t\t\t\t\t      JUNE 18, 2002, CHED RESOLUTION NO. 411 - 4004 WAS ISSUED IDENTIFYING TANAY CAMPUS AS THE MAIN CAMPUS OF");
                    Console.WriteLine("\t\t\t\t\t\t      THE UNIVERSITY.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t   >>    THE RIZAL NATIONAL AGRICULTURAL SCHOOL (RNAS) WAS ESTABLISHED BY REPUBLIC ACT NO. 1560 AUTHORED BY CONG");
                    Console.WriteLine("\t\t\t\t\t\t      SERAFIN SALVADOR, WHICH WAS APPROVED ON JUNE 16, 1956. RNAS WAS OPENED ON MAY 27, 1959. IT WAS CHARTERED AS");
                    Console.WriteLine("\t\t\t\t\t\t      A STATE COLLEGE ON JUNE 24, 1983 BY BATAS PAMBANSANG BILANG 622 AUTHORED BY ASSEMBLYMAN FRISCO F. SAN JUAN");
                    Console.WriteLine("\t\t\t\t\t\t      MAKING IT A FIRST STATE COLLEGE IN THE PROVINCE OF RIZAL KNOWN AS THE COLLEGE OF AGRICULTURE AND TECHNOLOGY");
                    Console.WriteLine("\t\t\t\t\t\t      (RCAT). RCAT WAS LATER RENAMED RIZAL STATE COLLEGE (RSC) BY VIRUTE OF REPUBLIC ACT 7858 SPONSORED BY HON. CONGRESSMAN");
                    Console.WriteLine("\t\t\t\t\t\t      EMIGDIO S. TANJUATCO JR. AND APPROVED  BY HIS EXCELLENCY FIDEL V. RAMOS ON JANUARY 21, 1995.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t   >>    RIZAL POLYTECHNIC COLLEGE WAS FIRST ESTABLISHED AS MORONG HIGH SCHOOL AUGUST 16, 1944. IT WAS CONVERTED");
                    Console.WriteLine("\t\t\t\t\t\t      INTO MORONG NATIONAL HIGH SCHOOL ON AUGUST 20, 1976 AND TO MORONG NATIONAL COMPREHENSIVE SCHOOL ON MARCH 30");
                    Console.WriteLine("\t\t\t\t\t\t      1977. WITH THE INTEGRATION OF TOMAS CLAUDIO MEMORIAL ELEMENTARY SCHOOL, IT WAS CONVERTED INTO MORONG NATIONAL");
                    Console.WriteLine("\t\t\t\t\t\t      COMPREHENSIVE SCHOOL , LATER  RENAMED RIZAL TECHNOLOGICAL AND POLYTECHNIC INSTITUTE ON AUGUST 10, 1983 THROUGH");
                    Console.WriteLine("\t\t\t\t\t\t      BATAS PAMBANSA 469. RTPI BECAME A STATE COLLEGE, THE RIZAL POLYTECHNIC COLLEGE ON MARCH 1, 1995 THROUGH REP. ACT");
                    Console.WriteLine("\t\t\t\t\t\t      7933. THROUGH BOARD OF TRUSTEES RESOLUTION NO. 06 - 13 - 98 DATED FEBRUARY 12, 1998. RPC CARDONA RESEARCH EXTENSION");
                    Console.WriteLine("\t\t\t\t\t\t      WAS ESTABLISHED.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t   >>    AT PRESENT THE UNIVERSITY OPERATES WITH TEN (10) CAMPUSES IN THE PROVINCE OF RIZAL, NAMELY: URS ANGONO, ANTIPOLO,");
                    Console.WriteLine("\t\t\t\t\t\t      BINANGONAN, CAINTA, CARDONA, MORONG , PILILLA, RODRIGUEZ, TANAY AND TAYTAY. IT OFFERS COMPLETELY EDUCATION FROM   ");
                    Console.WriteLine("\t\t\t\t\t\t      KINDERGARTED TO GRADUATE SCHOOL. THE UNIVERSITY IMPLEMENTS OF NUMBER OF ACADEMIC PROGRAMS IN THE DOCTORATE, MASTERS,");
                    Console.WriteLine("\t\t\t\t\t\t      BACCALAUREATE, NON - DEGREE AND SHORT TERM COURSES. IT ALSO PROVIDES RESEARCH , EXTENSION AND PRODUCTION SERVICES AS");
                    Console.WriteLine("\t\t\t\t\t\t      WELL AS ESTABLISHMENT OF CENTERS. THE EXCISTENCE OF THE UNIVERSITY CATERS TO THE NEEDS OF THE STAKEHOLDERS WITHIN AND");
                    Console.WriteLine("\t\t\t\t\t\t      NEARBY PROVINCES.");
                }
                else if (choice.Equals("5", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("ccs goals", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthytwo();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    COLLEGE OF COMPUTER STUDIES COMMITS ITSELF IN THE PURSUIT OF EXCELLENCE, PROVIDES INFORMATION ");
                    Console.WriteLine("\t\t\t\t\t\t\t         TECHNOLOGY METHODOLOGIES IN THE ADVANCEMENT OF STUDENTS' INNOVATIVENESS, CREATIVITY, AND COMPETENCIES");
                    Console.WriteLine("\t\t\t\t\t\t\t         AS THEY FOSTER THEIR VALUES IN THE SERVICE OF MEN");
                }
                else if (choice.Equals("6", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("ccs history", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthythree();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t   >>    THE UNIVERSITY OF RIZAL SYSTEM, BINANGONAN CAMPUS OPEN ITS DOOR TO THE PUBLIC IN 1998 WITH THE INSTITUTE OF COOPERATIVE");
                    Console.WriteLine("\t\t\t\t\t\t      ECONOMICS MANAGEMENT (ICEM) HEADED BY ALLAN ANORICO AFTER A YEAR 1999. THE INSTITUTE OF COMPUTER SCIENCE CHANGE ITS NAME TO");
                    Console.WriteLine("\t\t\t\t\t\t      INSITITUE OF COMPUTER SCIENCE AND INFORMATION MANAGEMENT (ICSIM) WITH PROF. ALLAN ANORICO AS THE PROGRAM HEAD. A TWO YEAR");
                    Console.WriteLine("\t\t\t\t\t\t      COURSE IS BS COMPUTER ENGINEERING AND ASSOCIATE IN COMPUTER TECHNOLOGY WAS OFFERED LIKEWISE DURING THAT SAME YEAR.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t   >>    THE YEAR 2002 COMES ALONG ALIVE WTIH A NEW COURSE IN INFORMATION MANAGEMENT AND COMPUTER EDUCATION DEVELOPMENT WHICH IS");
                    Console.WriteLine("\t\t\t\t\t\t      DESIGNED AS A TWO YEARS COURSE. THE PROGRESSIONS OF INSTITUTION CONTINUED TO OFFER NEW COURSE IN 2003, UNDER PROF. AILEEN");
                    Console.WriteLine("\t\t\t\t\t\t      MARTIZANO, BACHELOR OF SCIENCE IN COMPUTER TECHNOLOGY WAS INTRODUCED; A GREAT BREAK THROUGH SETS IN THE YEAR 2007 - 2008 THE ");
                    Console.WriteLine("\t\t\t\t\t\t      NAME OF THE INSTITUTE WAS CHANGE TO COLLEGE OF INFORMATION TECHNOLOGY (CITM) HEADED BY ELOISSA ANORICO WHICH OFFERE A COURSES");
                    Console.WriteLine("\t\t\t\t\t\t      IN BACHELOR OF SCIENCE IN INFORMATION MANAGEMENT (BSIM) AND COMPUTER SYSTEM TECHNOLOGY (CST).");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t   >>    THE BEGINNING OF 2009 AND 2010 SET A NEW DIRECTIONS FOR CITM WITH PROF. JOSELITO DACUMOS WHO TAKES A NEW EDGE IN BSIM AND");
                    Console.WriteLine("\t\t\t\t\t\t      CST COURSES. THE PERIOD OF JUNE 2016 TO DEC 2010 TOOK A SIGNIFICANT CHANGES IN THE ADMINISTRATION, THE ACADEME BROUGHT A NEW");
                    Console.WriteLine("\t\t\t\t\t\t      HIGHLIGHT WITH PROF. BERONILLO TAKE THE LEADERSHIP AND AT THE SAME TIME THE NAME OF THE INSTITUTE WAS CHANGE FROM CITM TO CIM.");
                    Console.WriteLine("\t\t\t\t\t\t      SO MANY CHANGES TOOK PLACE IN THE INSTITUTE BUT IT ALL SEEMS WELL.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t   >>    THE YEAR 2011 - 2012 WAS A MILESTONE FOR THE CIM. MRS. GRACE P. SAN JUAN TOOK THE POST OF OIC FOR CIM. THE PERIOD OF 2013 TO");
                    Console.WriteLine("\t\t\t\t\t\t      2014 WAS GREAT SIGNIFICANT FOR THE INSTITUTE. COLLEGE OF COMPUTER STUDIES WAS BORN OFFERING A COURSE PROGRAM IN THE FOLLOWING FIELD.");
                    Console.WriteLine("\t\t\t\t\t\t      BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY (BSIT), BACHELOR OF SCIENCE IN INFORMATION SYSTEM AND COMPUTER SCIENCE TECHNOLOGY , AND");
                    Console.WriteLine("\t\t\t\t\t\t      AND UP TO THE PRESENT TIME THE CCS FOLLOW ITS MANDATE TO PROVIDES A GOOD QUALITY EDUCATION IN COMPUTER TECHNOLOGY.");
                }
                else if (choice.Equals("7", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("ccs logo", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthyfour();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    METAL FRAME  -  IT SYMBOLIZES THE STRONG FOUNDATION BETWEEN FACULTY AND STUDENTS.");
                    Console.WriteLine("\t\t\t\t\t\t\t      IT ALSO REPRESENTS THE STRONG BIND AND INTERPEDENCE AMONG ALL THE STAKEHOLDERS OF THE");
                    Console.WriteLine("\t\t\t\t\t\t\t      COLLEGEE.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    GEAR  -  IT SYMBOLIZES THE NEW TREND IN IT EDUCATION. IT STANDS  FOR THE CONTINUING");
                    Console.WriteLine("\t\t\t\t\t\t\t      AND ONWARD PUSH OF DEVELOPMENT TOWARDS A BRIGHTER FUTURE THROUGH THE USE OF TECHNOLOGY.");
                    Console.WriteLine("\t\t\t\t\t\t\t      THE GEAR, WHICH IS ALOS THE PROMINENT FEATURE OF THE URS LOGO, ALSO PROVIDES THE LINK");
                    Console.WriteLine("\t\t\t\t\t\t\t      BETWEEN THE COLLEGE OF COMPUTER STUDIES AND THE UNIVERSITY.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    RAYS  -  THE COLLEGE OF COMPUTER STUDIES IS STEADFAST IN ITS GOAL TO PROVIDE QUALITY");
                    Console.WriteLine("\t\t\t\t\t\t\t      EDUCATION TO THE YOUNG MINDS OF RIZAL. LIKE A BEACON OF HOPE. IT PROVIDES A GUIDING LIGHT");
                    Console.WriteLine("\t\t\t\t\t\t\t      TO THOSE WHO ARE WILLING TO LEARN");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    GREEN  -  IS THE CCS'S PROUD COLLEGE COLOR. IT SIGNIFIES HOPE AND VIGOR, THE TRAITS");
                    Console.WriteLine("\t\t\t\t\t\t\t      AND IDEALS THAT THE COLLEGE FOSTERS AMONG THE STUDENTS.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    BINARY NUMBER  -  IS THE UNIVERSAL LANGUAGE OF COMPUTER PROGRAMS. IT DEMONSTRATES HOW");
                    Console.WriteLine("\t\t\t\t\t\t\t      EDUCATION TRANCSENDS ALL BOUNDARIES AND DIFFERENCES. LIKE THE BINARY SYSTEM, THE CCS AIMS");
                    Console.WriteLine("\t\t\t\t\t\t\t      TO EDUCATE ALL THOSE WHO ARE WILLING TO LEARN REGARDLESS OF THEIR PERSOBAL CIRCUMSTANCES");
                    Console.WriteLine("\t\t\t\t\t\t\t      USING THE POWER OF TECHNOLOGY. THE BINARY CODE EMBEDDED IN THE LOGO TRANSLATES AS INNOVA-");
                    Console.WriteLine("\t\t\t\t\t\t\t      TIVENESS, CREATIVITY AND COMPETENCIES WHICH ARE THE FOUNDATION OF THE CCS GOAL.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    FLAME  -  THE STYLIZED FLAMES SPELLS THE LETTER CCS WHICH STANDS FOR THE COLLEGE OF COMPUTER");
                    Console.WriteLine("\t\t\t\t\t\t\t      STUDIES. FURTHERMORE, THE FLAME REPRESENTS EDUCATION, A BRIGHT LIGHT THAT PIERCES THE SHADOW OF");
                    Console.WriteLine("\t\t\t\t\t\t\t      IGNORANCE.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    PILLAR  -  THE PILLAR IS THE ICONIC SYMBOL OF URSB. IT REPRESENTS STABILITY AND RESILLIENCE,");
                    Console.WriteLine("\t\t\t\t\t\t\t      TRAITS, THAT URSB AS A CAMPUS POSSESES. AS THE PILLARS IN THE FACADE OF THE CAMPUS STANDS PROUD");
                    Console.WriteLine("\t\t\t\t\t\t\t      AND TALL, THE CCS LIKEWISE PROVIDES STRENGTH AND SUPPORT IN THE PURSUIT OF UNIVERITY'S MISSIONS");
                    Console.WriteLine("\t\t\t\t\t\t\t      AND VISIONS.");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t   >>    STAIRS  -  THE THREE TIERED STAIRS REPRESENTS RESEARCH, EXTENSIONS, AND PRODUCTION WHICH ARE THE");
                    Console.WriteLine("\t\t\t\t\t\t\t      FUNCTIONS OF A HIGHER EDUCATION INSITUTION. AS SYMBOLIC STAIRS, THEY SERVE AS STEPPING STONES WHICH THE");
                    Console.WriteLine("\t\t\t\t\t\t\t      COLLEGE USES ACHIEVE ITS GOALS");      
                }
                else if (choice.Equals("8", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("bsit program description", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthyfive();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t   >>    THE BACHELOR OF SCIENCE IN INFORMATION TECHNOLOGY (BSIT) PROGRAM");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         PREPARES STUDENTS TO BE IT PROFESSIONALS, BE WELL VERSED ON APPLICATION");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         INSTALLATION, OPERATION, DEVELOPMENT, MAINTENANCE, AND ADMINISTRATION,");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         AND FAMILIARIZED WITH HARDWARE INSTALLATION, OPERATION, AND MAINTENANCE");      
                }
                else if (choice.Equals("9", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("bsit objectives", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthysix();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t   >>    WITHIN FOUR YEARS AFTER GRADUATION, THE GRADUATES OF BS INFORMATION TECHNOLOGY");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         SHALL HAVE:");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t      1. DEVELOPED THEIR UTMOST PROFESSIONAL COMPETENCE IN ALL APPLICATIONS OF");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         INFORMATION TECHNOLOGY IN RESPONSE TO THE DEMANDS OF MODERN TIME");
                    Console.WriteLine("\t\t\t\t\t\t\t\t      2. REALIZED THE ESSENTIAL CONTRIBUTION OF IT IN BUSINESS ECONOMICS AND");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         RELATED INDUSTRIES.");
                    Console.WriteLine("\t\t\t\t\t\t\t\t      3. ADHERED THEMESELVESE IN THE SENSE OF PROFESSIONAL VALUES AND ETHICS AS");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         THEY RESPOND AND ADVANCE THEMSELVES IN THE DEMANDS OF THE PRESENT TIME.");
                    Console.WriteLine("\t\t\t\t\t\t\t\t      4. PRESERVED AND PROMOTE THE NATIONS CULTURE HERITAGE, PROPERTY AND HISTORIES");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         AND ETHNICITY OF LOCAL COMMUNITIES THROUGH COMMUNICATION INFORMATTION TECHNOLOGY");
                    Console.WriteLine("\t\t\t\t\t\t\t\t      5. INSTALLED IN THEM THE SIGNIFICANCE OF RESEARCH AND COMMUNITY SERVICES AS TOOLS FOR");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         HUMAN ADVANCEMENT AND EMPOWERMENT");
                }
                else if (choice.Equals("10", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("bsis program description", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthyseven();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t   >>    THE BACHELOR OF SCIENCE IN INFORMATION SYSTEM (BSIS) PROGRAM");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t         PREPARES STUDENTS TO BE IT PROFESSIONALS AND EXPERT ON DESIGN");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t         AND IMPLEMENTATION OF IS BUSINESS PROCESSES.");      
                }
                else if (choice.Equals("11", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("bsis objectives", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Clear();
                    f.fourthyeight();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t   >>    WITHIN FOUR YEARS AFTER GRADUATION, THE GRADUATES OF BS INFORMATION SYSTEM");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         SHALL HAVE:");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t      1. DEMONSTRATED THEIR UTMOST PROFESSIONAL COMPETENCE IN ALL APPLICATIONS OF");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         INFORMATION SYSTEMS IN REPSONSE TO THE DEMANDS OF MODERN TIME.");
                    Console.WriteLine("\t\t\t\t\t\t\t\t      2. APPREHEND THE FUNDAMENTAL CONTRIBUTION OF IS IN WEB - MARKET AND RELATED");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         INDUSTRIES.");
                    Console.WriteLine("\t\t\t\t\t\t\t\t      3. INSTILLED IN THEM THE SIGNIFICANCE OF RESEARCH AND COMMUNITY SERVICES AS");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         TOOLS FOR HUMAN ADVANCEMENT AND EMPOWERMENT.");
                    Console.WriteLine("\t\t\t\t\t\t\t\t      4. UNDERTAKEN PROJECTS THAT PROMOTE THE NATIONS CULTURE AND THE ETHNICITY OF");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         LOCAL COMMUNITIES THROUGH INFORMATION SYSTEM.");
                    Console.WriteLine("\t\t\t\t\t\t\t\t      5. EXHIBITED HIGH STANDARDS OF PROFESSIONAL ATTITUDES AND VALUES TO ACHIEVE");
                    Console.WriteLine("\t\t\t\t\t\t\t\t         EXCELLENCE");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    f.sixteenth();
                    System.Threading.Thread.Sleep(1000);
                    goto start;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t    >>   DO YOU WANT TO USE CCS HANDBOOK AGAIN?  PRESS (YES OR NO)   :    ");
                choice1 = Console.ReadLine();

                if (choice1.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice1.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                {
                    goto start;
                }
                else if (choice1.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice1.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t  >>  THANK YOU");
                }
                else
                {
                
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    f.sixteenth();
                    System.Threading.Thread.Sleep(1000);
                    goto start;
                }
            //} while (choice1.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice1.Equals("yes", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
