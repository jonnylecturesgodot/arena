To get the repository

## Git Repo clonen

```
git clone https://github.com/jonnylecturesgodot/arena.git
```


## Bevor ihr Änderungen vornehmt

## Lokalen Branch erstellen
```
git branch gruppe12
```
## Wechseln in den Branch
```
git checkout gruppe12
```

## Jetzt könnt ihr Änderungen vornhemen und eure Ressourcen dem Projekt hinzufügen

## Euren Enemy hinzufügen
### Files vormerken
```
git add EnemyGruppe1.cs EnemyGruppe1.tscn
```
### Commit
```
git commit -m "gleich einen Kommentar mitgeben"
```

## Merge mit dem zentralen Repository
### Wenn ihr fertig seid
```
git checkout master
```
### Prüfen ob Änderungen im zentralen Repository vorliegen
```
git pull origin master
```
### Zusammenführen der lokalen Änderungen
```
git merge gruppe12
```
### Ins zentrale repository pushen
```
git push origin master
```


