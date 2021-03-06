using System;
using System.Collections.Generic;
using System.Text;

namespace DSPUtil
{
    public class HRTF
    {
        public static FilterProfile diffuseDiff0()
        {
            // from Farina data 0 degrees
            FilterProfile lfg = new FilterProfile();
            lfg.Add(new FreqGain(29.8999517172724, -0.819594013962942));
            lfg.Add(new FreqGain(45.9318520170928, -0.825206846036483));
            lfg.Add(new FreqGain(62.7349359370437, -0.843228404280093));
            lfg.Add(new FreqGain(80.348144199439, -0.85549279781466));
            lfg.Add(new FreqGain(98.812561979239, -0.885552104079416));
            lfg.Add(new FreqGain(118.171554124747, -0.921814975716754));
            lfg.Add(new FreqGain(138.470910523652, -0.941989434053033));
            lfg.Add(new FreqGain(159.759002525445, -0.986288515963084));
            lfg.Add(new FreqGain(182.086951427111, -1.03487811152306));
            lfg.Add(new FreqGain(205.508810136376, -1.08724309366587));
            lfg.Add(new FreqGain(230.081759247243, -1.14301616694228));
            lfg.Add(new FreqGain(255.866318897917, -1.20202072457563));
            lfg.Add(new FreqGain(282.926577933456, -1.29716987120868));
            lfg.Add(new FreqGain(311.330442067148, -1.36375538636994));
            lfg.Add(new FreqGain(341.14990292827, -1.4644642435199));
            lfg.Add(new FreqGain(372.461330102897, -1.52904718749126));
            lfg.Add(new FreqGain(405.345788522409, -1.61553093677067));
            lfg.Add(new FreqGain(439.889383835671, -1.68163798221837));
            lfg.Add(new FreqGain(476.183638720577, -1.71733965267451));
            lfg.Add(new FreqGain(514.325903454604, -1.71900339686128));
            lfg.Add(new FreqGain(554.419804479247, -1.66747850462173));
            lfg.Add(new FreqGain(596.575735167586, -1.59447747686689));
            lfg.Add(new FreqGain(640.911393547776, -1.45582456727674));
            lfg.Add(new FreqGain(687.552372358488, -1.28169168214036));
            lfg.Add(new FreqGain(736.632807529586, -1.08266101402942));
            lfg.Add(new FreqGain(788.296092007413, -0.799257236450344));
            lfg.Add(new FreqGain(842.695662798627, -0.550308170104235));
            lfg.Add(new FreqGain(899.99587021156, -0.216876477890536));
            lfg.Add(new FreqGain(960.372939556513, 0.123762097833653));
            lfg.Add(new FreqGain(1024.01603705869, 0.504501005258036));
            lfg.Add(new FreqGain(1091.12845347812, 0.806009630861022));
            lfg.Add(new FreqGain(1161.92892096669, 0.970563802808751));
            lfg.Add(new FreqGain(1236.65308108085, 0.993384317252108));
            lfg.Add(new FreqGain(1315.55512467678, 0.899269754624433));
            lfg.Add(new FreqGain(1398.90962772937, 0.71574567174392));
            lfg.Add(new FreqGain(1487.01361103779, 0.42413561491627));
            lfg.Add(new FreqGain(1580.18885643692, 0.0143087139306365));
            lfg.Add(new FreqGain(1678.7845176806, -0.374163000274005));
            lfg.Add(new FreqGain(1783.18007079301, -0.604206586990272));
            lfg.Add(new FreqGain(1893.78865663959, -0.643361845768994));
            lfg.Add(new FreqGain(2011.06087804797, -0.450261422187758));
            lfg.Add(new FreqGain(2135.48912539139, -0.117143308385737));
            lfg.Add(new FreqGain(2267.61251860637, 0.0726448007728625));
            lfg.Add(new FreqGain(2408.02257075748, 0.149673576192565));
            lfg.Add(new FreqGain(2557.3696992537, -0.0705597943707172));
            lfg.Add(new FreqGain(2716.3707366486, -0.615399531580617));
            lfg.Add(new FreqGain(2885.81762489105, -0.715844747528019));
            lfg.Add(new FreqGain(3066.58751658265, -0.80980936924732));
            lfg.Add(new FreqGain(3259.65455639083, -0.724599496650513));
            lfg.Add(new FreqGain(3466.1036780904, -1.74219819410634));
            lfg.Add(new FreqGain(3687.14683149463, -3.60307539107681));
            lfg.Add(new FreqGain(3924.14215377249, -5.62149036113584));
            lfg.Add(new FreqGain(4178.61672801844, -7.30684974206415));
            lfg.Add(new FreqGain(4452.29373750316, -9.58452126557679));
            lfg.Add(new FreqGain(4747.12503915768, -12.7988548069547));
            lfg.Add(new FreqGain(5065.3304615832, -14.2817841410128));
            lfg.Add(new FreqGain(5409.44550497149, -14.3089505650728));
            lfg.Add(new FreqGain(5782.37961614996, -14.7676142885599));
            lfg.Add(new FreqGain(6187.48787900699, -15.4620314368829));
            lfg.Add(new FreqGain(6628.65986711531, -17.5471846623073));
            lfg.Add(new FreqGain(7110.43065099071, -16.7838733846363));
            lfg.Add(new FreqGain(7638.12068410502, -11.2810169858127));
            lfg.Add(new FreqGain(8218.013729816, -6.43017437119144));
            lfg.Add(new FreqGain(8857.58547111898, -2.58756224649037));
            lfg.Add(new FreqGain(9565.80048575836, -3.18112947019392));
            lfg.Add(new FreqGain(10353.5026895216, -5.40667046909438));
            lfg.Add(new FreqGain(11233.9354678215, -3.35732869042161));
            lfg.Add(new FreqGain(12223.4446965003, -1.40180859827503));
            lfg.Add(new FreqGain(13342.444347283, -2.18457352314182));
            lfg.Add(new FreqGain(14616.7666969568, -2.52559711716481));
            lfg.Add(new FreqGain(16079.5885672628, -2.64456253082918));
            lfg.Add(new FreqGain(17774.2422466263, -2.07661523855391));
            lfg.Add(new FreqGain(19758.4244207167, -0.0243216938532986));
            lfg.Add(new FreqGain(22110.6876081231, -0.00493030880131535));
            return lfg;
        }

        public static FilterProfile diffuseDiff15()
        {
            // from Farina data -15 degrees
            FilterProfile lfg = new FilterProfile();
            lfg.Add(new FreqGain(29.8999517172724, -0.0863917163326701));
            lfg.Add(new FreqGain(45.9318520170928, -0.086646594026467));
            lfg.Add(new FreqGain(62.7349359370437, -0.0874548658683244));
            lfg.Add(new FreqGain(80.348144199439, -0.0879751392064135));
            lfg.Add(new FreqGain(98.812561979239, -0.0890868621043947));
            lfg.Add(new FreqGain(118.171554124747, -0.0902608074810529));
            lfg.Add(new FreqGain(138.470910523652, -0.0909038889250574));
            lfg.Add(new FreqGain(159.759002525445, -0.0923344140142375));
            lfg.Add(new FreqGain(182.086951427111, -0.0937822151583515));
            lfg.Add(new FreqGain(205.508810136376, -0.0951728613131329));
            lfg.Add(new FreqGain(230.081759247243, -0.0964831892699499));
            lfg.Add(new FreqGain(255.866318897917, -0.0977855409466679));
            lfg.Add(new FreqGain(282.926577933456, -0.0996764404835705));
            lfg.Add(new FreqGain(311.330442067148, -0.100486603558354));
            lfg.Add(new FreqGain(341.14990292827, -0.100051270274286));
            lfg.Add(new FreqGain(372.461330102897, -0.0979260196990259));
            lfg.Add(new FreqGain(405.345788522409, -0.0908775515206414));
            lfg.Add(new FreqGain(439.889383835671, -0.0782636965770721));
            lfg.Add(new FreqGain(476.183638720577, -0.0589294155247667));
            lfg.Add(new FreqGain(514.325903454604, -0.0331101724182802));
            lfg.Add(new FreqGain(554.419804479247, 0.0100958113611724));
            lfg.Add(new FreqGain(596.575735167586, 0.0479470506982144));
            lfg.Add(new FreqGain(640.911393547776, 0.105430778442781));
            lfg.Add(new FreqGain(687.552372358488, 0.168896217319817));
            lfg.Add(new FreqGain(736.632807529586, 0.237255771124081));
            lfg.Add(new FreqGain(788.296092007413, 0.328490953798301));
            lfg.Add(new FreqGain(842.695662798627, 0.402734259074768));
            lfg.Add(new FreqGain(899.99587021156, 0.494326782264423));
            lfg.Add(new FreqGain(960.372939556513, 0.578128079437876));
            lfg.Add(new FreqGain(1024.01603705869, 0.660125601312093));
            lfg.Add(new FreqGain(1091.12845347812, 0.712681005041455));
            lfg.Add(new FreqGain(1161.92892096669, 0.732542794364541));
            lfg.Add(new FreqGain(1236.65308108085, 0.726404101177543));
            lfg.Add(new FreqGain(1315.55512467678, 0.698273367243763));
            lfg.Add(new FreqGain(1398.90962772937, 0.645682099120009));
            lfg.Add(new FreqGain(1487.01361103779, 0.571255784106514));
            lfg.Add(new FreqGain(1580.18885643692, 0.4830388210465));
            lfg.Add(new FreqGain(1678.7845176806, 0.408070371811873));
            lfg.Add(new FreqGain(1783.18007079301, 0.35550515378515));
            lfg.Add(new FreqGain(1893.78865663959, 0.319200925184918));
            lfg.Add(new FreqGain(2011.06087804797, 0.311247539991447));
            lfg.Add(new FreqGain(2135.48912539139, 0.320676353553954));
            lfg.Add(new FreqGain(2267.61251860637, 0.337219551748223));
            lfg.Add(new FreqGain(2408.02257075748, 0.396218572472187));
            lfg.Add(new FreqGain(2557.3696992537, 0.477239191635716));
            lfg.Add(new FreqGain(2716.3707366486, 0.49349820475482));
            lfg.Add(new FreqGain(2885.81762489105, 0.454308524133459));
            lfg.Add(new FreqGain(3066.58751658265, 0.202619261440745));
            lfg.Add(new FreqGain(3259.65455639083, -0.229775101327912));
            lfg.Add(new FreqGain(3466.1036780904, -0.679735290459132));
            lfg.Add(new FreqGain(3687.14683149463, -1.14273604455762));
            lfg.Add(new FreqGain(3924.14215377249, -1.58712231737431));
            lfg.Add(new FreqGain(4178.61672801844, -2.24464955682634));
            lfg.Add(new FreqGain(4452.29373750316, -2.95221883480249));
            lfg.Add(new FreqGain(4747.12503915768, -3.59713042788595));
            lfg.Add(new FreqGain(5065.3304615832, -3.95400511725521));
            lfg.Add(new FreqGain(5409.44550497149, -4.26734231473008));
            lfg.Add(new FreqGain(5782.37961614996, -4.29752236704959));
            lfg.Add(new FreqGain(6187.48787900699, -3.80417940781499));
            lfg.Add(new FreqGain(6628.65986711531, -3.42269750300152));
            lfg.Add(new FreqGain(7110.43065099071, -2.67952601614751));
            lfg.Add(new FreqGain(7638.12068410502, -1.40074317089712));
            lfg.Add(new FreqGain(8218.013729816, -0.278815569277744));
            lfg.Add(new FreqGain(8857.58547111898, -0.10133776498712));
            lfg.Add(new FreqGain(9565.80048575836, -1.16608058344807));
            lfg.Add(new FreqGain(10353.5026895216, -1.11758243515913));
            lfg.Add(new FreqGain(11233.9354678215, 0.278943448347119));
            lfg.Add(new FreqGain(12223.4446965003, 0.908362838092288));
            lfg.Add(new FreqGain(13342.444347283, 0.57561474694365));
            lfg.Add(new FreqGain(14616.7666969568, -0.0622868258733881));
            lfg.Add(new FreqGain(16079.5885672628, -0.254955438747692));
            lfg.Add(new FreqGain(17774.2422466263, -0.24984582194041));
            lfg.Add(new FreqGain(19758.4244207167, -0.00233095236861375));
            lfg.Add(new FreqGain(22110.6876081231, -0.000536752738788648));
            return lfg;
        }

        public static FilterProfile diffuseDiff30()
        {
            // from Farina data -30 degrees
            FilterProfile lfg = new FilterProfile();
            lfg.Add(new FreqGain(29.8999517172724, 0.0153703412721632));
            lfg.Add(new FreqGain(45.9318520170928, 0.0157412462362341));
            lfg.Add(new FreqGain(62.7349359370437, 0.0169348231887618));
            lfg.Add(new FreqGain(80.348144199439, 0.0177668016028915));
            lfg.Add(new FreqGain(98.812561979239, 0.0199231953358116));
            lfg.Add(new FreqGain(118.171554124747, 0.0226506268703839));
            lfg.Add(new FreqGain(138.470910523652, 0.0241826281526221));
            lfg.Add(new FreqGain(159.759002525445, 0.0275609026693427));
            lfg.Add(new FreqGain(182.086951427111, 0.0314140735720051));
            lfg.Add(new FreqGain(205.508810136376, 0.0357721055372592));
            lfg.Add(new FreqGain(230.081759247243, 0.0406187033498547));
            lfg.Add(new FreqGain(255.866318897917, 0.045887705945406));
            lfg.Add(new FreqGain(282.926577933456, 0.0546401434119344));
            lfg.Add(new FreqGain(311.330442067148, 0.0611568261029155));
            lfg.Add(new FreqGain(341.14990292827, 0.0721646415370508));
            lfg.Add(new FreqGain(372.461330102897, 0.0804691995918961));
            lfg.Add(new FreqGain(405.345788522409, 0.0944756139816788));
            lfg.Add(new FreqGain(439.889383835671, 0.110303869737514));
            lfg.Add(new FreqGain(476.183638720577, 0.127959954687666));
            lfg.Add(new FreqGain(514.325903454604, 0.14722607642479));
            lfg.Add(new FreqGain(554.419804479247, 0.174693312387337));
            lfg.Add(new FreqGain(596.575735167586, 0.196367637676681));
            lfg.Add(new FreqGain(640.911393547776, 0.226502192739724));
            lfg.Add(new FreqGain(687.552372358488, 0.257404487702997));
            lfg.Add(new FreqGain(736.632807529586, 0.289308287895174));
            lfg.Add(new FreqGain(788.296092007413, 0.330164254725067));
            lfg.Add(new FreqGain(842.695662798627, 0.362004711488242));
            lfg.Add(new FreqGain(899.99587021156, 0.399201023703967));
            lfg.Add(new FreqGain(960.372939556513, 0.430608404836277));
            lfg.Add(new FreqGain(1024.01603705869, 0.459162211936077));
            lfg.Add(new FreqGain(1091.12845347812, 0.477917208748288));
            lfg.Add(new FreqGain(1161.92892096669, 0.4888832470924));
            lfg.Add(new FreqGain(1236.65308108085, 0.491406736478912));
            lfg.Add(new FreqGain(1315.55512467678, 0.482634965114746));
            lfg.Add(new FreqGain(1398.90962772937, 0.460215735460547));
            lfg.Add(new FreqGain(1487.01361103779, 0.42785945371676));
            lfg.Add(new FreqGain(1580.18885643692, 0.384755864426881));
            lfg.Add(new FreqGain(1678.7845176806, 0.338743142917392));
            lfg.Add(new FreqGain(1783.18007079301, 0.29481578763389));
            lfg.Add(new FreqGain(1893.78865663959, 0.256334042859472));
            lfg.Add(new FreqGain(2011.06087804797, 0.230791717775949));
            lfg.Add(new FreqGain(2135.48912539139, 0.222331981999943));
            lfg.Add(new FreqGain(2267.61251860637, 0.242145604431654));
            lfg.Add(new FreqGain(2408.02257075748, 0.274638622926097));
            lfg.Add(new FreqGain(2557.3696992537, 0.30577186219793));
            lfg.Add(new FreqGain(2716.3707366486, 0.313600675670305));
            lfg.Add(new FreqGain(2885.81762489105, 0.24417849843071));
            lfg.Add(new FreqGain(3066.58751658265, 0.0849830918843977));
            lfg.Add(new FreqGain(3259.65455639083, -0.184798841769974));
            lfg.Add(new FreqGain(3466.1036780904, -0.532453036199661));
            lfg.Add(new FreqGain(3687.14683149463, -0.919617070793028));
            lfg.Add(new FreqGain(3924.14215377249, -1.23374473854346));
            lfg.Add(new FreqGain(4178.61672801844, -1.41321418967923));
            lfg.Add(new FreqGain(4452.29373750316, -1.64528910099878));
            lfg.Add(new FreqGain(4747.12503915768, -1.89417809903332));
            lfg.Add(new FreqGain(5065.3304615832, -1.92858810971928));
            lfg.Add(new FreqGain(5409.44550497149, -1.69347768706069));
            lfg.Add(new FreqGain(5782.37961614996, -1.17378189132115));
            lfg.Add(new FreqGain(6187.48787900699, -0.583107768215692));
            lfg.Add(new FreqGain(6628.65986711531, -0.077364511850989));
            lfg.Add(new FreqGain(7110.43065099071, 0.242584278157174));
            lfg.Add(new FreqGain(7638.12068410502, 0.497534967708144));
            lfg.Add(new FreqGain(8218.013729816, 0.593572397741133));
            lfg.Add(new FreqGain(8857.58547111898, 0.197431152769074));
            lfg.Add(new FreqGain(9565.80048575836, 0.179647743864568));
            lfg.Add(new FreqGain(10353.5026895216, 0.240381170494958));
            lfg.Add(new FreqGain(11233.9354678215, 0.767127553409873));
            lfg.Add(new FreqGain(12223.4446965003, 0.957392389217609));
            lfg.Add(new FreqGain(13342.444347283, 0.575418314572688));
            lfg.Add(new FreqGain(14616.7666969568, 0.178440138798458));
            lfg.Add(new FreqGain(16079.5885672628, -0.0565288100190609));
            lfg.Add(new FreqGain(17774.2422466263, -0.0358792500656471));
            lfg.Add(new FreqGain(19758.4244207167, 2.12975819769935E-05));
            lfg.Add(new FreqGain(22110.6876081231, -0.000421783662717478));
            return lfg;
        }

        public static FilterProfile diffuseDiff45()
        {
            // from Farina data -45 degrees
            FilterProfile lfg = new FilterProfile();
            lfg.Add(new FreqGain(29.8999517172724, 0.034493028904745));
            lfg.Add(new FreqGain(45.9318520170928, 0.0348965563859305));
            lfg.Add(new FreqGain(62.7349359370437, 0.0361962782805971));
            lfg.Add(new FreqGain(80.348144199439, 0.0370951759531601));
            lfg.Add(new FreqGain(98.812561979239, 0.0393802905089846));
            lfg.Add(new FreqGain(118.171554124747, 0.0422391555889454));
            lfg.Add(new FreqGain(138.470910523652, 0.0438547095733166));
            lfg.Add(new FreqGain(159.759002525445, 0.0474495412837798));
            lfg.Add(new FreqGain(182.086951427111, 0.0515476348543647));
            lfg.Add(new FreqGain(205.508810136376, 0.056162673196398));
            lfg.Add(new FreqGain(230.081759247243, 0.0612659549892737));
            lfg.Add(new FreqGain(255.866318897917, 0.0668005443605352));
            lfg.Add(new FreqGain(282.926577933456, 0.0758917506709455));
            lfg.Add(new FreqGain(311.330442067148, 0.0824530823635971));
            lfg.Add(new FreqGain(341.14990292827, 0.0929637778755104));
            lfg.Add(new FreqGain(372.461330102897, 0.100379371162514));
            lfg.Add(new FreqGain(405.345788522409, 0.111984167288103));
            lfg.Add(new FreqGain(439.889383835671, 0.123975744334166));
            lfg.Add(new FreqGain(476.183638720577, 0.136237010524912));
            lfg.Add(new FreqGain(514.325903454604, 0.148734117891156));
            lfg.Add(new FreqGain(554.419804479247, 0.165502936111769));
            lfg.Add(new FreqGain(596.575735167586, 0.178043988212559));
            lfg.Add(new FreqGain(640.911393547776, 0.194349156663897));
            lfg.Add(new FreqGain(687.552372358488, 0.209865869797881));
            lfg.Add(new FreqGain(736.632807529586, 0.22500194685938));
            lfg.Add(new FreqGain(788.296092007413, 0.243525065270957));
            lfg.Add(new FreqGain(842.695662798627, 0.257649467879212));
            lfg.Add(new FreqGain(899.99587021156, 0.273803874204412));
            lfg.Add(new FreqGain(960.372939556513, 0.28709311052957));
            lfg.Add(new FreqGain(1024.01603705869, 0.299481257886807));
            lfg.Add(new FreqGain(1091.12845347812, 0.309245022903803));
            lfg.Add(new FreqGain(1161.92892096669, 0.317179867687928));
            lfg.Add(new FreqGain(1236.65308108085, 0.321207380680425));
            lfg.Add(new FreqGain(1315.55512467678, 0.318824411496162));
            lfg.Add(new FreqGain(1398.90962772937, 0.307833522186889));
            lfg.Add(new FreqGain(1487.01361103779, 0.289293331349614));
            lfg.Add(new FreqGain(1580.18885643692, 0.261606526767296));
            lfg.Add(new FreqGain(1678.7845176806, 0.228997685797403));
            lfg.Add(new FreqGain(1783.18007079301, 0.197540714557954));
            lfg.Add(new FreqGain(1893.78865663959, 0.17295074128593));
            lfg.Add(new FreqGain(2011.06087804797, 0.156696169926535));
            lfg.Add(new FreqGain(2135.48912539139, 0.148455185344538));
            lfg.Add(new FreqGain(2267.61251860637, 0.154528024795868));
            lfg.Add(new FreqGain(2408.02257075748, 0.157020651297763));
            lfg.Add(new FreqGain(2557.3696992537, 0.147606277996199));
            lfg.Add(new FreqGain(2716.3707366486, 0.131041736855722));
            lfg.Add(new FreqGain(2885.81762489105, 0.0866347064265516));
            lfg.Add(new FreqGain(3066.58751658265, -0.0166654973944371));
            lfg.Add(new FreqGain(3259.65455639083, -0.191612322714693));
            lfg.Add(new FreqGain(3466.1036780904, -0.432511035136432));
            lfg.Add(new FreqGain(3687.14683149463, -0.658960079848589));
            lfg.Add(new FreqGain(3924.14215377249, -0.762774466055965));
            lfg.Add(new FreqGain(4178.61672801844, -0.72195332419533));
            lfg.Add(new FreqGain(4452.29373750316, -0.589733799295838));
            lfg.Add(new FreqGain(4747.12503915768, -0.42970971679252));
            lfg.Add(new FreqGain(5065.3304615832, -0.232527169811399));
            lfg.Add(new FreqGain(5409.44550497149, -0.0355174224726339));
            lfg.Add(new FreqGain(5782.37961614996, 0.226790461488208));
            lfg.Add(new FreqGain(6187.48787900699, 0.570687924885134));
            lfg.Add(new FreqGain(6628.65986711531, 0.902844690346035));
            lfg.Add(new FreqGain(7110.43065099071, 0.97846591522975));
            lfg.Add(new FreqGain(7638.12068410502, 0.785508262062104));
            lfg.Add(new FreqGain(8218.013729816, 0.635399466540685));
            lfg.Add(new FreqGain(8857.58547111898, 0.525129410649112));
            lfg.Add(new FreqGain(9565.80048575836, 0.366859907213853));
            lfg.Add(new FreqGain(10353.5026895216, 0.447897246086743));
            lfg.Add(new FreqGain(11233.9354678215, 0.36565051131466));
            lfg.Add(new FreqGain(12223.4446965003, 0.489904439751699));
            lfg.Add(new FreqGain(13342.444347283, 0.338111293138435));
            lfg.Add(new FreqGain(14616.7666969568, 0.237275309909941));
            lfg.Add(new FreqGain(16079.5885672628, 0.1220539710691));
            lfg.Add(new FreqGain(17774.2422466263, 0.0725148136373865));
            lfg.Add(new FreqGain(19758.4244207167, 0.00128859185038382));
            lfg.Add(new FreqGain(22110.6876081231, 6.13639214105897E-05));
            return lfg;
        }
    }
}
