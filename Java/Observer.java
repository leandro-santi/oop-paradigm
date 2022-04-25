package com.company;

import java.util.ArrayList;

public class Observer {

    public static void main(String[] args) {
	    // write your code here
        Alarm alarm = new Alarm();
        alarm.AddWatcher(new FireStation());
        alarm.AddWatcher(new PoliceStation());
        alarm.AddWatcher(new HospitalStation());
        alarm.Notify();
    }

    public static class Alarm {
        ArrayList<IWatcher> iWatchers = new ArrayList<>();

        public void AddWatcher(IWatcher alarm){
            iWatchers.add(alarm);
        }

        public void Notify(){
            for (IWatcher w : iWatchers) {
                w.Alert();
            }
        }
    }

    interface IWatcher {
        public void Alert();
    }

    public static class FireStation implements IWatcher {
        @Override
        public void Alert() {
            System.out.println("Bombeiros respondendo! Estamos a caminho");
        }
    }

    public static class PoliceStation implements IWatcher {
        @Override
        public void Alert() {
            System.out.println("Policia respondendo! Estamos a caminho");
        }
    }

    public static class HospitalStation implements IWatcher{
        @Override
        public void Alert() {
            System.out.println("Hospital respondendo! Estamos a caminho");
        }
    }
}
