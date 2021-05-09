public static class Analizator
{
    public static void Analize(RusNumber rusNumber)
    {
        switch (rusNumber.Reg)
        {
            case 2:
                switch (rusNumber.Let)
                {
                    case "PKC":
                    case "KKC":
                        rusNumber.SetData(2,
                            "Автомобили законодательного органа республики — Государственного Собрания — Курултая.");
                        break;
                    case "CKP":
                        rusNumber.SetData(2, "Собрание Курултая Республики.");
                        break;
                    case "MMM":
                        if (rusNumber.Num <= 100) rusNumber.SetData(3, "Прокуратура.");
                        break;
                    case "YYY":
                        if (rusNumber.Num < 11) rusNumber.SetData(4, "Руководители администрации города Уфы.");
                        break;
                    case "AAA":
                        switch (rusNumber.Num)
                        {
                            case 20:
                                rusNumber.SetData(5, "Глава Администрации городского округа город Уфа.");
                                break;
                            case 100:
                                rusNumber.SetData(5, "Президент Республики Башкортостан.");
                                break;
                            case 200:
                                rusNumber.SetData(5,
                                    "Председатель Государственного Собрания Курултай Республики Башкортостан.");
                                break;
                            case 300:
                                rusNumber.SetData(5, "Премьер—министр Правительства Республики Башкортостан.");
                                break;
                            default:
                                rusNumber.SetData(2,
                                    "Номера автомобилей Членов Правительства, руководителей Администрации Президента и самого Президента Республики Башкортостан и глав администрации районов и городов РБ.");
                                break;
                        }

                        break;
                    case "AMM":
                        if (rusNumber.Num > 100)
                            rusNumber.SetData(2,
                                "До замены спецсерии номеров автомобилей на \"синие\" данная серия полностью принадлежала автомобилям МВД.");
                        else
                            rusNumber.SetData(3,
                                "C 001—100 выдавались высокопоставленным сотрудникам правоохранительных и силовых структур РБ.");
                        break;
                    case "YMM":
                    case "OMM":
                        rusNumber.SetData(2, "Выдавались высшим руководством УГИБДД МВД РБ.");
                        break;
                    case "BMM":
                        rusNumber.SetData(2,
                            "Выдавались высшим руководством УГИБДД РБ и МВД РБ юридическим лицам.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2,
                            "Серия устанавливалась на автомобили руководителей крупных предприятий, министерств.");
                        break;
                }

                break;
            case 4:
                switch (rusNumber.Let)
                {
                    case "CCC":
                        rusNumber.SetData(2, "Судьи.");
                        break;
                    case "HHH":
                        rusNumber.SetData(2, "Налоговая служба.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2, "Руководство республики.");
                        break;
                    case "MPA":
                        rusNumber.SetData(2, "МВД республики.");
                        break;
                    case "PPP":
                    case "PPA":
                        rusNumber.SetData(2, "Прокуратура республики.");
                        break;
                    case "BAM":
                    case "TTT":
                    case "XXX":
                        rusNumber.SetData(2, "Редкая блатная серия.");
                        break;
                }

                break;
            case 8:
                switch (rusNumber.Let)
                {
                    case "CCC":
                        rusNumber.SetData(2, "Прокуратура Республики Калмыкия, судьи.");
                        break;
                    case "OOO":
                        if (rusNumber.Num <= 200) rusNumber.SetData(3, "Депутаты народного парламента.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "ГУВД по Республике Калмыкия.");
                        break;
                    case "AAA":
                        rusNumber.SetData(2, "Администрация Республики Калмыкия.");
                        break;
                }

                break;
            case 10:
                switch (rusNumber.Let)
                {
                    case "TTT":
                        rusNumber.SetData(2, "Правительство республики, ФСБ республики, есть и у частников.");
                        break;
                    case "HHH":
                        if (rusNumber.Num <= 200)
                            rusNumber.SetData(3,
                                "Серия автомобилей администраций городов и районов республики, есть и у частников.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "Серия автомобилей МВД. Есть и у частников.");
                        break;
                    case "EMP":
                        rusNumber.SetData(2,
                            "Серия автомобилей МВД, на которую были заменены \"синие\" номера автомобилей \"попавших под сокращение\".");
                        break;
                    case "CCC":
                        rusNumber.SetData(2, "Прокуратура, судьи.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2, "Ранее престижная серия, ныне не дающая никаких привилегий.");
                        break;
                    case "EKX":
                        rusNumber.SetData(2,
                            "Исключительно у частных лиц, большое количество владельцев одного из районов Карелии.");
                        break;
                }

                break;
            case 11:
                switch (rusNumber.Let)
                {
                    case "BAT":
                        rusNumber.SetData(2,
                            "Правительство республики, впоследствии заменили на OOO, далее на ТТТ.");
                        break;
                    case "PPP":
                        rusNumber.SetData(2, "Прокуратура.");
                        break;
                    case "YYY":
                        rusNumber.SetData(2, "Следственный Комитет при Прокуратуре.");
                        break;
                    case "TTT":
                        rusNumber.SetData(2, "Правительство республики, ФСБ республики.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2, "Полублатная серия, руководители крупных промышленных компаний.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "МВД по РК, часть отдана в частные руки.");
                        break;
                    case "XXX":
                    case "CCC":
                    case "KKK":
                        rusNumber.SetData(2, "Личные автомобили полицейских. Часть номеров ездит в такси.");
                        break;
                    case "EKX":
                        rusNumber.SetData(2,
                            "Полублатная серия, после проверки прокуратуры \"простые\" номера были выданы в частные руки.");
                        break;
                    case "KCK":
                        rusNumber.SetData(2, "Полублатная серия.");
                        break;
                }

                break;
            case 14:
                switch (rusNumber.Let)
                {
                    case "MMM":
                        rusNumber.SetData(2, "Серия автомобилей МВД.");
                        break;
                    case "HHH":
                    case "CCC":
                    case "TTT":
                    case "CKA":
                        rusNumber.SetData(2, "Полублатная серия.");
                        break;
                    case "PPP":
                        rusNumber.SetData(2, "Прокуратура.");
                        break;
                    case "MEH":
                        rusNumber.SetData(2, "Серия автомобилей УФСБ по Республике Саха (Якутия).");
                        break;
                    case "AAA":
                        rusNumber.SetData(2,
                            "Автобаза президента, правительства и парламента республики, а также руководство госпредприятий.");
                        break;
                    case "AAY":
                        rusNumber.SetData(2, "Администрация МО Город Якутск.");
                        break;
                }

                break;
            case 16:
                switch (rusNumber.Let)
                {
                    case "MMM":
                    case "BMM":
                        rusNumber.SetData(2,
                            "Серия автомобилей МВД, на которую были заменены \"синие\" номера автомобилей, \"попавших под сокращение\".");
                        break;
                    case "MPT":
                        rusNumber.SetData(2, "Серия автомобилей МВД (Милиция Республики Татарстан).");
                        break;
                    case "BKM":
                        rusNumber.SetData(2, "Серия автомобилей МВД (Казанская милиция).");
                        break;
                    case "BPM":
                        rusNumber.SetData(2, "Ранее серия автомобилей МВД (Республиканская милиция).");
                        break;
                    case "BTM":
                        rusNumber.SetData(2,
                            "Серия автомобилей чиновников госаппарата, МВД, прокуратуры, а также после 200 — начальников и директоров крупных предприятий.");
                        break;
                    case "OAA":
                        rusNumber.SetData(2,
                            "Серия автомобилей правительства республики, а также глав администраций городов и районов. \"Особо Авторитетный Автомобиль\".");
                        break;
                    case "PAO":
                        rusNumber.SetData(2, "Мэрия г. Казани.");
                        break;
                    case "TTT":
                        rusNumber.SetData(2, "Блатная серия под названием \"три туза\".");
                        break;
                    case "PCK":
                        rusNumber.SetData(2, "Следственный комитет при прокуратуре РФ по Республике Татарстан.");
                        break;
                }

                break;
            case 18:
                switch (rusNumber.Let)
                {
                    case "AAA":
                        rusNumber.SetData(2, "Администрация Удмуртской Республики.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2,
                            "Высшие должностные лица предприятий и заводов Удмуртской Республики.");
                        break;
                }

                break;
            case 22:
                switch (rusNumber.Let)
                {
                    case "AAA":
                    case "TTT":
                    case "YYY":
                        rusNumber.SetData(2, "Редкие блатные серии.");
                        break;
                    case "PPP":
                        rusNumber.SetData(2,
                            "Ранее администрации Алтайского края и городов, сейчас частично Прокуратура, различные органы власти и организации, а также \"просто\" граждане.");
                        break;
                    case "XXX":
                        rusNumber.SetData(2,
                            "Старая серия автомобилей ГИБДД, до замены их на \"синие\". Назывались Хавалкинские Хахатушки.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2, "Администрация Алтайского края, по два номера у краевого суда и МЧС.");
                        break;
                    case "KKK":
                    case "CCC":
                    case "HHH":
                    case "MMM":
                        rusNumber.SetData(2,
                            "Коммерческая серия, созданная ГИБДД исключительно из экономических соображений.");
                        break;
                    case "MYK":
                        rusNumber.SetData(2,
                            "ГУВД Алтайского края. Неофициально расшифровывается как \"Милицейское Управление Края\".");
                        break;
                    case "MOB":
                        rusNumber.SetData(2, "УВД г. Барнаула, районные ОВД г. Барнаула.");
                        break;
                    case "MOP":
                    case "MOC":
                        rusNumber.SetData(2, "Районные и сельские ОВД Алтайского края.");
                        break;
                    case "ACK":
                        rusNumber.SetData(2, "Следственное управление СК при прокуратуре РФ по АК.");
                        break;
                }

                break;
            case 23:
                switch (rusNumber.Let)
                {
                    case "PPP":
                        rusNumber.SetData(2, "Администрации Краснодарского края и городов, частники.");
                        break;
                    case "HHH":
                        rusNumber.SetData(2, "Налоговые службы Краснодарского края.");
                        break;
                    case "OOO":
                    case "AAA":
                        rusNumber.SetData(2,
                            "В основном принадлежит депутатам и администрации районов, есть и у влиятельных частников.");
                        break;
                    case "АСК":
                        rusNumber.SetData(2, "Суды Краснодарского края.");
                        break;
                    case "AAB":
                        rusNumber.SetData(2, "Прокуратура Краснодарского края.");
                        break;
                    case "AHB":
                        rusNumber.SetData(2,
                            "Транспортная прокуратура, внештатные сотрудники Краснодарского края.");
                        break;
                    case "AAC":
                        rusNumber.SetData(2,
                            "Законодательное собрание, депутаты краевого собрания Краснодарского края.");
                        break;
                    case "TTT":
                        if (rusNumber.Num >= 500 && rusNumber.Num <= 800)
                            rusNumber.SetData(3, "Таможня Краснодарского края и городов.");
                        break;
                    case "CKC":
                        if (rusNumber.Num <= 200) rusNumber.SetData(3, "ФСО РФ.");
                        break;
                    case "CCM":
                        if (rusNumber.Num <= 100) rusNumber.SetData(3, "Администрация г. Сочи.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2,
                            "Большая часть в штатах милиции, но есть и у частников-силовков Краснодарского края.");
                        break;
                    case "CCC":
                        if (rusNumber.Num < 10 || rusNumber.Num % 100 == 0 || rusNumber.Num == 11 ||
                            rusNumber.Num % 111 == 0) rusNumber.SetData(3, "Блатные серии.");
                        break;
                    case "KAA":
                        rusNumber.SetData(2, "Администрации города Краснодара и муниципальных учреждений.");
                        break;
                    case "YYY":
                        rusNumber.SetData(2, "Машины МВД, встречаются на личных машинах сотрудников.");
                        break;
                }

                break;
            case 24:
                switch (rusNumber.Let)
                {
                    case "KPK":
                    case "OOO":
                        rusNumber.SetData(2,
                            "Администрация Красноярского края, Законодательное Собрание Красноярского края.");
                        break;
                    case "AOO":
                        rusNumber.SetData(2, "Администрация города Красноярска, городской Совет.");
                        break;
                    case "MKK":
                    case "MCK":
                        rusNumber.SetData(2, "Ранее, МВД.");
                        break;
                    case "KCM":
                        rusNumber.SetData(2, "Автомобили оперативных подразделений МВД.");
                        break;
                    case "BCP":
                        rusNumber.SetData(2, "Судьи.");
                        break;
                    case "TTT":
                        rusNumber.SetData(2, "Блатная серия.");
                        break;
                }

                break;
            case 25:
                switch (rusNumber.Let)
                {
                    case "MOO":
                        rusNumber.SetData(2, "Краевые структуры УВД, МЧС, пожарные и др. спец. службы.");
                        break;
                    case "BOO":
                        rusNumber.SetData(2, "Городские службы УВД г. Владивостока и районов, военные.");
                        break;
                    case "AAA":
                        rusNumber.SetData(2, "Первая серия во Владивостоке.");
                        break;
                    case "HHH":
                        rusNumber.SetData(2,
                            "Серия администрации Владивостока, личные автомобили депутатов городской думы.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "Депутаты Законодательного собрания края созыва 2002 года.");
                        break;
                    case "CCC":
                        rusNumber.SetData(2, "Администрация Приморского края.");
                        break;
                    case "XXX":
                        rusNumber.SetData(2, "УВД и прокуратура.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2,
                            "Ранее, при губернаторе Евгении Наздратенко, администрация Приморского края.");
                        break;
                    case "TTT":
                        rusNumber.SetData(2,
                            "Ранее, при мэре Юрии Копылове, администрация Владивостока и федеральные структуры в Приморском крае.");
                        break;
                    case "HOO":
                        rusNumber.SetData(2,
                            "Службы УВД, ГИБДД и др. Юго-восточного региона Приморского края (г. Находка).");
                        break;
                    case "YOO":
                        rusNumber.SetData(2,
                            "Службы УВД, ГИБДД и др Центрального региона Приморского края (г. Уссурийск).");
                        break;
                    case "COO":
                        rusNumber.SetData(2,
                            "Службы УВД, ГИБДД и др Северного региона Приморского края (г. Спасск-Дальний).");
                        break;
                }

                break;
            case 29:
                switch (rusNumber.Let)
                {
                    case "PPP":
                        rusNumber.SetData(2, "Администрация Архангельской области с 2007 года.");
                        break;
                    case "MAO":
                    case "MAA":
                    case "MMM":
                        rusNumber.SetData(2, "Милиция Архангельской области.");
                        break;
                    case "EPE":
                        rusNumber.SetData(2,
                            "Зачастую установлены на автомобилях функционеров партии \"Единая Россия\".");
                        break;
                    case "TTT":
                        rusNumber.SetData(2, "Разные государственные органы Архангельской области.");
                        break;
                }

                break;
            case 31:
                switch (rusNumber.Let)
                {
                    case "AAA":
                        rusNumber.SetData(2,
                            "Администрация области, администрация города Белгорода и Белгородского район.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "МВД и авторитетные личности.");
                        break;
                    case "KKK":
                        if (rusNumber.Num < 100) rusNumber.SetData(3, "Чиновники из ГИББД.");
                        break;
                    case "XXX":
                        rusNumber.SetData(2, "Состоятельные частники. Также мусоровозы и ассенизаторские машины.");
                        break;
                    case "YMM":
                        rusNumber.SetData(2, "МВД вперемешку с частниками, так называемая \"Усиленная\" серия.");
                        break;
                    case "YYM":
                        rusNumber.SetData(2, "Участковые.");
                        break;
                    case "PPP":
                        rusNumber.SetData(2, "Прокуратура области.");
                        break;
                }

                break;
            case 33:
                switch (rusNumber.Let)
                {
                    case "ABO":
                    case "AAA":
                        rusNumber.SetData(2, "Администрация Владимирской области.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2, "Блатная серия.");
                        break;
                    case "OOM":
                    case "COP":
                        rusNumber.SetData(2, "Номера милиции.");
                        break;
                }

                break;
            case 35:
                switch (rusNumber.Let)
                {
                    case "AAA":
                        if (rusNumber.Num == 1)
                            rusNumber.SetData(5, "Губернатор Вологодской области.");
                        else
                            rusNumber.SetData(2,
                                "Правительство Вологодской области и администрации города Вологды.");
                        break;
                    case "AOO":
                        rusNumber.SetData(2, "Правительство Вологодской области и администрации города Вологды.");
                        break;
                    case "ABO":
                        rusNumber.SetData(2, "Мэрия г. Вологды.");
                        break;
                    case "ACK":
                        rusNumber.SetData(2, "Следственный комитет при прокуратуре по Вологодской области.");
                        break;
                    case "AHB":
                        rusNumber.SetData(2, "ГУВД по Вологодской области.");
                        break;
                    case "ABY":
                        rusNumber.SetData(2, "Мэрия г. Череповца.");
                        break;
                    case "OOO":
                    case "CCC":
                    case "TTT":
                        if (rusNumber.Num <= 100) rusNumber.SetData(3, "Блатная серия.");
                        break;
                }

                break;
            case 36:
                switch (rusNumber.Let)
                {
                    case "AAA":
                        rusNumber.SetData(2, "Администрация Воронежской области.");
                        break;
                    case "BOA":
                        rusNumber.SetData(2, "Воронежская областная администрация.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "Прокуратура Воронежской области.");
                        break;
                    case "TTT":
                        rusNumber.SetData(2, "ГУВД по Воронежской области, частники.");
                        break;
                    case "XXX":
                        rusNumber.SetData(2, "Судьи.");
                        break;
                    case "CCC":
                        rusNumber.SetData(2, "УГИБДД ГУВД по Воронежской области, частники.");
                        break;
                    case "BBB":
                    case "EEE":
                    case "KKK":
                    case "HHH":
                    case "OOO":
                    case "PPP":
                    case "YYY":
                    case "EKX":
                        rusNumber.SetData(2, "Блатная серия.");
                        break;
                }

                break;
            case 39:
                switch (rusNumber.Let)
                {
                    case "AAK":
                        rusNumber.SetData(2, "Администрация Калининградской области, УФСБ, прокуратура.");
                        break;
                    case "KKK":
                        rusNumber.SetData(2,
                            "Администрация Калининградской области. Позже продавались как блатные.");
                        break;
                    case "PPP":
                        rusNumber.SetData(2, "Администрация Калининградской области при губернаторе Боосе.");
                        break;
                    case "TTT":
                        rusNumber.SetData(2, "УВД Калининградской области.");
                        break;
                    case "PTP":
                        rusNumber.SetData(2, "Серия, которая пришла на смену триколоров.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2, "Прокуратура Калининградской области.");
                        break;
                    case "KMK":
                        rusNumber.SetData(2, "Управление ГИБДД по калининградской области.");
                        break;
                    case "AAE":
                        rusNumber.SetData(2, "Разного рода Государственные управления по Калининградской области.");
                        break;
                }

                break;
            case 40:
                switch (rusNumber.Let)
                {
                    case "MAA":
                        rusNumber.SetData(2,
                            "Серия автомобилей органов внутренних дел до ввода синих номеров. Сейчас снова активно выдается.");
                        break;
                    case "MAB":
                        rusNumber.SetData(2,
                            "Серия автомобилей ОВД и личных автомобилей сотрудников ОВД, а также приближенных к ним.");
                        break;
                    case "AAA":
                        if (rusNumber.Num <= 200)
                            rusNumber.SetData(3, "Серия автомобилей администрации области, города, ГУПов и МУПов.");
                        else
                            rusNumber.SetData(2, "Личные авто приближенных к власти.");
                        break;
                    case "PPP":
                        rusNumber.SetData(2, "Прокуратура.");
                        break;
                    case "EMM":
                        rusNumber.SetData(2, "Новая милицейская серия.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2,
                            "Серия выдавалась особо приближенным лицам по личному распоряжению началника УВД.");
                        break;
                    case "XXX":
                        if (rusNumber.Num <= 100) rusNumber.SetData(3, "Судьи.");
                        break;
                }

                break;
            case 42:
                switch (rusNumber.Let)
                {
                    case "AKO":
                        rusNumber.SetData(2, "Ранее администрация Кемеровской области.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2, "Старая серия администрации Кемеровской области.");
                        break;
                    case "TTT":
                        rusNumber.SetData(2, "Новая серия администрации Кемеровской области.");
                        break;
                    case "PPP":
                        rusNumber.SetData(2, "Прокуратура Кемеровской области.");
                        break;
                    case "KYM":
                        rusNumber.SetData(2, "Серия Начальника ГУВД.");
                        break;
                    case "AKM":
                        rusNumber.SetData(2, "Администрация Кемерово.");
                        break;
                    case "EKX":
                    case "AAA":
                        rusNumber.SetData(2, "Очень редкая и дорогая серия.");
                        break;
                }

                break;
            case 43:
                switch (rusNumber.Let)
                {
                    case "AKO":
                        rusNumber.SetData(2, "Администрация Кировской области. ");
                        break;
                    case "MKO":
                        rusNumber.SetData(2, "Органы внутренних дел Кировской области.");
                        break;
                    case "AAA":
                    case "BBB":
                    case "OOO":
                    case "CCC":
                    case "TTT":
                    case "XXX":
                        rusNumber.SetData(2,
                            "В разное время выдавались как частным лицам, так и различным органам власти.");
                        break;
                }

                break;
            case 45:
                switch (rusNumber.Let)
                {
                    case "OOO":
                        rusNumber.SetData(2, "Бывшая серия администрации Курганской области.");
                        break;
                    case "TTT":
                        rusNumber.SetData(2, "Администрация Курганской области.");
                        break;
                    case "OKO":
                        rusNumber.SetData(2, "Прокуратура Курганской области.");
                        break;
                    case "KCK":
                        rusNumber.SetData(2, "СУ СК при прокуратуре РФ по Курганской области.");
                        break;
                }

                break;
            case 47:
                switch (rusNumber.Let)
                {
                    case "OKO":
                        if (rusNumber.Num == 20) rusNumber.SetData(5, "Прокуратура ЛО.");
                        break;
                    case "OOA":
                        if (rusNumber.Num == 1 || rusNumber.Num == 99)
                            rusNumber.SetData(5, "Губернатор ЛО.");
                        else if (rusNumber.Num < 100) rusNumber.SetData(3, "Администрация ЛО.");
                        break;
                    case "OAO":
                        if (rusNumber.Num / 100 == 7)
                            rusNumber.SetData(3, "ФСБ.");
                        else if (rusNumber.Num / 100 == 6)
                            rusNumber.SetData(3, "Таможня и ГУИН.");
                        else
                            rusNumber.SetData(2, "Администрация ЛО.");
                        break;
                    case "OTY":
                        if (rusNumber.Num < 200)
                            rusNumber.SetData(3, "Северо-Западное Таможенное управление ФТС России.");
                        break;
                    case "OOM":
                        rusNumber.SetData(2, "ГУИН и ФСБ.");
                        break;
                    case "OMO":
                        rusNumber.SetData(2, "МВД ЛО.");
                        break;
                }

                break;
            case 52:
                switch (rusNumber.Let)
                {
                    case "AAA":
                        rusNumber.SetData(2, "Администрация Нижегородской области.");
                        break;
                    case "AHH":
                    case "TKA":
                    case "AHM":
                    case "EHM":
                        rusNumber.SetData(2, "ГУВД по Нижегородской области.");
                        break;
                    case "BHM":
                        rusNumber.SetData(2, "Спецтранспорт МВД.");
                        break;
                    case "EEE":
                        rusNumber.SetData(2, "Таможня.");
                        break;
                    case "HHH":
                        rusNumber.SetData(2, "Коммерческие организации, подведомственные администрации.");
                        break;
                    case "OAO":
                    case "TTT":
                        rusNumber.SetData(2, "Полномочные представители в Приволжском Федеральном округе.");
                        break;
                    case "PPP":
                        rusNumber.SetData(2, "Прокуратура.");
                        break;
                    case "CCC":
                        rusNumber.SetData(2, "УФСБ.");
                        break;
                    case "CHM":
                        rusNumber.SetData(2, "Структуры МВД.");
                        break;
                }

                break;
            case 53:
                switch (rusNumber.Let)
                {
                    case "MMM":
                        if (rusNumber.Num <= 100)
                            rusNumber.SetData(3, "УВД, до введения синих номеров, позже раздана частникам.");
                        break;
                    case "AAA":
                        rusNumber.SetData(2, "Администрация Великого новгорода и области.");
                        break;
                    case "OOO":
                        if (rusNumber.Num <= 300) rusNumber.SetData(3, "УВД.");
                        break;
                }

                break;
            case 54:
                switch (rusNumber.Let)
                {
                    case "AAA":
                        rusNumber.SetData(2, "Полномочные представители Президента РФ.");
                        break;
                    case "HHH":
                        rusNumber.SetData(2, "Администрация Новосибирской области.");
                        break;
                    case "ACK":
                        rusNumber.SetData(2, "ФСБ.");
                        break;
                    case "PPP":
                    case "MOP":
                    case "HCO":
                        rusNumber.SetData(2, "УГИБДД.");
                        break;
                }

                break;
            case 57:
                switch (rusNumber.Let)
                {
                    case "AOO":
                        rusNumber.SetData(2, "Администрация Орловской области.");
                        break;
                    case "CKP":
                        rusNumber.SetData(2, "Следственный комитет РФ, прокуратура.");
                        break;
                    case "MAA":
                    case "MMM":
                    case "MOK":
                    case "MOO":
                        rusNumber.SetData(2, "МВД.");
                        break;
                }

                break;
            case 61:
                switch (rusNumber.Let)
                {
                    case "APO":
                        rusNumber.SetData(2, "Администрация Ростовской области.");
                        break;
                    case "AAA":
                        rusNumber.SetData(2, "Администрация Ростова.");
                        break;
                    case "KKK":
                        rusNumber.SetData(2, "Полномочные представители Президента РФ.");
                        break;
                    case "HHH":
                        rusNumber.SetData(2, "Прокуратура.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "ОВД.");
                        break;
                }

                break;
            case 64:
                if (rusNumber.Let[0] == 'T' && rusNumber.Num == 64)
                    rusNumber.SetData(3, "Городская Дума Саратовской области.");
                else
                    switch (rusNumber.Let)
                    {
                        case "OBB":
                            if (rusNumber.Num < 200) rusNumber.SetData(3, "Правительство Саратовской области.");
                            break;
                        case "BBP":
                            if (rusNumber.Num / 100 == 2)
                                rusNumber.SetData(3, "ФСБ.");
                            else
                                rusNumber.SetData(2, "МВД.");
                            break;
                    }

                break;
            case 69:
                switch (rusNumber.Let)
                {
                    case "ATB":
                        rusNumber.SetData(2, "Администрация города Твери.");
                        break;
                    case "ATO":
                        rusNumber.SetData(2, "Администрация Тверской области.");
                        break;
                    case "CCC":
                        rusNumber.SetData(2, "Законодательное собрание Тверской области и города Твери.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "Служебные автомобили полиции Тверской области и города Твери.");
                        break;
                }

                break;
            case 70:
                switch (rusNumber.Let)
                {
                    case "OTO":
                        rusNumber.SetData(2, "Администрация Томской области.");
                        break;
                    case "BMA":
                        rusNumber.SetData(2, "Водитель Милицейского Автомобиля.");
                        break;
                }

                break;
            case 77:
                switch (rusNumber.Let)
                {
                    case "XKX":
                        rusNumber.SetData(2, "Частично ФСБ Москвы.");
                        break;
                    case "AOO":
                    case "BOO":
                    case "MOO":
                    case "COO":
                        rusNumber.SetData(2, "Автомобили управления делами Президента.");
                        break;
                    case "KOO":
                        rusNumber.SetData(2, "Конституционный Суд РФ.");
                        break;
                    case "PMP":
                        rusNumber.SetData(2, "Министерство Юстиции, ФСИН, прокуратура.");
                        break;
                    case "AMP":
                    case "BMP":
                    case "KMP":
                    case "MMP":
                    case "OMP":
                    case "TMP":
                    case "YMP":
                        rusNumber.SetData(2, "Частично МВД, ФСБ, подведомственное подчинение.");
                        break;
                    case "AMO":
                        rusNumber.SetData(2, "Мэрия Москвы.");
                        break;
                    case "EKX":
                        rusNumber.SetData(2, "ФСО РФ.");
                        break;
                    case "CAC":
                        if (rusNumber.Num >= 500) rusNumber.SetData(3, "ФСК, ФСБ.");
                        break;
                    case "AMM":
                        rusNumber.SetData(2, "Бывшая серия МВД РФ.");
                        break;
                    case "CCC":
                        rusNumber.SetData(2, "Центр спецсвязи, Фельдъегерская служба.");
                        break;
                    case "OOO":
                        rusNumber.SetData(2, "До 1998 года принадлежали ФСБ.");
                        break;
                    case "KMM":
                        rusNumber.SetData(2, "Пожарная охрана.");
                        break;
                }

                break;
            case 78:
                switch (rusNumber.Let)
                {
                    case "AAA":
                        rusNumber.SetData(2, "Органы исполнительной власти СПб.");
                        break;
                    case "OOO":
                        if (rusNumber.Num >= 900)
                            rusNumber.SetData(3, "ФСО.");
                        else
                            rusNumber.SetData(2, "Администрация СПб.");
                        break;
                    case "OKO":
                        if (rusNumber.Num / 100 == 7) rusNumber.SetData(3, "ФСБ.");
                        if (rusNumber.Num / 100 == 8) rusNumber.SetData(3, "Министерство Юстиций.");
                        if (rusNumber.Num / 100 == 9)
                            rusNumber.SetData(3, "ФАПСИ и Федеральная Фельдъегерская Служба СПб.");
                        if (rusNumber.Num < 700) rusNumber.SetData(2, "Прокуратура СПб.");
                        break;
                    case "OOA":
                        if (rusNumber.Num < 200)
                            rusNumber.SetData(3, "ФНС, управления Федерального Казначейства, ЛенЭнерго.");
                        break;
                    case "OAO":
                        if (rusNumber.Num / 100 == 7)
                            rusNumber.SetData(3, "ФСБ.");
                        else if (rusNumber.Num / 100 == 6)
                            rusNumber.SetData(3, "Таможня и ГУИН.");
                        else
                            rusNumber.SetData(2, "Администрация СПб.");
                        break;
                    case "OOC":
                        if (rusNumber.Num == 100)
                            rusNumber.SetData(5, "Путин В. В.");
                        else
                            rusNumber.SetData(2, "МВД, МИД, ФСБ.");
                        break;
                    case "OCM":
                        if (rusNumber.Num / 100 == 7 || rusNumber.Num / 100 == 9)
                            rusNumber.SetData(3, "ФСБ.");
                        else
                            rusNumber.SetData(2, "Смольный, Администрация СПб.");
                        break;
                    case "OOH":
                        rusNumber.SetData(2, "ГНК и ФНС.");
                        break;
                    case "MMM":
                    case "MMA":
                    case "MME":
                    case "MAE":
                    case "MMB":
                        rusNumber.SetData(2, "Закрытые предприятия (Адмиралтейские Верфи, Банк России и т.п.).");
                        break;
                    case "OOM":
                        rusNumber.SetData(2, "ГУИН и ФСБ.");
                        break;
                    case "OTT":
                        if (rusNumber.Num / 100 == 0 && rusNumber.Num / 10 == 2)
                            rusNumber.SetData(3, "Полномочные представители Президента РФ.");
                        break;
                    case "OMM":
                        rusNumber.SetData(2, "Бывшие РУВД.");
                        break;
                    case "OMO":
                        rusNumber.SetData(2, "МВД.");
                        break;
                    case "OTY":
                        if (rusNumber.Num < 200)
                            rusNumber.SetData(3, "Северо-Западное Таможенное управление ФТС России.");
                        break;
                }

                break;
            case 93:
                switch (rusNumber.Let)
                {
                    case "OOO":
                    case "AAA":
                        rusNumber.SetData(2,
                            "Большинство у влиятельных частников, также есть у администраций районов.");
                        break;
                    case "KKK":
                        rusNumber.SetData(2, "Администрация Краснодарского края.");
                        break;
                    case "MKK":
                        rusNumber.SetData(2, "Милиция Краснодарского края.");
                        break;
                    case "AHY":
                        if (rusNumber.Num < 10)
                            rusNumber.SetData(4,
                                "Высокопоставленные сотрудники УГИБДД ГУВД по Краснодарскому краю.");
                        break;
                    case "EKX":
                        rusNumber.SetData(2, "ФСО РФ.");
                        break;
                    case "MMM":
                        rusNumber.SetData(2, "У частников, в основном с силовыми ксивами.");
                        break;
                    case "YYY":
                        if (rusNumber.Num >= 200 && rusNumber.Num <= 400) rusNumber.SetData(3, "Газпром.");
                        break;
                    case "CCC":
                        rusNumber.SetData(2, "Следственный комитет при прокуратуре Краснодарского края.");
                        break;
                    case "MOC":
                    case "BOC":
                    case "MOK":
                        if (rusNumber.Num <= 100)
                            rusNumber.SetData(3, "\"Олимпстрой\" и всё, что связано с олимпиадой.");
                        break;
                }

                break;
            case 97:
                switch (rusNumber.Let)
                {
                    case "EKX":
                        rusNumber.SetData(2, "ФСО Москвы.");
                        break;
                    case "AMP":
                        switch (rusNumber.Num)
                        {
                            case 1:
                                rusNumber.SetData(5, "Шувалов И. И.");
                                break;
                            case 2:
                                rusNumber.SetData(5, "Нарышкин С. Е.");
                                break;
                            case 3:
                                rusNumber.SetData(5, "Козак Д. Н.");
                                break;
                            case 4:
                                rusNumber.SetData(5, "Жуков А. Д.");
                                break;
                            case 5:
                                rusNumber.SetData(5, "Кудрин А. Л.");
                                break;
                            case 6:
                                rusNumber.SetData(5, "Гордеев А. В.");
                                break;
                            case 7:
                                rusNumber.SetData(5, "Набиуллина Э. С.");
                                break;
                            case 8:
                                rusNumber.SetData(5, "Левитин И. Е.");
                                break;
                            case 9:
                                rusNumber.SetData(5, "Нургалиев Р. Г.");
                                break;
                            case 10:
                                rusNumber.SetData(5, "Трутнев Ю. П.");
                                break;
                            case 11:
                                rusNumber.SetData(5, "Фурсенко А. А.");
                                break;
                            case 13:
                                rusNumber.SetData(5, "Мутко В. Л.");
                                break;
                            case 14:
                                rusNumber.SetData(5, "Шайгу С. К.");
                                break;
                            case 15:
                                rusNumber.SetData(5, "Марков О. А.");
                                break;
                            case 16:
                                rusNumber.SetData(5, "Басаргин В. Ф.");
                                break;
                            case 17:
                                rusNumber.SetData(5, "Авдеев А. А.");
                                break;
                            case 18:
                                rusNumber.SetData(5, "Путилин В. Н.");
                                break;
                            case 19:
                                rusNumber.SetData(5, "Осипов Ю. С.");
                                break;
                            case 20:
                                rusNumber.SetData(5, "Сурков В. Ю.");
                                break;
                            case 22:
                                rusNumber.SetData(5, "Игнатьев С. М.");
                                break;
                            case 23:
                                rusNumber.SetData(5, "Абрамов А. С.");
                                break;
                            case 24:
                                rusNumber.SetData(5, "Василевская Е. И.");
                                break;
                            case 25:
                                rusNumber.SetData(5, "Кожин В. И.");
                                break;
                            case 26:
                                rusNumber.SetData(5, "Приходько С. Э.");
                                break;
                            case 27:
                                rusNumber.SetData(5, "Беглов А. Д.");
                                break;
                            case 28:
                                rusNumber.SetData(5, "Брычева Л. И.");
                                break;
                            case 29:
                                rusNumber.SetData(5, "Шматко С. И.");
                                break;
                            case 30:
                                rusNumber.SetData(5, "Христенко В. Б.");
                                break;
                            case 31:
                                rusNumber.SetData(5, "Дворкович А. В.");
                                break;
                            case 33:
                                rusNumber.SetData(5, "Голикова Т. А.");
                                break;
                            case 34:
                                rusNumber.SetData(5, "Лаптев Ю. К.");
                                break;
                            case 35:
                                rusNumber.SetData(5, "Лесин М. Ю.");
                                break;
                            case 37:
                                rusNumber.SetData(5, "Соболев С. А.");
                                break;
                            case 38:
                                rusNumber.SetData(5, "Чуйченко К. А.");
                                break;
                            case 39:
                                rusNumber.SetData(5, "Шевченко В. Н.");
                                break;
                            case 40:
                                rusNumber.SetData(5, "Яковлев В. Ф.");
                                break;
                            case 41:
                                rusNumber.SetData(5, "Щеголов И. О.");
                                break;
                            case 42:
                                rusNumber.SetData(5, "Рейман Л. Д.");
                                break;
                            case 43:
                                rusNumber.SetData(5, "Громов А. А.");
                                break;
                            case 44:
                                rusNumber.SetData(5, "Нагайцев В. Н.");
                                break;
                            case 45:
                                rusNumber.SetData(5, "Копейкин М. Ю.");
                                break;
                            case 46:
                                rusNumber.SetData(5, "Рыжков Д. А.");
                                break;
                            case 47:
                                rusNumber.SetData(5, "Боровков И. В.");
                                break;
                            case 48:
                                rusNumber.SetData(5, "Голованов В. В.");
                                break;
                            case 49:
                                rusNumber.SetData(5, "Вуколов В. Л.");
                                break;
                            case 50:
                                rusNumber.SetData(5, "Кокунов В. А.");
                                break;
                            case 51:
                                rusNumber.SetData(5, "Ренев В. В.");
                                break;
                            case 52:
                                rusNumber.SetData(5, "Манжосин А. Л.");
                                break;
                            case 53:
                                rusNumber.SetData(5, "Говорун О. М.");
                                break;
                            case 54:
                                rusNumber.SetData(5, "Жуйков Д. С.");
                                break;
                            case 55:
                                rusNumber.SetData(5, "Осипов В. Б.");
                                break;
                            case 56:
                                rusNumber.SetData(5, "Тимакова Н. А.");
                                break;
                            case 57:
                                rusNumber.SetData(5, "Ентальцева М. В.");
                                break;
                            case 58:
                                rusNumber.SetData(5, "Фирсова Т. Н.");
                                break;
                            case 60:
                                rusNumber.SetData(5, "Дубик С. Н.");
                                break;
                            case 71:
                                rusNumber.SetData(5, "Винокуров С. Ю.");
                                break;
                            case 72:
                                rusNumber.SetData(5, "Котенков А. А.");
                                break;
                            case 73:
                                rusNumber.SetData(5, "Минх Г. В.");
                                break;
                            case 74:
                                rusNumber.SetData(5, "Кротов М. В.");
                                break;
                            case 78:
                                rusNumber.SetData(5, "Тринога М. И.");
                                break;
                            case 79:
                                rusNumber.SetData(5, "Песков Д. С.");
                                break;
                            case 80:
                                rusNumber.SetData(5, "Иванов В. П.");
                                break;
                            case 81:
                                rusNumber.SetData(5, "Смирнов И. А.");
                                break;
                            case 82:
                                rusNumber.SetData(5, "Стржалковский В. И.");
                                break;
                            case 83:
                                rusNumber.SetData(5, "Дроздов А. В.");
                                break;
                            case 84:
                                rusNumber.SetData(5, "Калашников С. В.");
                                break;
                            case 85:
                                rusNumber.SetData(5, "Ковальчук Б. Ю.");
                                break;
                            case 86:
                                rusNumber.SetData(5, "Лычагин М. И.");
                                break;
                            case 87:
                                rusNumber.SetData(5, "Барщевский. М. Ю.");
                                break;
                            case 88:
                                rusNumber.SetData(5, "Моисеев. Н. Ф.");
                                break;
                            case 89:
                                rusNumber.SetData(5, "Молчанов. Д. В.");
                                break;
                            case 90:
                                rusNumber.SetData(5, "Минх Г. В.");
                                break;
                            case 91:
                                rusNumber.SetData(5, "Пушкарева О. С.");
                                break;
                            case 92:
                                rusNumber.SetData(5, "Яцкин. А. В.");
                                break;
                            case 93:
                                rusNumber.SetData(5, "Ряховский А. Д.");
                                break;
                            case 94:
                                rusNumber.SetData(5, "Сеньковская М. Ю.");
                                break;
                            case 95:
                                rusNumber.SetData(5, "Смирных А. М.");
                                break;
                            case 96:
                                rusNumber.SetData(5, "Герасимов С. И.");
                                break;
                            case 97:
                                rusNumber.SetData(5, "Суходольский М. И.");
                                break;
                            case 98:
                                rusNumber.SetData(5, "Школов Е. М.");
                                break;
                            case 99:
                                rusNumber.SetData(5, "Овчинников Н. А.");
                                break;
                            case 100:
                                rusNumber.SetData(5, "Кирьянов В. Н.");
                                break;
                            case 101:
                                rusNumber.SetData(5, "Логинов А. В.");
                                break;
                            case 104:
                                rusNumber.SetData(5, "Смирнов А. Ю.");
                                break;
                            case 106:
                                rusNumber.SetData(5, "Одинцова Ж. А.");
                                break;
                            case 109:
                                rusNumber.SetData(5, "Вайно А. Э.");
                                break;
                            case 113:
                                rusNumber.SetData(5, "Рушайло В. Б.");
                                break;
                            case 114:
                                rusNumber.SetData(5, "Воробьев Ю. Л.");
                                break;
                            case 121:
                                rusNumber.SetData(5, "Морозов О. В.");
                                break;
                            case 122:
                                rusNumber.SetData(5, "Слиска Л. К.");
                                break;
                            case 124:
                                rusNumber.SetData(5, "Жириновский В. В.");
                                break;
                            case 133:
                                rusNumber.SetData(5, "Бездлелов. Д. А.");
                                break;
                            case 134:
                                rusNumber.SetData(5, "Боллоев Т. К.");
                                break;
                            case 135:
                                rusNumber.SetData(5, "Крайний А. А.");
                                break;
                            case 136:
                                rusNumber.SetData(5, "Счетная палата РФ.");
                                break;
                            case 141:
                                rusNumber.SetData(5, "Кехлеров С. Г.");
                                break;
                            case 143:
                                rusNumber.SetData(5, "Бастрыкин. А. И.");
                                break;
                            case 177:
                                rusNumber.SetData(5, "Семин Ю. Ю.");
                                break;
                            case 202:
                                rusNumber.SetData(5, "Чуров В. Е.");
                                break;
                            case 216:
                                rusNumber.SetData(5, "Дашков П. П.");
                                break;
                            case 234:
                                rusNumber.SetData(5, "Ромодановский. К. О.");
                                break;
                            case 237:
                                rusNumber.SetData(5, "Махаметшин. Ф. М.");
                                break;
                            case 240:
                                rusNumber.SetData(5, "Дмитриев М. А.");
                                break;
                            case 254:
                                rusNumber.SetData(5, "Герций Ю. В.");
                                break;
                            case 266:
                                rusNumber.SetData(5, "Козлов С. Н.");
                                break;
                            case 277:
                                rusNumber.SetData(5, "Колокольцев В. А.");
                                break;
                            case 296:
                                rusNumber.SetData(5, "Кириллов В. В.");
                                break;
                            case 300:
                                rusNumber.SetData(5, "Элькин Г. И.");
                                break;
                            case 302:
                                rusNumber.SetData(5, "Сеславинский М. В.");
                                break;
                            case 320:
                                rusNumber.SetData(5, "Масляков В. Н.");
                                break;
                            case 321:
                                rusNumber.SetData(5, "Рогожкин Н. Е.");
                                break;
                            case 326:
                                rusNumber.SetData(5, "Матвеев С. Е.");
                                break;
                            case 333:
                                rusNumber.SetData(5, "Кирьянов. В. Н.");
                                break;
                            case 340:
                                rusNumber.SetData(5, "Павленко С. Ю.");
                                break;
                            case 341:
                                rusNumber.SetData(5, "Артюхин. Р. Е.");
                                break;
                            case 362:
                                rusNumber.SetData(5, "Лужков. Ю. М.");
                                break;
                            case 368:
                                rusNumber.SetData(5, "Шмаков М. В.");
                                break;
                            case 370:
                                rusNumber.SetData(5, "Бордюжа Н. Н.");
                                break;
                            case 373:
                                rusNumber.SetData(5, "Чуприян А. П.");
                                break;
                            case 375:
                                rusNumber.SetData(5, "Михалков Н. С.");
                                break;
                            case 376:
                                rusNumber.SetData(5, "Карасин Г. Б.");
                                break;
                            case 381:
                                rusNumber.SetData(5, "Григоров С. И.");
                                break;
                            case 382:
                                rusNumber.SetData(5, "Аброскин Н. П.");
                                break;
                            case 383:
                                rusNumber.SetData(5, "Петров Ю. А.");
                                break;
                            case 384:
                                rusNumber.SetData(5, "Калинин Ю. И.");
                                break;
                            case 388:
                                rusNumber.SetData(5, "Винниченко. Н. А.");
                                break;
                            case 389:
                                rusNumber.SetData(5, "Царенко А. В.");
                                break;
                            case 390:
                                rusNumber.SetData(5, "Онищенко Г. Г.");
                                break;
                            case 391:
                                rusNumber.SetData(5, "Алешин Б. С.");
                                break;
                            case 405:
                                rusNumber.SetData(5, "Магомедо М. М.");
                                break;
                            case 416:
                                rusNumber.SetData(5, "Миннинханов Р. Н.");
                                break;
                            case 432:
                                rusNumber.SetData(5, "Денин Н. В.");
                                break;
                            case 443:
                                rusNumber.SetData(5, "Белых Н. Ю.");
                                break;
                            case 450:
                                rusNumber.SetData(5, "Громов Б. В.");
                                break;
                            case 469:
                                rusNumber.SetData(5, "Зеленин Д. В.");
                                break;
                            case 471:
                                rusNumber.SetData(5, "Дудка В. Д.");
                                break;
                            case 477:
                                rusNumber.SetData(5, "Ресин В. И.");
                                break;
                            case 480:
                                rusNumber.SetData(5, "Чуян И. П.");
                                break;
                            case 481:
                                rusNumber.SetData(5, "Никитин Н. Е.");
                                break;
                            case 484:
                                rusNumber.SetData(5, "Седов К. В.");
                                break;
                            case 485:
                                rusNumber.SetData(5, "Гогин Д. Ю.");
                                break;
                            case 489:
                                rusNumber.SetData(5, "Неелов Ю. В.");
                                break;
                            case 499:
                                rusNumber.SetData(5, "Мишустин М. В.");
                                break;
                            case 500:
                                rusNumber.SetData(5, "Корниенко Г. А.");
                                break;
                            case 510:
                                rusNumber.SetData(5, "Нелидов А. В.");
                                break;
                            case 564:
                                rusNumber.SetData(5, "Радаев В. В.");
                                break;
                            case 571:
                                rusNumber.SetData(5, "Панченко И. В.");
                                break;
                            case 580:
                                rusNumber.SetData(5, "Цицин К. Г.");
                                break;
                            case 581:
                                rusNumber.SetData(5, "Малинин В. М.");
                                break;
                            case 582:
                                rusNumber.SetData(5, "Черкесов В. В.");
                                break;
                            case 584:
                                rusNumber.SetData(5, "Эрнст К. Л.");
                                break;
                            case 588:
                                rusNumber.SetData(5, "Якунин В. И.");
                                break;
                            case 590:
                                rusNumber.SetData(5, "Чубайс А. Б.");
                                break;
                            case 591:
                                rusNumber.SetData(5, "Вайншток С. М.");
                                break;
                            case 592:
                                rusNumber.SetData(5, "Чемезов С. В.");
                                break;
                            case 593:
                                rusNumber.SetData(5, "Миллер А. Б.");
                                break;
                            case 594:
                                rusNumber.SetData(5, "Тягачев Л. В.");
                                break;
                            case 595:
                                rusNumber.SetData(5, "Бородин П. П.");
                                break;
                            case 596:
                                rusNumber.SetData(5, "Рапота Г. А.");
                                break;
                            case 597:
                                rusNumber.SetData(5, "Лебедев С. Н.");
                                break;
                            case 598:
                                rusNumber.SetData(5, "Костин А. Л.");
                                break;
                            case 599:
                                rusNumber.SetData(5, "Дмитриев В. А.");
                                break;
                            case 600:
                                rusNumber.SetData(5, "Казьмин А. И.");
                                break;
                            case 601:
                                rusNumber.SetData(5, "Чиханчин Ю. А.");
                                break;
                            case 612:
                                rusNumber.SetData(5, "Зелин А. Н.");
                                break;
                            case 619:
                                rusNumber.SetData(5, "Мокрецов М. П.");
                                break;
                            case 620:
                                rusNumber.SetData(5, "Мокрецов М. П.");
                                break;
                            case 699:
                                rusNumber.SetData(5, "Назаров В. Л.");
                                break;
                            case 700:
                                rusNumber.SetData(5, "Артемьев И. Ю.");
                                break;
                            case 701:
                                rusNumber.SetData(5, "Нерадько А. В.");
                                break;
                            case 702:
                                rusNumber.SetData(5, "Новиков С. Г.");
                                break;
                            case 703:
                                rusNumber.SetData(5, "Бедрицкий А. И.");
                                break;
                            case 704:
                                rusNumber.SetData(5, "Соколин В. Л.");
                                break;
                            case 706:
                                rusNumber.SetData(5, "Кутьин Н. Г.");
                                break;
                            case 707:
                                rusNumber.SetData(5, "Бельянинов А. Ю.");
                                break;
                            case 708:
                                rusNumber.SetData(5, "Кириенко С. В.");
                                break;
                            case 709:
                                rusNumber.SetData(5, "Поповкин В. А.");
                                break;
                            case 900:
                                rusNumber.SetData(5, "Сечин И. И.");
                                break;
                            case 902:
                                rusNumber.SetData(5, "Нарышкин С. Е.");
                                break;
                            case 903:
                                rusNumber.SetData(5, "Кручинин В. А.");
                                break;
                            case 904:
                                rusNumber.SetData(5, "Зорькин В. Д.");
                                break;
                            case 905:
                                rusNumber.SetData(5, "Лебедев В. М.");
                                break;
                            case 906:
                                rusNumber.SetData(5, "Иванов А. А.");
                                break;
                            case 908:
                                rusNumber.SetData(5, "Секретариат Президента РФ");
                                break;
                            case 909:
                                rusNumber.SetData(5, "Иванов С. Б.");
                                break;
                            case 910:
                                rusNumber.SetData(5, "Устинов В. В.");
                                break;
                            case 911:
                                rusNumber.SetData(5, "Лавров С. В.");
                                break;
                            case 912:
                                rusNumber.SetData(5, "Собянин С. С.");
                                break;
                            case 914:
                                rusNumber.SetData(5, "Ломакин-Румянцев И. В.");
                                break;
                            case 915:
                                rusNumber.SetData(5, "Зубков В. А.");
                                break;
                            case 916:
                                rusNumber.SetData(5, "Цыбулин А. М.");
                                break;
                            case 918:
                                rusNumber.SetData(5, "Осипов С. Н.");
                                break;
                            case 919:
                                rusNumber.SetData(5, "Коновалов А. В.");
                                break;
                            case 920:
                                rusNumber.SetData(5, "Скороспелов П. П.");
                                break;
                            case 921:
                                rusNumber.SetData(5, "Булавин В. И.");
                                break;
                            case 922:
                                rusNumber.SetData(5, "Ушаков С. К.");
                                break;
                            case 923:
                                rusNumber.SetData(5, "Болховитин С. Н.");
                                break;
                            case 924:
                                rusNumber.SetData(5, "Михеев Н. М.");
                                break;
                            case 988:
                                rusNumber.SetData(5, "Кулистиков В. М.");
                                break;
                            case 990:
                                rusNumber.SetData(5, "Добродеев О. Б.");
                                break;
                            case 992:
                                rusNumber.SetData(5, "Калашников С. В.");
                                break;
                            case 993:
                                rusNumber.SetData(5, "Игнатенко В. Н.");
                                break;
                            case 995:
                                rusNumber.SetData(5, "Скрынник Е. Б.");
                                break;
                            case 997:
                                rusNumber.SetData(5, "Чубайс А. Б.");
                                break;
                            case 998:
                                rusNumber.SetData(5, "Путилин В. Н.");
                                break;
                            case 999:
                                rusNumber.SetData(5, "Муров Е. А.");
                                break;
                            case { } n when n >= 371 && n <= 374:
                                rusNumber.SetData(4, "МЧС РФ.");
                                break;
                            case { } n when n >= 377 && n <= 380:
                                rusNumber.SetData(4, "МИД РФ.");
                                break;
                            case { } n when n >= 385 && n <= 387:
                                rusNumber.SetData(4, "ФСИН РФ.");
                                break;
                            case { } n when n >= 401 && n <= 479:
                                rusNumber.SetData(4,
                                    "Губернаторы, руководители исполнительных органов власти субъектов РФ.");
                                break;
                            case { } n when n >= 501 && n <= 588:
                                rusNumber.SetData(4,
                                    "Спикеры, руководители законодательных органов власти субъектов РФ.");
                                break;
                            case { } n when n >= 602 && n <= 621:
                                rusNumber.SetData(4, "Министерство Обороны РФ.");
                                break;
                            case { } n when n >= 622 && n <= 660:
                            case { } n1 when n1 >= 673 && n1 <= 690:
                                rusNumber.SetData(4, "Государственная Фельдъегерская Служба РФ.");
                                break;
                            case { } n when n >= 661 && n <= 672:
                                rusNumber.SetData(4, "Фельдсвязь РФ.");
                                break;
                            case { } n when n >= 691 && n <= 697:
                                rusNumber.SetData(4, "ФСКН РФ.");
                                break;
                            case { } n when n >= 712 && n <= 899:
                            case 913:
                                rusNumber.SetData(3, "ФСБ РФ.");
                                break;
                            case 12:
                            case 21:
                            case 59:
                            case 112:
                            case 243:
                            case 248:
                            case 249:
                            case 256:
                            case 261:
                            case 265:
                            case 283:
                            case 285:
                            case 286:
                            case 299:
                            case 301:
                            case 327:
                            case 334:
                            case 337:
                            case 338:
                            case 339:
                            case 342:
                            case 358:
                            case 482:
                            case 483:
                            case 486:
                            case 487:
                            case { } n when n >= 490 && n <= 498:
                            case 589:
                            case 907:
                                rusNumber.SetData(4, "Резервные номера правительства РФ.");
                                break;
                            case 32:
                            case 36:
                            case 70:
                            case 75:
                            case 705:
                            case 917:
                                rusNumber.SetData(4, "Отдел ТО и регистрации.");
                                break;
                            case { } n when n >= 61 && n <= 69:
                                rusNumber.SetData(4, "Управление делами Президента РФ.");
                                break;
                            case 76:
                            case 77:
                            case { } n when n >= 392 && n <= 400:
                            case 698:
                            case 710:
                            case 711:
                            case { } n1 when n1 >= 925 && n1 <= 987:
                            case 989:
                            case 991:
                            case 994:
                            case 996:
                                rusNumber.SetData(4, "ФСО РФ.");
                                break;
                            case 102:
                            case 103:
                            case 105:
                            case 107:
                            case 108:
                            case 110:
                            case 111:
                                rusNumber.SetData(4, "Аппарат правительства РФ.");
                                break;
                            case { } n when n >= 115 && n <= 120:
                                rusNumber.SetData(4, "Совет Федерации Федерального Собрания РФ.");
                                break;
                            case 123:
                            case { } n when n >= 125 && n <= 132:
                                rusNumber.SetData(4, "Госдума РФ.");
                                break;
                            case { } n when n >= 137 && n < 202:
                                rusNumber.SetData(4, "Генеральная Прокуратура РФ.");
                                break;
                            case { } n when n >= 203 && n < 370:
                                rusNumber.SetData(3,
                                    "Министерство Внутренних Дел РФ и другие федеральные структуры.");
                                break;
                            default:
                                rusNumber.SetData(3,
                                    "Главная федеральная спецсерия автономеров в Российской Федерации, которой заменили флаговые номера.");
                                break;
                        }

                        break;
                }

                break;
            case 98:
                switch (rusNumber.Let)
                {
                    case "OOO":
                    case "AAA":
                        rusNumber.SetData(2, "Администрация СПб.");
                        break;
                    case "OKO":
                        if (rusNumber.Num < 100)
                            rusNumber.SetData(3, "Прокуратура СПб.");
                        else if (rusNumber.Num < 200)
                            rusNumber.SetData(3, "Прокуратура ЛО.");
                        else if (rusNumber.Num / 100 == 2 || rusNumber.Num / 100 == 3 || rusNumber.Num / 100 == 7)
                            rusNumber.SetData(3, "Федеральная Служба судебных приставов, Министерство юстиции РФ.");
                        else if (rusNumber.Num / 100 == 9) rusNumber.SetData(3, "Судебный департамент при ВС РФ.");
                        break;
                    case "OCK":
                        rusNumber.SetData(2,
                            "Следственное управление следственного комитета при Генеральной прокуратуре.");
                        break;
                    case "OKC":
                        rusNumber.SetData(2, "Конституционный Суд РФ, Управление делами Президента РФ.");
                        break;
                    case "OOA":
                        if (rusNumber.Num <= 50) rusNumber.SetData(4, "Депутаты ЗАКСа.");
                        break;
                    case "OAO":
                        if (rusNumber.Num / 100 == 7) rusNumber.SetData(3, "ФСБ.");
                        break;
                    case "OAA":
                        rusNumber.SetData(2, "ФСБ, МВД.");
                        break;
                    case "OOH":
                        if (rusNumber.Num < 200) rusNumber.SetData(3, "ГНК и ФНС.");
                        break;
                    case "OAC":
                        rusNumber.SetData(2, "Арбитражный суд.");
                        break;
                    case "EKX":
                        rusNumber.SetData(2, "ФСБ и ФСО.");
                        break;
                    case "OOM":
                        rusNumber.SetData(2, "ГУИН и ФСБ.");
                        break;
                    case "OTT":
                        if (rusNumber.Num / 10 == 6 || rusNumber.Num / 10 == 7)
                            rusNumber.SetData(3, "Полномочные представители Президента РФ.");
                        else
                            rusNumber.SetData(2, "У ГИБДД по СПб и ЛО.");
                        break;
                    case "OCA":
                        rusNumber.SetData(2, "У ГИБДД по СПб и ЛО.");
                        break;
                    case "OMM":
                        rusNumber.SetData(2, "УВДТ, ССШМ.");
                        break;
                    case "OBO":
                        rusNumber.SetData(2, "Вневедомственая Охрана, ОМОН.");
                        break;
                    case "OPP":
                        rusNumber.SetData(2, "ГУВД СПб и ЛО.");
                        break;
                    case "OМО":
                        rusNumber.SetData(2, "МВД.");
                        break;
                    case "OMP":
                        rusNumber.SetData(2, "ГУВД СПб и ЛО, Милиция России.");
                        break;
                }

                break;
            case 99:
                switch (rusNumber.Let)
                {
                    case "EKX":
                        rusNumber.SetData(2, "Автомобили ФСО. Серия пришла на смену ЕКХ77.");
                        break;
                    case "HAA":
                    case "TAA":
                    case "CAA":
                    case "XAA":
                        rusNumber.SetData(2,
                            "\"Закрытые\" в базах машины. Почти все – у транспорта, принадлежащего ФСБ, различным НИИ и \"почтовым ящикам\".");
                        break;
                    case "AAA":
                        if (rusNumber.Num == 271) rusNumber.SetData(5, "Жириновский В. В.");
                        break;
                }

                break;
            case 102:
                switch (rusNumber.Let)
                {
                    case "CKC":
                        rusNumber.SetData(2,
                            "Часть номеров с 2008 года закреплена за депутатами Государственного Собрания — Курултая.");
                        break;
                    case "POO":
                        rusNumber.SetData(2,
                            "Выдаётся на автомобили руководителей крупных предприятий и министерств.");
                        break;
                    case "CCC":
                        if (rusNumber.Num <= 100) rusNumber.SetData(3, "Прокуратура РБ.");
                        break;
                }

                break;
            case 116:
                switch (rusNumber.Let)
                {
                    case "BOB":
                        rusNumber.SetData(2, "Серия автомобилей участников Великой Отечественной Войны.");
                        break;
                }

                break;
            case 125:
                switch (rusNumber.Let)
                {
                    case "EEE":
                        rusNumber.SetData(2, "ФСБ.");
                        break;
                    case "AAA":
                        rusNumber.SetData(2,
                            "Прокуратура Приморского края, одна из самых \"блатных\" серий, выдается только по указанию прокурора края.");
                        break;
                    case "MBK":
                        rusNumber.SetData(2,
                            "\"Блатной\" номер сотрудников УВД. Расшифровка — \"менты\" Владивостока. Ведомственные номера УВД Приморского края.");
                        break;
                    case "MBB":
                        rusNumber.SetData(2, "Ведомственный номер сотрудников МВД г. Владивосток.");
                        break;
                    case "MOO":
                        rusNumber.SetData(2,
                            "Краевые структуры УВД, МЧС, пожарные и др. спец. службы. Много номеров у коммерсантов.");
                        break;
                    case "BOO":
                        rusNumber.SetData(2,
                            "Городские службы УВД г. Владивостока и районов, часть куплено коммерсантами.");
                        break;
                    case "HOO":
                        rusNumber.SetData(2,
                            "Службы УВД, ГИБДД и др. Юго-восточного региона Приморского края (г. Находка).");
                        break;
                    case "YOO":
                        rusNumber.SetData(2,
                            "Службы УВД, ГИБДД и др Центрального региона Приморского края (г. Уссурийск).");
                        break;
                    case "COO":
                        rusNumber.SetData(2,
                            "Службы УВД, ГИБДД и др Северного региона Приморского края (г. Спасск-Дальний).");
                        break;
                }

                break;
            case 159:
                switch (rusNumber.Let)
                {
                    case "MMM":
                        rusNumber.SetData(2, "МВД.");
                        break;
                }

                break;
            case 164:
                switch (rusNumber.Let)
                {
                    case "ACA":
                        rusNumber.SetData(2, "Правительство Саратовской области.");
                        break;
                    case "РРР":
                        rusNumber.SetData(2, "Областная прокуратура.");
                        break;
                }

                break;
            case 177:
                switch (rusNumber.Let)
                {
                    case "AKP":
                    case "BKP":
                    case "EKP":
                    case "KKP":
                        rusNumber.SetData(2, "Замена \"синьке\".");
                        break;
                    case "EPE":
                        rusNumber.SetData(2, "Замена флаговым номерам.");
                        break;
                }

                break;
            case 178:
                switch (rusNumber.Let)
                {
                    case "HBB":
                        rusNumber.SetData(2, "Администрация СПб.");
                        break;
                }

                break;
        }

        if (rusNumber.Rang == 0 && rusNumber.Let[0] == rusNumber.Let[1] && rusNumber.Let[0] == rusNumber.Let[2]) rusNumber.SetData(1, "Одинаковые буквы.");
        if (rusNumber.Num == 0) rusNumber.SetData(0, "Неверный номер.");
        if (rusNumber.Num % 111 == 0) rusNumber.SetData(1, "Одинаковые цифры.");
    }
}