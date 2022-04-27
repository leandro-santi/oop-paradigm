#!/bin/ruby

class ISubject
  def add_watch watchers
  end
  def notify
  end
end

class IWatchers
  def alert
  end
end

class Alarm < ISubject
  def initialize
    @watchers = Array.new
  end
  def add_watch watchers
    @watchers << watchers
  end
  def notify
    @watchers.each do |watcher|
      watcher.alert()
    end
  end
end

class FireStation < IWatchers
  def alert
    puts "Bombeiros respondendo! Estamos a caminho"
  end
end

class PoliceStation < IWatchers
  def alert
    puts "Policia respondendo! Estamos a caminho"
  end
end

class HospitalStation < IWatchers
  def alert
    puts "Hospital respondendo! Estamos a caminho"
  end
end

alarm = Alarm.new
alarm.add_watch FireStation.new
alarm.add_watch HospitalStation.new
alarm.add_watch PoliceStation.new
alarm.notify
