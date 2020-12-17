package app;

import app.DrawArea;

import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class SwingPaint {

    JButton CircleButton;
    DrawArea drawArea;
    ActionListener actionListener = new ActionListener() {

        public void actionPerformed(ActionEvent e) {
            if (e.getSource() == CircleButton) {
                drawArea.drawCircle();
            }
        }
    };

    public static void main(String[] args) {
        new SwingPaint().show();
    }

    public void show() {
        // Crea la ventana principal
        JFrame frame = new JFrame("Canvas Paint");
        Container content = frame.getContentPane();
        // set layout on content pane
        content.setLayout(new BorderLayout());
        // create una nueva area de dibujo
        drawArea = new DrawArea();

        // add to agrega el area de dibujo al contenedor ?
        content.add(drawArea, BorderLayout.CENTER);

        // crea una clase de control para utilizarla despues
        JPanel controls = new JPanel();

        CircleButton = new JButton("O");//Crea el Boton del circulo
        CircleButton.addActionListener(actionListener);//Agrega un action listener al boton del circulo

        // add to panel
        controls.add(CircleButton);

        // add to content pane
        content.add(controls, BorderLayout.NORTH);

        frame.setSize(800, 600);
        // can close frame
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        // show the swing paint result
        frame.setVisible(true);

    }

}