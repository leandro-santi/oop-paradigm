class ISubject:
    def addWatch(self, IWatchers):
        pass
    def notify(self):
        pass
class IWatchers:
    def alert(self):
        pass

class Alarm(ISubject):
    def __init__(self):
        self.__watchers = []
    def addWatch(self, IWatchers):
        self.__watchers.append(IWatchers)
    def notify(self):
        for watcher in self.__watchers:
            watcher.alert()

class FireStation(IWatchers):
    def alert(self):
        print("Bombeiros respondendo! Estamos a caminho")

class PoliceStation(IWatchers):
    def alert(self):
        print("Policia respondendo! Estamos a caminho")

class HospitalStation(IWatchers):
    def alert(self):
        print("Hospital respondendo! Estamos a caminho")

class Main:
    def main(self):
        alarm = Alarm()
        alarm.addWatch(FireStation())
        alarm.addWatch(HospitalStation())
        alarm.addWatch(PoliceStation())
        alarm.notify()

if __name__ == "__main__":
    Main().main()