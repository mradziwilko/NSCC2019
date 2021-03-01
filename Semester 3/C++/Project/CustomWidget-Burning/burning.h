#pragma once

#include <QWidget>
#include <QSlider>
#include <QFrame>
#include "widget.h"

class Burning : public QFrame {

  Q_OBJECT

  public:
    Burning(QWidget *parent = 0);
    int getCurrentWidth();

  public slots:
    void valueChanged(int);

  private:
    QSlider *slider;
    Widget *widget;
    int cur_width;

    void initUI();
};
