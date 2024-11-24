# VR

## Dokumentacja wstępna

### Opis projektu
> Gra VR typu endless runner, w której gracz wciela się w postać poruszającą się po niekończącym się torze pełnym przeszkód, zbiera punkty, zdobywa ulepszenia oraz korzysta z różnorodnej broni do niszczenia przeszkód. Rozgrywka opiera się na szybkim refleksie i strategicznym zarządzaniu zasobami. Kluczowymi elementami są immersyjne doświadczenie VR oraz różnorodność mechanik, które utrzymują zaangażowanie gracza.
### Uzasadnienie zastosowania wybranej technologii
> - VR jako medium dla pełnej immersji: Dzięki wykorzystaniu VR gracz może całkowicie zanurzyć się w świecie gry, co zwiększa intensywność doznań i angażuje użytkownika na głębszym poziomie w porównaniu do tradycyjnych gier.
> - Unity jako silnik gry: Unity oferuje zaawansowane narzędzia do tworzenia gier VR, w tym łatwą integrację z popularnymi headsetami VR, wsparcie dla fizyki oraz optymalizację grafiki, co pozwala na stworzenie dynamicznego i atrakcyjnego wizualnie świata.
### Potencjalne cele do stworzenia systemu
> - cel1
> - cel2
### Potencjali odbiorcy
> - Gracze VR poszukujący szybkiej, dynamicznej rozgrywki z wysokim poziomem immersji.
> - Fani gier endless runner, którzy szukają nowych doświadczeń w rozszerzonej rzeczywistości wirtualnej.
### Przykładyszczególnej wartości i użyteczności dla użytkowników dostarczonych przez projekt (?)
> - przykład1
> - przykład2

## Zarys specyfikacji

### Wymagania funkcjonalne + kryteria akceptacji
> wymóg 1
> wymóg 2
> wymóg 3
> wymóg 4
> wymóg 5
### Wymagania niefunkcjonalne
> wymóg 1
> wymóg 2
(Nadać priorytety dla wymagań, wybranie 2-4 krytycznych + wyjasnienie dlaczego te były wybrane)




Ad 1) wymagany jest VR - jeśli zastanawiają się Państwo jak przenieść koncepcję do VR jeśli nie dysponują Państwo możliwością testowania oprogramowania zapraszam do zapoznania się z tematem 4 na stronie kursu. Przedstawiony jest tam XR Interaction Toolkit (projekt bazowy w materiałach), tak jak zapowiadałem na stronie kursu zamieszczam linki do filmów z zajęć pokazujących jak można tam stworzyć aplikację/interakcje. Link do filmu z tych zajęć widoczny tutaj: 
https://www.youtube.com/watch?v=d_o9B3Z7E2o
Materiały z zajęć pokazujące wykonanie ćwiczeń na laboratoriach zamieszczane są tam regularnie. 
Ad 2) w przypadku gdy mówimy o wariancie implementacyjnym dokumentacja może być ograniczona, jednak dalej muszą Państwo wskazać kilka kluczowych punktów - takich jak dla kogo przeznaczona jest aplikacja, jakie systemy potencjalnie musiałyby zostać zaimplementowane, etc. 

Ad Koncepcja:
Jeśli będzie to zwykła aplikacja desktopowa to jest to nieco za mało. Na stronie kursu zamieszczone są już filmy pokazujące jak wykonać Endless Runnera. Jedyne co nie jest tam zaimplementowane (a można zaimplementować to w oparciu o treść zawartą w instrukcji do ćwiczenia) to możliwość przenikania przez przeszkody. Jeśli zastąpimy doliczenie czasu (które jest pokazane na filmie) zwiększaniem wyniku punktowego to uzyskamy z grubsza funkcjonalnośc, o której Pan pisze. 
Zaproponuję pewne zmiany: gra w VR (mogą Państwo testować korzystając z XR Interaction Toolkita), gracz może przemieszczać się po ograniczonej przestrzeni bez teleportacji (ponownie można to zaimplementować z użyciem Toolkitu, nie tworząc powierzchni do teleportacji). W kierunku użytkownika zmierzają przeszkody oraz powerup, które mogą dodać mu dodatkowe punkty. Zarówno przeszkody jak i power up pojawiają się na różnej wysokości i zmierzjące w kierunku za gracza (jak w Endless Runner przesuwanie przeszkód - ponownie w razie wątpliwości można zajrzeć do filmu). Gracz ma za zadanie unikać przeszkód i "zbierać" powerup. Dodatkowo jeśli chcą Państwo zrobić to "ambitniej" w formie implementacji lub opisać to w dokumentacji jako osobny system można umieścić koło gracza broń (przykład w scenie z XR Toolkit, w lewej części sceny są 2 bronie strzelające stosunkowo powoli), 2-3 trafienia z broni niszczą przeszkody. W tym wypadku można też okresowo uruchamiać punkty, w które użytkownik ma strzelać, aby uzyskać dodatkowe punkty. Kolejna rzecz jaką mogą Państwo opisać/rozpocząć implementację to system, który wraz z upływem czasu zwiększa trudność, zmieniając prędkość prouszania się obiektów i/lub zmiejącą czas jaki odejmowany jest po trafieniu przez przeszkodę. 

Z poważaniem, 

Paweł Buń



