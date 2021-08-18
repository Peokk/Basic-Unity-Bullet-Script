Jeśli nie wiesz w jaki sposób stworzyć pocisk w unity możesz skorzystać z mojego przykładowego kodu.
Skrypt ten dotyczy pocisków takich, które chcesz żeby było widać np. strzała.
Kod będzię działał prawidłowo jeśli twój pocisk będzie skierowany w stronę strzału od momentu utworzenia go.
Nie zapomnij do pocisku dodać oraz połączyć z kodem komponentu rigidbody.
## Zabierz punkty zdrowia przeciwnika
Używając `collison` - elementu funkcji OnCollisionEnter możesz pobrać dane obiektu, który wywołał kolizję z pociskiem.
