# VR

## Dokumentacja wstępna

### Opis projektu

> Gra VR typu endless runner, w której gracz wciela się w postać poruszającą się po niekończącym się torze pełnym przeszkód, zbiera punkty, zdobywa ulepszenia oraz korzysta z różnorodnej broni do niszczenia przeszkód. Rozgrywka opiera się na szybkim refleksie i strategicznym zarządzaniu zasobami. Kluczowymi elementami są immersyjne doświadczenie VR oraz różnorodność mechanik, które utrzymują zaangażowanie gracza.

### Uzasadnienie zastosowania wybranej technologii

> - VR jako medium dla pełnej immersji: Dzięki wykorzystaniu VR gracz może całkowicie zanurzyć się w świecie gry, co zwiększa intensywność doznań i angażuje użytkownika na głębszym poziomie w porównaniu do tradycyjnych gier.
> - Unity jako silnik gry: Unity oferuje zaawansowane narzędzia do tworzenia gier VR, w tym łatwą integrację z popularnymi headsetami VR, wsparcie dla fizyki oraz optymalizację grafiki, co pozwala na stworzenie dynamicznego i atrakcyjnego wizualnie świata.

### Potencjalne cele do stworzenia systemu

> - Głównym celem projektu jest zaprojektowanie i stworzenie gry typu Endless Runner.
> - Wykorzystanie technologii VR – poprzez zastosowanie narzędzia XR Interaction Toolkit, gra ma symulować doświadczenia wirtualnej rzeczywistości, zapewniając graczom bardziej immersyjne wrażenia.
> - Rozwój funkcjonalności interaktywnych – wprowadzenie mechanik takich jak:
>   - unikanie nadchodzących przeszkód
>   - zbieranie zasobów (piguł zwiększających liczbę żyć i amunicję)
>   - strzelanie do przeszkód z użyciem broni

### Potencjali odbiorcy

> - Gracze VR poszukujący szybkiej, dynamicznej rozgrywki z wysokim poziomem immersji.
> - Fani gier endless runner, którzy szukają nowych doświadczeń w rozszerzonej rzeczywistości wirtualnej.
> - Twórcy treści (streamerzy, youtuberzy), dla których gra może być atrakcyjna jako materiał do publikacji dzięki dynamicznej i efektownej rozgrywce.

### Przykłady szczególnej wartości i użyteczności dla użytkowników dostarczonych przez projekt (?)

> - Immersyjne doświadczenia VR - dzięki zastosowaniu narzędzia XR Interaction Toolkit, użytkownicy mogą cieszyć się wyjątkowym poziomem immersji.
> - Krótka, dynamiczna rozgrywka - dobra forma relaksu lub szybka rozgrywka w przerwach między innymi aktywnościami.

## Zarys specyfikacji

### Wymagania funkcjonalne + kryteria akceptacji

> - Gracz musi mieć możliwość poruszania się w prawo, lewo, skakania lub kucania, aby unikać nadchodzących przeszkód.
> - Gracz musi móc zbierać pigułki zwiększające liczbę żyć i amunicję.
> - Gracz ma możliwość niszczenia przeszkód poprzez użycie broni.
> - Przeszkody i przedmioty muszą być generowane w sposób losowy.
> - Gracz zdobywa punkty za czas przetrwania.
> - Gracz traci życie w przypadku zderzenia z przeszkodą i kończy grę po wyczerpaniu wszystkich żyć.
> - Gra musi wyświetlać bieżące statystyki gracza, takie jak liczba żyć, amunicja i punkty.

### Wymagania niefunkcjonalne

> - <b>Stabilność (priorytet krytyczny)</b><br> Gra musi działać stabilnie bez błędów krytycznych, które powodują jej zawieszenie lub zamknięcie. <br>Uzasadnienie: Stabilność jest podstawą każdej gry - błędy mogą uniemożliwić rozgrywkę i zniechęcić użytkowników.
> - <b>Intuicyjność interfejsu VR (priorytet krytyczny)</b><br>Interakcje w VR muszą być łatwe do opanowania, naturalne i responsywne.Priorytet: krytyczny <br>Uzasadnienie: W środowisku VR intuicyjne sterowanie jest kluczowe, by użytkownik mógł w pełni zaangażować się w grę.
> - <b>Skalowalność (priorytet wysoki)</b><br>System powinien umożliwiać łatwe dodawanie nowych funkcji, takich jak kolejne poziomy, przeszkody czy bronie.
> - <b>Efekty wizualne (priorytet średni)</b><br>Gra powinna zawierać wysokiej jakości efekty wizualne, które zwiększają immersję.
> - <b>Dostępność (priorytet niski)</b><br>Gra powinna być zaprojektowana w sposób umożliwiający grę osobom z różnym poziomem doświadczenia w VR.
