package test;

import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionAdapter;
import javax.swing.JComponent;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Image;
import java.awt.geom.Point2D;
import java.awt.geom.Ellipse2D;

public class DrawArea extends JComponent {
    //Canvas panel to draw
    Canvas c = new Canvas();


    // Image in which we're going to draw
    private Image image;
    // Graphics2D object ==> used to draw on
    private Graphics2D g2;
    // Mouse coordinates
    private int currentX, currentY, oldX, oldY;

    // Activate Draws.
    private boolean isActivatedCircleDraw = false;
    private int clickCounterCircle = 0;
    Point2D center = null;
    Point2D p2;

    public DrawArea() {
        setDoubleBuffered(false);
        addMouseListener(new MouseAdapter() {
            public void mousePressed(MouseEvent e) {//Cuando hacemos click
                // save coord x,y when mouse is pressed
                oldX = e.getX();
                oldY = e.getY();


                if(isActivatedCircleDraw){//Si se quiere dibujar un circulo
                    clickCounterCircle++;
                    if(clickCounterCircle == 1){//Si se presiono 1 vez el click
                        //Obtienes el primer punto osea el centro
                        center = new Point2D.Double(e.getX(), e.getY());
                        System.out.println(center);
                    }

                    if(clickCounterCircle == 2){
                        //Obtienes el segundo punto
                        p2 = new Point2D.Double(e.getX(), e.getY());
                        drawCircle(center, p2);
                    }
                }
                System.out.println(clickCounterCircle);
            }
        });

        addMouseMotionListener(new MouseMotionAdapter() {
            public void mouseDragged(MouseEvent e) {
                // coord x,y when drag mouse
                currentX = e.getX();
                currentY = e.getY();

                if (g2 != null) {
                    // draw line if g2 context not null
                    //g2.drawLine(oldX, oldY, currentX, currentY);
                    // refresh draw area to repaint
                    repaint();
                    // store current coords x,y as olds x,y
                    oldX = currentX;
                    oldY = currentY;
                }
            }
        });
    }

    protected void paintComponent(Graphics g) {
        if (image == null) {
            // image to draw null ==> we create
            image = createImage(getSize().width, getSize().height);
            g2 = (Graphics2D) image.getGraphics();
            // enable antialiasing
            g2.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);
            // clear draw area
            clear();
        }

        g.drawImage(image, 0, 0, null);
    }

    // now we create exposed methods
    public void clear() {
        g2.setPaint(Color.white);
        // draw white on entire draw area to clear
        g2.fillRect(0, 0, getSize().width, getSize().height);
        g2.setPaint(Color.black);
        repaint();
    }

    public void red() {
        // apply red color on g2 context
        g2.setPaint(Color.red);
    }

    public void black() {
        g2.setPaint(Color.black);
    }

    public void magenta() {
        g2.setPaint(Color.magenta);
    }

    public void green() {
        g2.setPaint(Color.green);
    }

    public void blue() {
        g2.setPaint(Color.blue);
    }

    public void drawCircle() {
        isActivatedCircleDraw = true;
    }

    private void drawCircle(Point2D center, Point2D p2){
        //Movemos el mouse para buscar el centro del circulo.
        //Hacemos click para seleccionar el centro.
        //Movemos el mouse para aumentar el radio del circulo.
        double radius = center.distance(p2);//Obten la distancia del centro al punto 2 que seria el radio
        System.out.println("El radio del circulo es: "+ radius);//Printea radio
        System.out.println("El punto central del circulo es: "+ center);//Printea el punto del centro.
        Ellipse2D circle = new Ellipse2D.Double(center.getX() - radius, center.getY() - radius, 2 * radius, 2 * radius);
        g2.draw(circle);
        clickCounterCircle = 0;
        isActivatedCircleDraw = false;
        repaint();
    }

}
