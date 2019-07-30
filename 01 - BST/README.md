# Esercizi 01 - BST

Questi esercizi riguarderanno i Binary Search Tree (alberi di ricerca binari). 

Viene richiesto di traversare l'albero in alcuni modi diversi:

1. stampare tutti gli elementi in ordine crescente
2. stampare tutti gli elementi in ordine decrescente
3. stampare tutti gli elementi in ordine di profondità (breadth-first), partendo dalla radice
4. stampare tutti gli elementi in ordine di profondità (breadth-first), partendo dalle foglie

L'albero è costituito da nodi contenenti interi. Ogni nodo può avere fino a due figli: il figlio di sinistra contiene valori minori o uguali al valore del nodo stesso, quello di destra valori strettamente maggiori. 

## Esempio

### Input

L'input contiene, su una sola riga, i valori separati da spazi. 

```
5 9 4 3 6 8 2 4
```

### Output

Ogni attraversamento produce una sola riga con i valori separati da spazi. 

Primo attraversamento
```
2 3 4 4 5 6 8 9
```
Secondo attraversamento
```
9 8 6 5 4 4 3 2
```
Terzo attraversamento
```
5 4 9 3 6 2 4 8
```
Quarto attraversamento
```
2 4 8 3 6 4 9 5
```

### Spiegazione

L'albero viene costruito in questo modo:

```
      5
     / \
    4   9
   /   /
  3   6
 / \   \
2   4   8
```

Il primo attraversamento è un depth-first che va in ordine dal più piccolo al più grande (sinistra, centro, destra); il secondo va in ordine inverso. 

Il terzo e il quarto attraversamento procedono in larghezza (breadth-first): in un caso si visitano prima i nodi, nell'altro prima i figli. 

## Cosa devi fare

Apri la soluzione. Troverai due progetti: `Exercises` e `Test`. 

Il primo è una libreria di classi, che contiene le classi che dovrai scrivere o completare più altre accessorie. 

Il secondo è una libreria di test: i test useranno le classi e le funzioni della libreria `Exercises` con input noti, e controlleranno che il risultato sia quello atteso. Di norma, non serve modificare i test. 

In Visual Studio, puoi lanciare tutti i test premendo `CTRL-R, A`, oppure dal menu `Test` > `Esegui` > `Tutti i test`. Puoi debuggare tutti i test premendo `CTRL-R, CTRL-A`, oppure dal menu `Test` > `Debug` > `Tutti i test`. Puoi visualizzare i risultati dei test nella finestra `Esplora test`; se non è visibile, puoi richiamarla dal menu `Test` > `Finestre` > `Esplora test`, oppure premendo `CTRL-E, T`. 

### Questo esercizio

Nella libreria di classi c'è una classe `Node` che definisce l'albero BST. Non serve modificare questa classe. 

L'altra classe presente, `TreeTraverser`, è una classe statica, che raccoglie metodi statici. Dovrai implementare questi quattro metodi, secondo quanto descritto all'inizio. Ognuno di questi metodi deve restituire una stringa (non stamparla a video!), secondo quanto specificato sopra (vedi Esempio). 

Buon lavoro!
