﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tugas1
{
    class thesupercomputer
    {
        class printer
        {
            private String brand;
            private String series;
            private int ppm;

            public printer(String brand, String series, int ppm)
            {
                this.brand = brand;
                this.series = series;
                this.ppm = ppm;
            }

            public String getBrand()
            {
                return this.brand;
            }

            public String getSeries()
            {
                return this.series;
            }

            public int getPpm()
            {
                return this.ppm;
            }

            public override string ToString()
            {
                return $"Printer brand : {this.brand} ; Printer series : {this.series} ; Printer paper per minutes (ppm) : {this.ppm}";
            }
        }
    }
}

