# VR

## Dokumentacja wstępna

### Opis projektu
> Opis tutaj
### Uzasadnienie zastosowania wybranej technologii
> - Arg1
> - Arg2
### Potencjalne cele do stworzenia systemu
> - cel1
> - cel2
### Potencjali odbiorcy
> - grupa1
> - grupa2
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



