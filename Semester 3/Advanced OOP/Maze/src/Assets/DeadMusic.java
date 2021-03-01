package Assets;



import java.io.BufferedInputStream;
import java.io.FileInputStream;
import javazoom.jl.player.Player;

public class DeadMusic {

    private String filename;
    private static Player player;
    Thread playMusic;
    // constructor that takes the name of an MP3 file

    public DeadMusic(String filename) {
        this.filename = filename;
    }

    // play the MP3 file to the sound card
    public void play() {
        try {
            FileInputStream fis = new FileInputStream(filename);
            BufferedInputStream bis = new BufferedInputStream(fis);
            player = new Player(bis);
        } catch (Exception e) {
            System.out.println("Problem playing file " + filename);
            System.out.println(e);
        }
    }

    public void start() {
        play();
        playMusic = new Thread(new PlayMusic());
        playMusic.start();
    }

    public void stop() {
        close();
        playMusic = null;
    }

    public void close() {
        if (player != null) {
            player.close();
        }
    }

    class PlayMusic implements Runnable {

        public void run() {
            try {
                player.play();
            }
            catch (Exception e) {
                System.out.println(e);
            }
        }
    }
}

