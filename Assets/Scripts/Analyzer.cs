public static class Analyzer
{
	public static void AnalyzeNumber(Number number)
	{
		number.ClearData();

		var region = int.Parse(number.Region);
		
		switch (region)
		{
			case 2:
				switch (number.Series)
				{
					case "PKC":
					case "KKC":
						number.AddData(2,
							"Автомобили законодательного органа республики — Государственного Собрания — Курултая\n");
						break;
					case "CKP":
						number.AddData(2, "Собрание Курултая Республики\n");
						break;
					case "MMM":
						if (number.Digits <= 100) number.AddData(3, "Прокуратура\n");
						break;
					case "YYY":
						if (number.Digits < 11) number.AddData(4, "Руководители администрации города Уфы\n");
						break;
					case "AAA":
						switch (number.Digits)
						{
							case 20:
								number.AddData(5, "Глава Администрации городского округа город Уфа\n");
								break;
							case 100:
								number.AddData(5, "Президент Республики Башкортостан\n");
								break;
							case 200:
								number.AddData(5,
									"Председатель Государственного Собрания Курултай Республики Башкортостан\n");
								break;
							case 300:
								number.AddData(5, "Премьер—министр Правительства Республики Башкортостан\n");
								break;
							default:
								number.AddData(2,
									"Номера автомобилей Членов Правительства, руководителей Администрации Президента и самого Президента Республики Башкортостан и глав администрации районов и городов РБ\n");
								break;
						}

						break;
					case "AMM":
						if (number.Digits > 100)
							number.AddData(2,
								"До замены спецсерии номеров автомобилей на \"синие\" данная серия полностью принадлежала автомобилям МВД\n");
						else
							number.AddData(3,
								"C 001—100 выдавались высокопоставленным сотрудникам правоохранительных и силовых структур РБ\n");
						break;
					case "YMM":
					case "OMM":
						number.AddData(2, "Выдавались высшим руководством УГИБДД МВД РБ\n");
						break;
					case "BMM":
						number.AddData(2,
							"Выдавались высшим руководством УГИБДД РБ и МВД РБ юридическим лицам\n");
						break;
					case "OOO":
						number.AddData(2,
							"Серия устанавливалась на автомобили руководителей крупных предприятий, министерств\n");
						break;
				}

				break;
			case 4:
				switch (number.Series)
				{
					case "CCC":
						number.AddData(2, "Судьи\n");
						break;
					case "HHH":
						number.AddData(2, "Налоговая служба\n");
						break;
					case "OOO":
						number.AddData(2, "Руководство республики\n");
						break;
					case "MPA":
						number.AddData(2, "МВД республики\n");
						break;
					case "PPP":
					case "PPA":
						number.AddData(2, "Прокуратура республики\n");
						break;
					case "BAM":
					case "TTT":
					case "XXX":
						number.AddData(2, "Редкая блатная серия\n");
						break;
				}

				break;
			case 8:
				switch (number.Series)
				{
					case "CCC":
						number.AddData(2, "Прокуратура Республики Калмыкия, судьи\n");
						break;
					case "OOO":
						if (number.Digits <= 200) number.AddData(3, "Депутаты народного парламента\n");
						break;
					case "MMM":
						number.AddData(2, "ГУВД по Республике Калмыкия\n");
						break;
					case "AAA":
						number.AddData(2, "Администрация Республики Калмыкия\n");
						break;
				}

				break;
			case 10:
				switch (number.Series)
				{
					case "TTT":
						number.AddData(2, "Правительство республики, ФСБ республики, есть и у частников\n");
						break;
					case "HHH":
						if (number.Digits <= 200)
							number.AddData(3,
								"Серия автомобилей администраций городов и районов республики, есть и у частников\n");
						break;
					case "MMM":
						number.AddData(2, "Серия автомобилей МВД, есть и у частников\n");
						break;
					case "EMP":
						number.AddData(2,
							"Серия автомобилей МВД, на которую были заменены \"синие\" номера автомобилей \"попавших под сокращение\"\n");
						break;
					case "CCC":
						number.AddData(2, "Прокуратура, судьи\n");
						break;
					case "OOO":
						number.AddData(2, "Ранее престижная серия, ныне не дающая никаких привилегий\n");
						break;
					case "EKX":
						number.AddData(2,
							"Исключительно у частных лиц, большое количество владельцев одного из районов Карелии\n");
						break;
				}

				break;
			case 11:
				switch (number.Series)
				{
					case "BAT":
						number.AddData(2,
							"Правительство республики, впоследствии заменили на OOO, далее на ТТТ\n");
						break;
					case "PPP":
						number.AddData(2, "Прокуратура\n");
						break;
					case "YYY":
						number.AddData(2, "Следственный Комитет при Прокуратуре\n");
						break;
					case "TTT":
						number.AddData(2, "Правительство республики, ФСБ республики\n");
						break;
					case "OOO":
						number.AddData(2, "Полублатная серия, руководители крупных промышленных компаний\n");
						break;
					case "MMM":
						number.AddData(2, "МВД по РК, часть отдана в частные руки\n");
						break;
					case "XXX":
					case "CCC":
					case "KKK":
						number.AddData(2, "Личные автомобили полицейских, часть номеров ездит в такси\n");
						break;
					case "EKX":
						number.AddData(2,
							"Полублатная серия, после проверки прокуратуры \"простые\" номера были выданы в частные руки\n");
						break;
					case "KCK":
						number.AddData(2, "Полублатная серия\n");
						break;
				}

				break;
			case 14:
				switch (number.Series)
				{
					case "MMM":
						number.AddData(2, "Серия автомобилей МВД\n");
						break;
					case "HHH":
					case "CCC":
					case "TTT":
					case "CKA":
						number.AddData(2, "Полублатная серия\n");
						break;
					case "PPP":
						number.AddData(2, "Прокуратура\n");
						break;
					case "MEH":
						number.AddData(2, "Серия автомобилей УФСБ по Республике Саха (Якутия)\n");
						break;
					case "AAA":
						number.AddData(2,
							"Автобаза Президента, правительства и парламента республики, а также руководство госпредприятий\n");
						break;
					case "AAY":
						number.AddData(2, "Администрация МО Город Якутск\n");
						break;
				}

				break;
			case 16:
				switch (number.Series)
				{
					case "MMM":
					case "BMM":
						number.AddData(2,
							"Серия автомобилей МВД, на которую были заменены \"синие\" номера автомобилей, \"попавших под сокращение\"\n");
						break;
					case "MPT":
						number.AddData(2, "Серия автомобилей МВД (Милиция Республики Татарстан)\n");
						break;
					case "BKM":
						number.AddData(2, "Серия автомобилей МВД (Казанская милиция)\n");
						break;
					case "BPM":
						number.AddData(2, "Ранее серия автомобилей МВД (Республиканская милиция)\n");
						break;
					case "BTM":
						number.AddData(2,
							"Серия автомобилей чиновников госаппарата, МВД, прокуратуры, а также после 200 — начальников и директоров крупных предприятий\n");
						break;
					case "OAA":
						number.AddData(2,
							"Серия автомобилей правительства республики, а также глав администраций городов и районов\n");
						break;
					case "PAO":
						number.AddData(2, "Мэрия города Казани\n");
						break;
					case "TTT":
						number.AddData(2, "Блатная серия под названием \"три туза\"\n");
						break;
					case "PCK":
						number.AddData(2, "Следственный комитет при прокуратуре РФ по Республике Татарстан\n");
						break;
				}

				break;
			case 18:
				switch (number.Series)
				{
					case "AAA":
						number.AddData(2, "Администрация Удмуртской Республики\n");
						break;
					case "OOO":
						number.AddData(2,
							"Высшие должностные лица предприятий и заводов Удмуртской Республики\n");
						break;
				}

				break;
			case 22:
				switch (number.Series)
				{
					case "AAA":
					case "TTT":
					case "YYY":
						number.AddData(2, "Редкие блатные серии\n");
						break;
					case "PPP":
						number.AddData(2,
							"Ранее администрации Алтайского края и городов, сейчас частично Прокуратура, различные органы власти и организации, а также \"просто\" граждане\n");
						break;
					case "XXX":
						number.AddData(2,
							"Старая серия автомобилей ГИБДД, до замены их на \"синие\", Хавалкинские Хахатушки\n");
						break;
					case "OOO":
						number.AddData(2, "Администрация Алтайского края, по два номера у краевого суда и МЧС\n");
						break;
					case "KKK":
					case "CCC":
					case "HHH":
					case "MMM":
						number.AddData(2,
							"Коммерческая серия, созданная ГИБДД исключительно из экономических соображений\n");
						break;
					case "MYK":
						number.AddData(2,
							"ГУВД Алтайского края, неофициально расшифровывается как \"Милицейское Управление Края\"\n");
						break;
					case "MOB":
						number.AddData(2, "УВД города Барнаула, районные ОВД города Барнаула\n");
						break;
					case "MOP":
					case "MOC":
						number.AddData(2, "Районные и сельские ОВД Алтайского края\n");
						break;
					case "ACK":
						number.AddData(2, "Следственное управление СК при прокуратуре РФ по АК\n");
						break;
				}

				break;
			case 23:
				switch (number.Series)
				{
					case "PPP":
						number.AddData(2, "Администрации Краснодарского края и городов, частники\n");
						break;
					case "HHH":
						number.AddData(2, "Налоговые службы Краснодарского края\n");
						break;
					case "OOO":
					case "AAA":
						number.AddData(2,
							"В основном принадлежит депутатам и администрации районов, есть и у влиятельных частников\n");
						break;
					case "АСК":
						number.AddData(2, "Суды Краснодарского края\n");
						break;
					case "AAB":
						number.AddData(2, "Прокуратура Краснодарского края\n");
						break;
					case "AHB":
						number.AddData(2,
							"Транспортная прокуратура, внештатные сотрудники Краснодарского края\n");
						break;
					case "AAC":
						number.AddData(2,
							"Законодательное собрание, депутаты краевого собрания Краснодарского края\n");
						break;
					case "TTT":
						if (number.Digits >= 500 && number.Digits <= 800)
							number.AddData(3, "Таможня Краснодарского края и городов\n");
						break;
					case "CKC":
						if (number.Digits <= 200) number.AddData(3, "ФСО РФ\n");
						break;
					case "CCM":
						if (number.Digits <= 100) number.AddData(3, "Администрация города Сочи\n");
						break;
					case "MMM":
						number.AddData(2,
							"Большая часть в штатах милиции, но есть и у частников-силовков Краснодарского края\n");
						break;
					case "CCC":
						if (number.Digits < 10 || number.Digits % 100 == 0 || number.Digits == 11 ||
						    number.Digits % 111 == 0) number.AddData(3, "Блатные серии\n");
						break;
					case "KAA":
						number.AddData(2, "Администрации города Краснодара и муниципальных учреждений\n");
						break;
					case "YYY":
						number.AddData(2, "Машины МВД, встречаются на личных машинах сотрудников\n");
						break;
				}

				break;
			case 24:
				switch (number.Series)
				{
					case "KPK":
					case "OOO":
						number.AddData(2,
							"Администрация Красноярского края, Законодательное Собрание Красноярского края\n");
						break;
					case "AOO":
						number.AddData(2, "Администрация города Красноярска, городской Совет\n");
						break;
					case "MKK":
					case "MCK":
						number.AddData(2, "Ранее, МВД\n");
						break;
					case "KCM":
						number.AddData(2, "Автомобили оперативных подразделений МВД\n");
						break;
					case "BCP":
						number.AddData(2, "Судьи\n");
						break;
					case "TTT":
						number.AddData(2, "Блатная серия\n");
						break;
				}

				break;
			case 25:
				switch (number.Series)
				{
					case "MOO":
						number.AddData(2, "Краевые структуры УВД, МЧС, пожарные и другие спецслужбы\n");
						break;
					case "BOO":
						number.AddData(2, "Городские службы УВД города Владивостока и районов, военные\n");
						break;
					case "AAA":
						number.AddData(2, "Первая серия во Владивостоке\n");
						break;
					case "HHH":
						number.AddData(2,
							"Серия администрации Владивостока, личные автомобили депутатов городской думы\n");
						break;
					case "MMM":
						number.AddData(2, "Депутаты Законодательного собрания края созыва 2002 года\n");
						break;
					case "CCC":
						number.AddData(2, "Администрация Приморского края\n");
						break;
					case "XXX":
						number.AddData(2, "УВД и прокуратура\n");
						break;
					case "OOO":
						number.AddData(2,
							"Ранее, при губернаторе Евгении Наздратенко, администрация Приморского края\n");
						break;
					case "TTT":
						number.AddData(2,
							"Ранее, при мэре Юрии Копылове, администрация Владивостока и федеральные структуры в Приморском крае\n");
						break;
					case "HOO":
						number.AddData(2,
							"Службы УВД, ГИБДД и другие Юго-восточного региона Приморского края (город Находка)\n");
						break;
					case "YOO":
						number.AddData(2,
							"Службы УВД, ГИБДД и другие Центрального региона Приморского края (город Уссурийск)\n");
						break;
					case "COO":
						number.AddData(2,
							"Службы УВД, ГИБДД и другие Северного региона Приморского края (город Спасск-Дальний)\n");
						break;
				}

				break;
			case 29:
				switch (number.Series)
				{
					case "PPP":
						number.AddData(2, "Администрация Архангельской области с 2007 года\n");
						break;
					case "MAO":
					case "MAA":
					case "MMM":
						number.AddData(2, "Милиция Архангельской области\n");
						break;
					case "EPE":
						number.AddData(2,
							"Зачастую установлены на автомобилях функционеров партии \"Единая Россия\"\n");
						break;
					case "TTT":
						number.AddData(2, "Разные государственные органы Архангельской области\n");
						break;
				}

				break;
			case 31:
				switch (number.Series)
				{
					case "AAA":
						number.AddData(2,
							"Администрация области, администрация города Белгорода и Белгородского район\n");
						break;
					case "MMM":
						number.AddData(2, "МВД и авторитетные личности\n");
						break;
					case "KKK":
						if (number.Digits < 100) number.AddData(3, "Чиновники из ГИББД\n");
						break;
					case "XXX":
						number.AddData(2, "Состоятельные частники, а также мусоровозы и ассенизаторские машины\n");
						break;
					case "YMM":
						number.AddData(2, "МВД вперемешку с частниками, так называемая \"Усиленная\" серия\n");
						break;
					case "YYM":
						number.AddData(2, "Участковые\n");
						break;
					case "PPP":
						number.AddData(2, "Прокуратура области\n");
						break;
				}

				break;
			case 33:
				switch (number.Series)
				{
					case "ABO":
					case "AAA":
						number.AddData(2, "Администрация Владимирской области\n");
						break;
					case "OOO":
						number.AddData(2, "Блатная серия\n");
						break;
					case "OOM":
					case "COP":
						number.AddData(2, "Номера милиции\n");
						break;
				}

				break;
			case 35:
				switch (number.Series)
				{
					case "AAA":
						if (number.Digits == 1)
							number.AddData(5, "Губернатор Вологодской области\n");
						else
							number.AddData(2,
								"Правительство Вологодской области и администрации города Вологды\n");
						break;
					case "AOO":
						number.AddData(2, "Правительство Вологодской области и администрации города Вологды\n");
						break;
					case "ABO":
						number.AddData(2, "Мэрия города Вологды\n");
						break;
					case "ACK":
						number.AddData(2, "Следственный комитет при прокуратуре по Вологодской области\n");
						break;
					case "AHB":
						number.AddData(2, "ГУВД по Вологодской области\n");
						break;
					case "ABY":
						number.AddData(2, "Мэрия города Череповца\n");
						break;
					case "OOO":
					case "CCC":
					case "TTT":
						if (number.Digits <= 100) number.AddData(3, "Блатная серия\n");
						break;
				}

				break;
			case 36:
				switch (number.Series)
				{
					case "AAA":
						number.AddData(2, "Администрация Воронежской области\n");
						break;
					case "BOA":
						number.AddData(2, "Воронежская областная администрация\n");
						break;
					case "MMM":
						number.AddData(2, "Прокуратура Воронежской области\n");
						break;
					case "TTT":
						number.AddData(2, "ГУВД по Воронежской области, частники\n");
						break;
					case "XXX":
						number.AddData(2, "Судьи\n");
						break;
					case "CCC":
						number.AddData(2, "УГИБДД ГУВД по Воронежской области, частники\n");
						break;
					case "BBB":
					case "EEE":
					case "KKK":
					case "HHH":
					case "OOO":
					case "PPP":
					case "YYY":
					case "EKX":
						number.AddData(2, "Блатная серия\n");
						break;
				}

				break;
			case 39:
				switch (number.Series)
				{
					case "AAK":
						number.AddData(2, "Администрация Калининградской области, УФСБ, прокуратура\n");
						break;
					case "KKK":
						number.AddData(2,
							"Администрация Калининградской области, позже продавались как блатные\n");
						break;
					case "PPP":
						number.AddData(2, "Администрация Калининградской области при губернаторе Боосе\n");
						break;
					case "TTT":
						number.AddData(2, "УВД Калининградской области\n");
						break;
					case "PTP":
						number.AddData(2, "Серия, которая пришла на смену триколоров\n");
						break;
					case "OOO":
						number.AddData(2, "Прокуратура Калининградской области\n");
						break;
					case "KMK":
						number.AddData(2, "Управление ГИБДД по калининградской области\n");
						break;
					case "AAE":
						number.AddData(2, "Разного рода Государственные управления по Калининградской области\n");
						break;
				}

				break;
			case 40:
				switch (number.Series)
				{
					case "MAA":
						number.AddData(2,
							"Серия автомобилей органов внутренних дел до ввода синих номеров, сейчас снова активно выдается\n");
						break;
					case "MAB":
						number.AddData(2,
							"Серия автомобилей ОВД и личных автомобилей сотрудников ОВД, а также приближенных к ним\n");
						break;
					case "AAA":
						if (number.Digits <= 200)
							number.AddData(3, "Серия автомобилей администрации области, города, ГУПов и МУПов\n");
						else
							number.AddData(2, "Личные авто приближенных к власти\n");
						break;
					case "PPP":
						number.AddData(2, "Прокуратура\n");
						break;
					case "EMM":
						number.AddData(2, "Новая милицейская серия\n");
						break;
					case "OOO":
						number.AddData(2,
							"Серия выдавалась особо приближенным лицам по личному распоряжению началника УВД\n");
						break;
					case "XXX":
						if (number.Digits <= 100) number.AddData(3, "Судьи\n");
						break;
				}

				break;
			case 42:
				switch (number.Series)
				{
					case "AKO":
						number.AddData(2, "Ранее администрация Кемеровской области\n");
						break;
					case "OOO":
						number.AddData(2, "Старая серия администрации Кемеровской области\n");
						break;
					case "TTT":
						number.AddData(2, "Новая серия администрации Кемеровской области\n");
						break;
					case "PPP":
						number.AddData(2, "Прокуратура Кемеровской области\n");
						break;
					case "KYM":
						number.AddData(2, "Серия Начальника ГУВД\n");
						break;
					case "AKM":
						number.AddData(2, "Администрация Кемерово\n");
						break;
					case "EKX":
					case "AAA":
						number.AddData(2, "Очень редкая и дорогая серия\n");
						break;
				}

				break;
			case 43:
				switch (number.Series)
				{
					case "AKO":
						number.AddData(2, "Администрация Кировской области\n");
						break;
					case "MKO":
						number.AddData(2, "Органы внутренних дел Кировской области\n");
						break;
					case "AAA":
					case "BBB":
					case "OOO":
					case "CCC":
					case "TTT":
					case "XXX":
						number.AddData(2,
							"В разное время выдавались как частным лицам, так и различным органам власти\n");
						break;
				}

				break;
			case 45:
				switch (number.Series)
				{
					case "OOO":
						number.AddData(2, "Бывшая серия администрации Курганской области\n");
						break;
					case "TTT":
						number.AddData(2, "Администрация Курганской области\n");
						break;
					case "OKO":
						number.AddData(2, "Прокуратура Курганской области\n");
						break;
					case "KCK":
						number.AddData(2, "СУ СК при прокуратуре РФ по Курганской области\n");
						break;
				}

				break;
			case 47:
				switch (number.Series)
				{
					case "OKO":
						if (number.Digits == 20) number.AddData(5, "Прокуратура ЛО\n");
						break;
					case "OOA":
						if (number.Digits == 1 || number.Digits == 99)
							number.AddData(5, "Губернатор ЛО\n");
						else if (number.Digits < 100) number.AddData(3, "Администрация ЛО\n");
						break;
					case "OAO":
						if (number.Digits / 100 == 7)
							number.AddData(3, "ФСБ\n");
						else if (number.Digits / 100 == 6)
							number.AddData(3, "Таможня и ГУИН\n");
						else
							number.AddData(2, "Администрация ЛО\n");
						break;
					case "OTY":
						if (number.Digits < 200)
							number.AddData(3, "Северо-Западное Таможенное управление ФТС России\n");
						break;
					case "OOM":
						number.AddData(2, "ГУИН и ФСБ\n");
						break;
					case "OMO":
						number.AddData(2, "МВД ЛО\n");
						break;
				}

				break;
			case 52:
				switch (number.Series)
				{
					case "AAA":
						number.AddData(2, "Администрация Нижегородской области\n");
						break;
					case "AHH":
					case "TKA":
					case "AHM":
					case "EHM":
						number.AddData(2, "ГУВД по Нижегородской области\n");
						break;
					case "BHM":
						number.AddData(2, "Спецтранспорт МВД\n");
						break;
					case "EEE":
						number.AddData(2, "Таможня\n");
						break;
					case "HHH":
						number.AddData(2, "Коммерческие организации, подведомственные администрации\n");
						break;
					case "OAO":
					case "TTT":
						number.AddData(2, "Полномочные представители в Приволжском Федеральном округе\n");
						break;
					case "PPP":
						number.AddData(2, "Прокуратура\n");
						break;
					case "CCC":
						number.AddData(2, "УФСБ\n");
						break;
					case "CHM":
						number.AddData(2, "Структуры МВД\n");
						break;
				}

				break;
			case 53:
				switch (number.Series)
				{
					case "MMM":
						if (number.Digits <= 100)
							number.AddData(3, "УВД, до введения синих номеров, позже раздана частникам\n");
						break;
					case "AAA":
						number.AddData(2, "Администрация Великого новгорода и области\n");
						break;
					case "OOO":
						if (number.Digits <= 300) number.AddData(3, "УВД\n");
						break;
				}

				break;
			case 54:
				switch (number.Series)
				{
					case "AAA":
						number.AddData(2, "Полномочные представители Президента РФ\n");
						break;
					case "HHH":
						number.AddData(2, "Администрация Новосибирской области\n");
						break;
					case "ACK":
						number.AddData(2, "ФСБ\n");
						break;
					case "PPP":
					case "MOP":
					case "HCO":
						number.AddData(2, "УГИБДД\n");
						break;
				}

				break;
			case 57:
				switch (number.Series)
				{
					case "AOO":
						number.AddData(2, "Администрация Орловской области\n");
						break;
					case "CKP":
						number.AddData(2, "Следственный комитет РФ, прокуратура\n");
						break;
					case "MAA":
					case "MMM":
					case "MOK":
					case "MOO":
						number.AddData(2, "МВД\n");
						break;
				}

				break;
			case 61:
				switch (number.Series)
				{
					case "APO":
						number.AddData(2, "Администрация Ростовской области\n");
						break;
					case "AAA":
						number.AddData(2, "Администрация Ростова\n");
						break;
					case "KKK":
						number.AddData(2, "Полномочные представители Президента РФ\n");
						break;
					case "HHH":
						number.AddData(2, "Прокуратура\n");
						break;
					case "MMM":
						number.AddData(2, "ОВД\n");
						break;
				}

				break;
			case 64:
				if (number.Series[0] == 'T' && number.Digits == 64)
					number.AddData(3, "Городская Дума Саратовской области\n");
				else
					switch (number.Series)
					{
						case "OBB":
							if (number.Digits < 200) number.AddData(3, "Правительство Саратовской области\n");
							break;
						case "BBP":
							if (number.Digits / 100 == 2)
								number.AddData(3, "ФСБ\n");
							else
								number.AddData(2, "МВД\n");
							break;
					}

				break;
			case 69:
				switch (number.Series)
				{
					case "ATB":
						number.AddData(2, "Администрация города Твери\n");
						break;
					case "ATO":
						number.AddData(2, "Администрация Тверской области\n");
						break;
					case "CCC":
						number.AddData(2, "Законодательное собрание Тверской области и города Твери\n");
						break;
					case "MMM":
						number.AddData(2, "Служебные автомобили полиции Тверской области и города Твери\n");
						break;
				}

				break;
			case 70:
				switch (number.Series)
				{
					case "OTO":
						number.AddData(2, "Администрация Томской области\n");
						break;
					case "BMA":
						number.AddData(2, "Водитель Милицейского Автомобиля\n");
						break;
				}

				break;
			case 77:
				switch (number.Series)
				{
					case "XKX":
						number.AddData(2, "Частично ФСБ Москвы\n");
						break;
					case "AOO":
					case "BOO":
					case "MOO":
					case "COO":
						number.AddData(2, "Автомобили управления делами Президента\n");
						break;
					case "KOO":
						number.AddData(2, "Конституционный Суд РФ\n");
						break;
					case "PMP":
						number.AddData(2, "Министерство Юстиции, ФСИН, прокуратура\n");
						break;
					case "AMP":
					case "BMP":
					case "KMP":
					case "MMP":
					case "OMP":
					case "TMP":
					case "YMP":
						number.AddData(2, "Частично МВД, ФСБ, подведомственное подчинение\n");
						break;
					case "AMO":
						number.AddData(2, "Мэрия Москвы\n");
						break;
					case "EKX":
						number.AddData(2, "ФСО РФ\n");
						break;
					case "CAC":
						if (number.Digits >= 500) number.AddData(3, "ФСК, ФСБ\n");
						break;
					case "AMM":
						number.AddData(2, "Бывшая серия МВД РФ\n");
						break;
					case "CCC":
						number.AddData(2, "Центр спецсвязи, Фельдъегерская служба\n");
						break;
					case "OOO":
						number.AddData(2, "До 1998 года принадлежали ФСБ\n");
						break;
					case "KMM":
						number.AddData(2, "Пожарная охрана\n");
						break;
				}

				break;
			case 78:
				switch (number.Series)
				{
					case "AAA":
						number.AddData(2, "Органы исполнительной власти СПб\n");
						break;
					case "OOO":
						if (number.Digits >= 900)
							number.AddData(3, "ФСО\n");
						else
							number.AddData(2, "Администрация СПб\n");
						break;
					case "OKO":
						if (number.Digits / 100 == 7) number.AddData(3, "ФСБ\n");
						if (number.Digits / 100 == 8) number.AddData(3, "Министерство Юстиций\n");
						if (number.Digits / 100 == 9)
							number.AddData(3, "ФАПСИ и Федеральная Фельдъегерская Служба СПб\n");
						if (number.Digits < 700) number.AddData(2, "Прокуратура СПб\n");
						break;
					case "OOA":
						if (number.Digits < 200)
							number.AddData(3, "ФНС, управления Федерального Казначейства, ЛенЭнерго\n");
						break;
					case "OAO":
						if (number.Digits / 100 == 7)
							number.AddData(3, "ФСБ\n");
						else if (number.Digits / 100 == 6)
							number.AddData(3, "Таможня и ГУИН\n");
						else
							number.AddData(2, "Администрация СПб\n");
						break;
					case "OOC":
						if (number.Digits == 100)
							number.AddData(5, "Номер Владимира Владимировича Путина, когда он был первым заместителем мэра города Санкт-Петербурга по внешним связям\n");
						else
							number.AddData(2, "МВД, МИД, ФСБ\n");
						break;
					case "OCM":
						if (number.Digits / 100 == 7 || number.Digits / 100 == 9)
							number.AddData(3, "ФСБ\n");
						else
							number.AddData(2, "Смольный, Администрация СПб\n");
						break;
					case "OOH":
						number.AddData(2, "ГНК и ФНС\n");
						break;
					case "MMM":
					case "MMA":
					case "MME":
					case "MAE":
					case "MMB":
						number.AddData(2, "Закрытые предприятия (Адмиралтейские Верфи, Банк России и другие)\n");
						break;
					case "OOM":
						number.AddData(2, "ГУИН и ФСБ\n");
						break;
					case "OTT":
						if (number.Digits / 100 == 0 && number.Digits / 10 == 2)
							number.AddData(3, "Полномочные представители Президента РФ\n");
						break;
					case "OMM":
						number.AddData(2, "Бывшие РУВД\n");
						break;
					case "OMO":
						number.AddData(2, "МВД\n");
						break;
					case "OTY":
						if (number.Digits < 200)
							number.AddData(3, "Северо-Западное Таможенное управление ФТС России\n");
						break;
				}

				break;
			case 93:
				switch (number.Series)
				{
					case "OOO":
					case "AAA":
						number.AddData(2,
							"Большинство у влиятельных частников, также есть у администраций районов\n");
						break;
					case "KKK":
						number.AddData(2, "Администрация Краснодарского края\n");
						break;
					case "MKK":
						number.AddData(2, "Милиция Краснодарского края\n");
						break;
					case "AHY":
						if (number.Digits < 10)
							number.AddData(4,
								"Высокопоставленные сотрудники УГИБДД ГУВД по Краснодарскому краю\n");
						break;
					case "EKX":
						number.AddData(2, "ФСО РФ\n");
						break;
					case "MMM":
						number.AddData(2, "У частников, в основном с силовыми ксивами\n");
						break;
					case "YYY":
						if (number.Digits >= 200 && number.Digits <= 400) number.AddData(3, "Газпром\n");
						break;
					case "CCC":
						number.AddData(2, "Следственный комитет при прокуратуре Краснодарского края\n");
						break;
					case "MOC":
					case "BOC":
					case "MOK":
						if (number.Digits <= 100)
							number.AddData(3, "\"Олимпстрой\" и всё, что связано с олимпиадой\n");
						break;
				}

				break;
			case 97:
				switch (number.Series)
				{
					case "EKX":
						number.AddData(2, "ФСО Москвы\n");
						break;
					case "AMP":
						switch (number.Digits)
						{
							case 1:
								number.AddData(5, "Игорь Иванович Шувалов, российский политик\n");
								break;
							case 2:
								number.AddData(5, "Сергей Евгеньевич Нарышкин, российский государственный, политический и военный деятель\n");
								break;
							case 3:
								number.AddData(5, "Дмитрий Николаевич Козак, российский политик\n");
								break;
							case 4:
								number.AddData(5, "Александр Дмитриевич Жуков, российский политик\n");
								break;
							case 5:
								number.AddData(5, "Алексей Леонидович Кудрин, российский политик\n");
								break;
							case 6:
								number.AddData(5, "Алексей Васильевич Гордеев, российский политик\n");
								break;
							case 7:
								number.AddData(5, "Эльвира Сахипзадовна Набиуллина, российский политик\n");
								break;
							case 8:
								number.AddData(5, "Игорь Евгеньевич Левитин, российский политик\n");
								break;
							case 9:
								number.AddData(5, "Рашид Гумарович Нургалиев, российский генерал\n");
								break;
							case 10:
								number.AddData(5, "Юрий Петрович Трутнев, российский политик\n");
								break;
							case 11:
								number.AddData(5, "Александр Александрович Фурсенко, российский политик\n");
								break;
							case 13:
								number.AddData(5, "Виталий Леонтьевич Мутко, российский политик\n");
								break;
							case 14:
								number.AddData(5, "Сергей Кужугетович Шойгу, российский военный деятель\n");
								break;
							case 15:
								number.AddData(5, "Олег Александрович Марков, российский политик\n");
								break;
							case 16:
								number.AddData(5, "Виктор Федорович Басаргин, российский политик\n");
								break;
							case 17:
								number.AddData(5, "Александр Алексеевич Авдеев, российский политик\n");
								break;
							case 18:
								number.AddData(5, "Владислав Николаевич Путилин, российский военный деятель\n");
								break;
							case 19:
								number.AddData(5, "Юрий Сергеевич Осипов, Президент Российской академии наук\n");
								break;
							case 20:
								number.AddData(5, "Владислав Юрьевич Сурков, российский политик\n");
								break;
							case 22:
								number.AddData(5, "Сергей Михайлович Игнатьев, российский экономист\n");
								break;
							case 23:
								number.AddData(5, "Алексей Сергеевич Абрамов, советский авиаконструктор\n");
								break;
							case 24:
								number.AddData(5, "Ева Игоревна Василевская, директор Департамента по подготовке текстов публичных выступлений\n");
								break;
							case 25:
								number.AddData(5, "Владимир Игоревич Кожин, российский депутат\n");
								break;
							case 26:
								number.AddData(5, "Сергей Эдуардович Приходько, российский дипломат\n");
								break;
							case 27:
								number.AddData(5, "Александр Дмитриевич Беглов, российский политик\n");
								break;
							case 28:
								number.AddData(5, "Лариса Игоревна Брычева, российский государственный и политический деятель\n");
								break;
							case 29:
								number.AddData(5, "Сергей Иванович Шматко, российский политик\n");
								break;
							case 30:
								number.AddData(5, "Виктор Борисович Христенко, российский политик\n");
								break;
							case 31:
								number.AddData(5, "Аркадий Владимирович Дворкович, российский экономист\n");
								break;
							case 33:
								number.AddData(5, "Татьяна Алексеевна Голикова, российский экономист\n");
								break;
							case 34:
								number.AddData(5, "Юрий Константинович Лаптев, народный артист РФ, оперный певец\n");
								break;
							case 35:
								number.AddData(5, "Михаил Юрьевич Лесин, российский политик\n");
								break;
							case 37:
								number.AddData(5, "Сергей Александрович Соболев, руководитель протокола премьера РФ\n");
								break;
							case 38:
								number.AddData(5, "Константин Анатольевич Чуйченко, российский государственный деятель\n");
								break;
							case 39:
								number.AddData(5, "Владимир Николаевич Шевченко, российский политик\n");
								break;
							case 40:
								number.AddData(5, "Вениамин Фёдорович Яковлев, советник Президента\n");
								break;
							case 41:
								number.AddData(5, "Игорь Олегович Щёголев, российский политик\n");
								break;
							case 42:
								number.AddData(5, "Леонид Дододжонович Рейман, российский политик\n");
								break;
							case 43:
								number.AddData(5, "Алексей Алексеевич Громов, российский политик\n");
								break;
							case 44:
								number.AddData(5, "Виктор Николаевич Нагайцев, руководитель секретариата руководителя Администрации Президента РФ\n");
								break;
							case 45:
								number.AddData(5, "Михаил Юрьевич Копейкин, доктор экономических наук\n");
								break;
							case 46:
								number.AddData(5, "Дмитрий Александрович Рыжков, советский политик\n");
								break;
							case 47:
								number.AddData(5, "Игорь Владимирович Боровков, заместитель руководителя аппарата правительства РФ\n");
								break;
							case 48:
								number.AddData(5, "Виктор Владимирович Голованов, российский деятель органов внутренних дел\n");
								break;
							case 49:
								number.AddData(5, "Всеволод Львович Вуколов, заместитель министра\n");
								break;
							case 50:
								number.AddData(5, "Вячеслав Александрович Кокунов, первый проректор по общим вопросам и финансово-хозяйственной деятельности\n");
								break;
							case 51:
								number.AddData(5, "Виктор Васильевич Ренев, министр культуры, советник губернатора\n");
								break;
							case 52:
								number.AddData(5, "Александр Леонидович Манжосин, российский дипломат\n");
								break;
							case 53:
								number.AddData(5, "Олег Маркович Говорун, российский политик\n");
								break;
							case 54:
								number.AddData(5, "Дмитрий Сергеевич Жуйков, российский государственный деятель\n");
								break;
							case 55:
								number.AddData(5, "Владимир Борисович Осипов, российский политик\n");
								break;
							case 56:
								number.AddData(5, "Наталья Александровна Тимакова, российский политик\n");
								break;
							case 57:
								number.AddData(5, "Марина Валентиновна Ентальцева, российский государственный деятель\n");
								break;
							case 58:
								number.AddData(5, "Фирсова Татьяна Николаевна, сценарист, режиссер\n");
								break;
							case 60:
								number.AddData(5, "Сергей Николаевич Дубик, заместитель генерального директора по осуществлению государственных полномочий\n");
								break;
							case 71:
								number.AddData(5, "Сергей Юрьевич Винокуров, первый заместитель директора СВР России\n");
								break;
							case 72:
								number.AddData(5, "Александр Алексеевич Котенков, российский политик\n");
								break;
							case 73:
								number.AddData(5, "Гарри Владимирович Минх, российский политик\n");
								break;
							case 74:
								number.AddData(5, "Михаил Валентинович Кротов, российский юрист, государственный деятель\n");
								break;
							case 78:
								number.AddData(5, "Михаил Иванович Тринога, советник Президента\n");
								break;
							case 79:
								number.AddData(5, "Дмитрий Сергеевич Песков, российский государственный деятель\n");
								break;
							case 80:
								number.AddData(5, "Виктор Петрович Иванов, российский политик\n");
								break;
							case 81:
								number.AddData(5, "Александр Иванович Смирнов, российский физик, член-корреспондент РАН\n");
								break;
							case 82:
								number.AddData(5, "Владимир Игоревич Стржалковский, российский политик\n");
								break;
							case 83:
								number.AddData(5, "Антон Викторович Дроздов, российский экономист\n");
								break;
							case 84:
								number.AddData(5, "Сергей Вячеславович Калашников, российский политик\n");
								break;
							case 85:
								number.AddData(5, "Борис Юрьевич Ковальчук, российский менеджер и чиновник\n");
								break;
							case 86:
								number.AddData(5, "Михаил Иванович Лычагин, директор административного департамента аппарата правительства России\n");
								break;
							case 87:
								number.AddData(5, "Михаил Юрьевич Барщевский, российский политик\n");
								break;
							case 88:
								number.AddData(5, "Николай Федорович Моисеев, директор Департамента оборонной промышленности и высоких технологий Правительства РФ\n");
								break;
							case 89:
								number.AddData(5, "Денис Владимирович Молчанов, первый заместитель министра культуры РФ\n");
								break;
							case 90:
								number.AddData(5, "Гарри Владимирович Минх, российский политик\n");
								break;
							case 91:
								number.AddData(5, "Ольга Станиславовна Пушкарева, директор Департамента отраслевого развития Правительства РФ\n");
								break;
							case 92:
								number.AddData(5, "Андрей Владимирович Яцкин, российский политик\n");
								break;
							case 93:
								number.AddData(5, "Андрей Дмитриевич Ряховский, директор Департамента делопроизводства и архива Правительства РФ\n");
								break;
							case 94:
								number.AddData(5, "Марина Юрьевна Сеньковская, заместитель полномочного представителя Президента РФ\n");
								break;
							case 95:
								number.AddData(5, "Александр Михайлович Смирных, российский государственный деятель\n");
								break;
							case 96:
								number.AddData(5, "Сергей Иванович Герасимов, российский государственный деятель\n");
								break;
							case 97:
								number.AddData(5, "Михаил Игоревич Суходольский, российский политик\n");
								break;
							case 98:
								number.AddData(5, "Евгений Михайлович Школов, российский политик\n");
								break;
							case 99:
								number.AddData(5, "Николай Александрович Овчинников, российский политик\n");
								break;
							case 100:
								number.AddData(5, "Виктор Николаевич Кирьянов, российский военный деятель\n");
								break;
							case 101:
								number.AddData(5, "Александр Викторович Логинов, российский биатлонист\n");
								break;
							case 104:
								number.AddData(5, "Алексей Юрьевич Смирнов, российский физик\n");
								break;
							case 106:
								number.AddData(5, "Жанна Алексеевна Одинцова, руководитель Аппарата Председателя Партии \"ЕР\"\n");
								break;
							case 109:
								number.AddData(5, "Антон Эдуардович Вайно, российский политик\n");
								break;
							case 113:
								number.AddData(5, "Владимир Борисович Рушайло, российский военный деятель\n");
								break;
							case 114:
								number.AddData(5, "Юрий Леонидович Воробьев, российский политик\n");
								break;
							case 121:
								number.AddData(5, "Олег Викторович Морозов, российский политик\n");
								break;
							case 122:
								number.AddData(5, "Любовь Константиновна Слиска, российский политик\n");
								break;
							case 124:
								number.AddData(5, "Владимир Вольфович Жириновский, российский политик\n");
								break;
							case 133:
								number.AddData(5, "Дмитрий Александрович Бездлелов, бывший глава Росграницы\n");
								break;
							case 134:
								number.AddData(5, "Таймураз Казбекович Боллоев, российский предприниматель\n");
								break;
							case 135:
								number.AddData(5, "Андрей Анатольевич Крайний, российский политик\n");
								break;
							case 136:
								number.AddData(5, "Счетная палата РФ\n");
								break;
							case 141:
								number.AddData(5, "Сабир Гаджиметович Кехлеров, российский политик\n");
								break;
							case 143:
								number.AddData(5, "Александр Иванович Бастрыкин, российский государственный деятель\n");
								break;
							case 177:
								number.AddData(5, "Юрий Юрьевич Сёмин, российский юрист\n");
								break;
							case 202:
								number.AddData(5, "Владимир Евгеньевич Чуров, российский политик\n");
								break;
							case 216:
								number.AddData(5, "Павел Петрович Дашков, генерал-полковник, командующий Северо-Западным округом войск национальной гвардии РФ\n");
								break;
							case 234:
								number.AddData(5, "Константин Олегович Ромодановский, российский деятель органов государственной безопасности внутренних дел и миграционной службы\n");
								break;
							case 237:
								number.AddData(5, "Фарит Мубаракшевич Мухаметшин, российский дипломат\n");
								break;
							case 240:
								number.AddData(5, "Михаил Аркадьевич Дмитриев, российский военный деятель\n");
								break;
							case 254:
								number.AddData(5, "Юрий Викторович Герций, председатель совета\n");
								break;
							case 266:
								number.AddData(5, "Семен Николаевич Козлов, российский хоккеист\n");
								break;
							case 277:
								number.AddData(5, "Владимир Александрович Колокольцев, генерал полиции\n");
								break;
							case 296:
								number.AddData(5, "Владимир Владимирович Кириллов, российский политик\n");
								break;
							case 300:
								number.AddData(5, "Григорий Иосифович Элькин, руководитель Федерального агентства по техническому регулированию и метрологии\n");
								break;
							case 302:
								number.AddData(5, "Михаил Вадимович Сеславинский, российский политик\n");
								break;
							case 320:
								number.AddData(5, "Виктор Николаевич Масляков, российский политик\n");
								break;
							case 321:
								number.AddData(5, "Николай Евгеньевич Рогожкин, российский военный деятель\n");
								break;
							case 326:
								number.AddData(5, "Сергей Евгеньевич Матвеев, генерал-майор полиции\n");
								break;
							case 333:
								number.AddData(5, "Виктор Николаевич Кирьянов, российский военный деятель\n");
								break;
							case 340:
								number.AddData(5, "Сергей Юрьевич Павленко, руководитель Федеральной службы финансово-бюджетного надзора Министерства финансов РФ\n");
								break;
							case 341:
								number.AddData(5, "Роман Евгеньевич Артюхин, руководитель федерального казначейства РФ\n");
								break;
							case 362:
								number.AddData(5, "Юрий Михайлович Лужков, российский политический деятель\n");
								break;
							case 368:
								number.AddData(5, "Михаил Викторович Шмаков, российский общественный деятель\n");
								break;
							case 370:
								number.AddData(5, "Николай Николаевич Бордюжа, российский военный деятель\n");
								break;
							case 373:
								number.AddData(5, "Александр Петрович Чуприян, российский политик\n");
								break;
							case 375:
								number.AddData(5, "Никита Сергеевич Михалков, кинорежиссер\n");
								break;
							case 376:
								number.AddData(5, "Григорий Борисович Карасин, российский дипломат\n");
								break;
							case 381:
								number.AddData(5, "Сергей Иванович Григоров, военный деятель\n");
								break;
							case 382:
								number.AddData(5, "Николай Павлович Аброськин, военный деятель\n");
								break;
							case 383:
								number.AddData(5, "Юрий Александрович Петров, директор Института российской истории\n");
								break;
							case 384:
								number.AddData(5, "Юрий Иванович Калинин, российский политик\n");
								break;
							case 388:
								number.AddData(5, "Николай Александрович Винниченко, российский юрист\n");
								break;
							case 389:
								number.AddData(5, "Александр Васильевич Царенко, генерал-полковник\n");
								break;
							case 390:
								number.AddData(5, "Геннадий Григорьевич Онищенко, российский политик\n");
								break;
							case 391:
								number.AddData(5, "Борис Сергеевич Алёшин, российский учёный\n");
								break;
							case 405:
								number.AddData(5, "Магомедали Магомедович Магомедов, российский политик\n");
								break;
							case 416:
								number.AddData(5, "Рустам Нургалиевич Минниханов, российский политик\n");
								break;
							case 432:
								number.AddData(5, "Николай Васильевич Денин, российский политик\n");
								break;
							case 443:
								number.AddData(5, "Никита Юрьевич Белых, российский политик\n");
								break;
							case 450:
								number.AddData(5, "Борис Всеволодович Громов, военачальник\n");
								break;
							case 469:
								number.AddData(5, "Дмитрий Вадимович Зеленин, российский политик, экономист и предприниматель\n");
								break;
							case 471:
								number.AddData(5, "Вячеслав Дмитриевич Дудка, российский государственный деятель\n");
								break;
							case 477:
								number.AddData(5, "Владимир Иосифович Ресин, российский политик\n");
								break;
							case 480:
								number.AddData(5, "Игорь Петрович Чуян, руководитель Федеральной службы по регулированию алкогольного рынка\n");
								break;
							case 481:
								number.AddData(5, "Никитин Никита Евгеньевич, заместитель генерального директора АНО\n");
								break;
							case 484:
								number.AddData(5, "Константин Вячеславович Седов, российский экономист\n");
								break;
							case 485:
								number.AddData(5, "Дмитрий Юрьевич Гогин, заместитель руководителя Федерального агентства по государственным резервам\n");
								break;
							case 489:
								number.AddData(5, "Юрий Васильевич Неёлов, российский политик\n");
								break;
							case 499:
								number.AddData(5, "Михаил Владимирович Мишустин, российский государственный деятель\n");
								break;
							case 500:
								number.AddData(5, "Геннадий Александрович Корниенко, российский генерал\n");
								break;
							case 510:
								number.AddData(5, "Андрей Витальевич Нелидов, российский предприниматель\n");
								break;
							case 564:
								number.AddData(5, "Валерий Васильевич Радаев, российский политик\n");
								break;
							case 571:
								number.AddData(5, "Игорь Владимирович Панченко, российский политик\n");
								break;
							case 580:
								number.AddData(5, "Константин Георгиевич Цицин, российский политик\n");
								break;
							case 581:
								number.AddData(5, "Владимир Михайлович Малинин, российский деятель органов государственной безопасности и таможенной службы\n");
								break;
							case 582:
								number.AddData(5, "Виктор Васильевич Черкесов, российский политик\n");
								break;
							case 584:
								number.AddData(5, "Константин Львович Эрнст, генеральный директор \"ОРТ/Первого канала\"\n");
								break;
							case 588:
								number.AddData(5, "Владимир Иванович Якунин, российский дипломат\n");
								break;
							case 590:
								number.AddData(5, "Анатолий Борисович Чубайс, российский политик\n");
								break;
							case 591:
								number.AddData(5, "Семён Михайлович Вайншток, российский предприниматель\n");
								break;
							case 592:
								number.AddData(5, "Сергей Викторович Чемезов, российский политик\n");
								break;
							case 593:
								number.AddData(5, "Алексей Борисович Миллер, российский экономист\n");
								break;
							case 594:
								number.AddData(5, "Леонид Васильевич Тягачёв, российский политик\n");
								break;
							case 595:
								number.AddData(5, "Павел Павлович Бородин, политик\n");
								break;
							case 596:
								number.AddData(5, "Григорий Алексеевич Рапота, российский политик\n");
								break;
							case 597:
								number.AddData(5, "Сергей Николаевич Лебедев, российский политик\n");
								break;
							case 598:
								number.AddData(5, "Андрей Леонидович Костин, российский бизнесмен\n");
								break;
							case 599:
								number.AddData(5, "Дмитриев Владимир Александрович, российский бизнесмен\n");
								break;
							case 600:
								number.AddData(5, "Андрей Ильич Казьмин, российский политик\n");
								break;
							case 601:
								number.AddData(5, "Юрий Анатольевич Чиханчин, российский экономист\n");
								break;
							case 612:
								number.AddData(5, "Александр Николаевич Зелин, российский военачальник\n");
								break;
							case 619:
								number.AddData(5, "Михаил Павлович Мокрецов, российский экономист\n");
								break;
							case 620:
								number.AddData(5, "Михаил Павлович Мокрецов, российский экономист\n");
								break;
							case 699:
								number.AddData(5, "Валерий Львович Назаров, российский чиновник\n");
								break;
							case 700:
								number.AddData(5, "Игорь Юрьевич Артемьев, российский политик\n");
								break;
							case 701:
								number.AddData(5, "Александр Васильевич Нерадько, российский политик\n");
								break;
							case 702:
								number.AddData(5, "Сергей Геннадиевич Новиков, начальник управления Президента РФ\n");
								break;
							case 703:
								number.AddData(5, "Александр Иванович Бедрицкий, советник Президента Российской Федерации по вопросам изменения климата\n");
								break;
							case 704:
								number.AddData(5, "Владимир Леонидович Соколин, председатель Межгосударственного статистического комитета Содружества Независимых Государств\n");
								break;
							case 706:
								number.AddData(5, "Николай Георгиевич Кутьин, российский политик\n");
								break;
							case 707:
								number.AddData(5, "Андрей Юрьевич Бельянинов, российский бизнесмен\n");
								break;
							case 708:
								number.AddData(5, "Сергей Владиленович Кириенко, российский политик\n");
								break;
							case 709:
								number.AddData(5, "Владимир Александрович Поповкин, российский военный деятель\n");
								break;
							case 900:
								number.AddData(5, "Игорь Иванович Сечин, российский государственный деятель\n");
								break;
							case 902:
								number.AddData(5, "Сергей Евгеньевич Нарышкин, российский государственный, политический и военный деятель\n");
								break;
							case 903:
								number.AddData(5, "Виктор Анатольевич Кручинин, директор Департамента по обеспечению деятельности приемной Председателя Правительства РФ\n");
								break;
							case 904:
								number.AddData(5, "Валерий Дмитриевич Зорькин, российский судья\n");
								break;
							case 905:
								number.AddData(5, "Вячеслав Михайлович Лебедев, председатель Верховного Суда\n");
								break;
							case 906:
								number.AddData(5, "Антон Александрович Иванов, российский юрист\n");
								break;
							case 908:
								number.AddData(5, "Секретариат Президента РФ");
								break;
							case 909:
								number.AddData(5, "Сергей Борисович Иванов, российский государственный деятель\n");
								break;
							case 910:
								number.AddData(5, "Владимир Васильевич Устинов, российский политик\n");
								break;
							case 911:
								number.AddData(5, "Сергей Викторович Лавров, министр иностранных дел РФ\n");
								break;
							case 912:
								number.AddData(5, "Сергей Семёнович Собянин, мэр Москвы\n");
								break;
							case 914:
								number.AddData(5, "Илья Вадимович Ломакин-Румянцев, российский политик\n");
								break;
							case 915:
								number.AddData(5, "Виктор Алексеевич Зубков, российский политик\n");
								break;
							case 916:
								number.AddData(5, "Андрей Михайлович Цыбулин, начальник Управления пресс-службы и информации Президента РФ\n");
								break;
							case 918:
								number.AddData(5, "Сергей Николаевич Осипов, начальник Управления информационного и документационного обеспечения Президента РФ\n");
								break;
							case 919:
								number.AddData(5, "Александр Владимирович Коновалов, российский политик\n");
								break;
							case 920:
								number.AddData(5, "Петр Петрович Скороспелов, государственный советник РФ\n");
								break;
							case 921:
								number.AddData(5, "Владимир Иванович Булавин, российский политик\n");
								break;
							case 922:
								number.AddData(5, "Сергей Константинович Ушаков, советник Президента\n");
								break;
							case 923:
								number.AddData(5, "Сергей Николаевич Болховитин, начальник Главного управления международного сотрудничества Управления делами Президента РФ\n");
								break;
							case 924:
								number.AddData(5, "Николай Михайлович Михеев, начальник главного управления Управления делами Президента РФ\n");
								break;
							case 988:
								number.AddData(5, "Владимир Михайлович Кулистиков, российский журналист\n");
								break;
							case 990:
								number.AddData(5, "Олег Борисович Добродеев, российский журналист\n");
								break;
							case 992:
								number.AddData(5, "Сергей Вячеславович Калашников, российский политик\n");
								break;
							case 993:
								number.AddData(5, "Виталий Никитич Игнатенко, журналист, общественный деятель\n");
								break;
							case 995:
								number.AddData(5, "Елена Борисовна Скрынник, российский государственный деятель\n");
								break;
							case 997:
								number.AddData(5, "Анатолий Борисович Чубайс, российский политик\n");
								break;
							case 998:
								number.AddData(5, "Владислав Николаевич Путилин, российский военный деятель\n");
								break;
							case 999:
								number.AddData(5, "Евгений Алексеевич Муров, российский военный деятель\n");
								break;
							case { } n when n >= 371 && n <= 374:
								number.AddData(4, "МЧС РФ\n");
								break;
							case { } n when n >= 377 && n <= 380:
								number.AddData(4, "МИД РФ\n");
								break;
							case { } n when n >= 385 && n <= 387:
								number.AddData(4, "ФСИН РФ\n");
								break;
							case { } n when n >= 401 && n <= 479:
								number.AddData(4,
									"Губернаторы, руководители исполнительных органов власти субъектов РФ\n");
								break;
							case { } n when n >= 501 && n <= 588:
								number.AddData(4,
									"Спикеры, руководители законодательных органов власти субъектов РФ\n");
								break;
							case { } n when n >= 602 && n <= 621:
								number.AddData(4, "Министерство Обороны РФ\n");
								break;
							case { } n when n >= 622 && n <= 660:
							case { } n1 when n1 >= 673 && n1 <= 690:
								number.AddData(4, "Государственная Фельдъегерская Служба РФ\n");
								break;
							case { } n when n >= 661 && n <= 672:
								number.AddData(4, "Фельдсвязь РФ\n");
								break;
							case { } n when n >= 691 && n <= 697:
								number.AddData(4, "ФСКН РФ\n");
								break;
							case { } n when n >= 712 && n <= 899:
							case 913:
								number.AddData(3, "ФСБ РФ\n");
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
								number.AddData(4, "Резервные номера правительства РФ\n");
								break;
							case 32:
							case 36:
							case 70:
							case 75:
							case 705:
							case 917:
								number.AddData(4, "Отдел ТО и регистрации\n");
								break;
							case { } n when n >= 61 && n <= 69:
								number.AddData(4, "Управление делами Президента РФ\n");
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
								number.AddData(4, "ФСО РФ\n");
								break;
							case 102:
							case 103:
							case 105:
							case 107:
							case 108:
							case 110:
							case 111:
								number.AddData(4, "Аппарат правительства РФ\n");
								break;
							case { } n when n >= 115 && n <= 120:
								number.AddData(4, "Совет Федерации Федерального Собрания РФ\n");
								break;
							case 123:
							case { } n when n >= 125 && n <= 132:
								number.AddData(4, "Госдума РФ\n");
								break;
							case { } n when n >= 137 && n < 202:
								number.AddData(4, "Генеральная Прокуратура РФ\n");
								break;
							case { } n when n >= 203 && n < 370:
								number.AddData(3,
									"Министерство Внутренних Дел РФ и другие федеральные структуры\n");
								break;
							default:
								number.AddData(3,
									"Главная федеральная спецсерия автономеров в Российской Федерации, которой заменили флаговые номера\n");
								break;
						}

						break;
				}

				break;
			case 98:
				switch (number.Series)
				{
					case "OOO":
					case "AAA":
						number.AddData(2, "Администрация СПб\n");
						break;
					case "OKO":
						if (number.Digits < 100)
							number.AddData(3, "Прокуратура СПб\n");
						else if (number.Digits < 200)
							number.AddData(3, "Прокуратура ЛО\n");
						else if (number.Digits / 100 == 2 || number.Digits / 100 == 3 || number.Digits / 100 == 7)
							number.AddData(3, "Федеральная Служба судебных приставов, Министерство юстиции РФ\n");
						else if (number.Digits / 100 == 9) number.AddData(3, "Судебный департамент при ВС РФ\n");
						break;
					case "OCK":
						number.AddData(2,
							"Следственное управление следственного комитета при Генеральной прокуратуре\n");
						break;
					case "OKC":
						number.AddData(2, "Конституционный Суд РФ, Управление делами Президента РФ\n");
						break;
					case "OOA":
						if (number.Digits <= 50) number.AddData(4, "Депутаты ЗАКСа\n");
						break;
					case "OAO":
						if (number.Digits / 100 == 7) number.AddData(3, "ФСБ\n");
						break;
					case "OAA":
						number.AddData(2, "ФСБ, МВД\n");
						break;
					case "OOH":
						if (number.Digits < 200) number.AddData(3, "ГНК и ФНС\n");
						break;
					case "OAC":
						number.AddData(2, "Арбитражный суд\n");
						break;
					case "EKX":
						number.AddData(2, "ФСБ и ФСО\n");
						break;
					case "OOM":
						number.AddData(2, "ГУИН и ФСБ\n");
						break;
					case "OTT":
						if (number.Digits / 10 == 6 || number.Digits / 10 == 7)
							number.AddData(3, "Полномочные представители Президента РФ\n");
						else
							number.AddData(2, "У ГИБДД по СПб и ЛО\n");
						break;
					case "OCA":
						number.AddData(2, "У ГИБДД по СПб и ЛО\n");
						break;
					case "OMM":
						number.AddData(2, "УВДТ, ССШМ\n");
						break;
					case "OBO":
						number.AddData(2, "Вневедомственая Охрана, ОМОН\n");
						break;
					case "OPP":
						number.AddData(2, "ГУВД СПб и ЛО\n");
						break;
					case "OМО":
						number.AddData(2, "МВД\n");
						break;
					case "OMP":
						number.AddData(2, "ГУВД СПб и ЛО, Милиция России\n");
						break;
				}

				break;
			case 99:
				switch (number.Series)
				{
					case "EKX":
						number.AddData(2, "Автомобили ФСО, серия пришла на смену ЕКХ77\n");
						break;
					case "HAA":
					case "TAA":
					case "CAA":
					case "XAA":
						number.AddData(2,
							"\"Закрытые\" в базах машины, почти все – у транспорта, принадлежащего ФСБ, различным НИИ и \"почтовым ящикам\"\n");
						break;
					case "AAA":
						if (number.Digits == 271) number.AddData(5, "Владимир Вольфович Жириновский, политик\n");
						break;
				}

				break;
			case 102:
				switch (number.Series)
				{
					case "CKC":
						number.AddData(2,
							"Часть номеров с 2008 года закреплена за депутатами Государственного Собрания — Курултая\n");
						break;
					case "POO":
						number.AddData(2,
							"Выдаётся на автомобили руководителей крупных предприятий и министерств\n");
						break;
					case "CCC":
						if (number.Digits <= 100) number.AddData(3, "Прокуратура РБ\n");
						break;
				}

				break;
			case 116:
				switch (number.Series)
				{
					case "BOB":
						number.AddData(2, "Серия автомобилей участников Великой Отечественной Войны\n");
						break;
				}

				break;
			case 125:
				switch (number.Series)
				{
					case "EEE":
						number.AddData(2, "ФСБ\n");
						break;
					case "AAA":
						number.AddData(2,
							"Прокуратура Приморского края, одна из самых \"блатных\" серий, выдается только по указанию прокурора края\n");
						break;
					case "MBK":
						number.AddData(2,
							"\"Блатной\" номер сотрудников УВД, ведомственные номера УВД Приморского края\n");
						break;
					case "MBB":
						number.AddData(2, "Ведомственный номер сотрудников МВД города Владивосток\n");
						break;
					case "MOO":
						number.AddData(2,
							"Краевые структуры УВД, МЧС, пожарные и другие спецслужбы, много номеров у коммерсантов\n");
						break;
					case "BOO":
						number.AddData(2,
							"Городские службы УВД города Владивостока и районов, часть куплено коммерсантами\n");
						break;
					case "HOO":
						number.AddData(2,
							"Службы УВД, ГИБДД и другие Юго-восточного региона Приморского края (город Находка)\n");
						break;
					case "YOO":
						number.AddData(2,
							"Службы УВД, ГИБДД и другие Центрального региона Приморского края (город Уссурийск)\n");
						break;
					case "COO":
						number.AddData(2,
							"Службы УВД, ГИБДД и другие Северного региона Приморского края (город Спасск-Дальний)\n");
						break;
				}

				break;
			case 159:
				switch (number.Series)
				{
					case "MMM":
						number.AddData(2, "МВД\n");
						break;
				}

				break;
			case 164:
				switch (number.Series)
				{
					case "ACA":
						number.AddData(2, "Правительство Саратовской области\n");
						break;
					case "РРР":
						number.AddData(2, "Областная прокуратура\n");
						break;
				}

				break;
			case 177:
				switch (number.Series)
				{
					case "AKP":
					case "BKP":
					case "EKP":
					case "KKP":
						number.AddData(2, "Замена \"синьке\"\n");
						break;
					case "EPE":
						number.AddData(2, "Замена флаговым номерам\n");
						break;
				}

				break;
			case 178:
				switch (number.Series)
				{
					case "HBB":
						number.AddData(2, "Администрация СПб\n");
						break;
				}

				break;
		}

		if (number.Rang == 0 && number.Series[0] == number.Series[1] && number.Series[0] == number.Series[2])
			number.AddData(1, "Одинаковые буквы\n");
		if (number.Digits == 0) number.AddData(0, "Неверный номер\n");
		if (number.Digits % 111 == 0) number.AddData(1, "Одинаковые цифры\n");
	}
}