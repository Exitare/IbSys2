﻿using System;
using System.Collections.Generic;
using Ibsys2.Service;
using static Ibsys2.Service.TranslateService;


namespace Ibsys2.Service {
    public static class EnglishTranslation {
        private static Dictionary<string, string> _translate = new Dictionary<string, string>();

        public static void AddLanguage() {
            Translate();
            TranslateService.Class.AddTranslation(new Language("en", "English"), _translate);
        }

        private static void Translate() {
            _translate.Add("HELLO", "Hello");
            _translate.Add("SETTINGS_SAVED", "Settings saved! Would you like to restart the Program? Without a restart translate errors will occur!");
            _translate.Add("SETTINGS", "Settings");
            _translate.Add("XML_ERROR", "This is not a XML File!");
            _translate.Add("ONLY_INT_ERROR", "Please use only integer values!");
            _translate.Add("SALES_ORDERS", "Sales orders");
            _translate.Add("FORECASTS", "Forecasts");
            _translate.Add("CHILDREN_BICYCLE", "Children's bicycle");
            _translate.Add("LADY_BICYCLE", "Lady's bicycle");
            _translate.Add("MEN_BICYCLE", "Men's bycicle");
            _translate.Add("TOTAL", "Total");
            _translate.Add("PRIMARY_REQ", "Primary requirements");
            _translate.Add("MAT_PLAN", "Material planning");
            _translate.Add("DELIVERY_RELIABILITY", "Delivery reliability");
            _translate.Add("THROUGHPUT_TIME", "Throughput time");
            _translate.Add("CAPACITY_UTILIZATION", "Capacity utilization");
            _translate.Add("STORE_VALUE", "Store value");
            _translate.Add("PRODUCTION_COSTS", "Production costs");
            _translate.Add("OPERATING_PROFIT", "Operating profit");
            _translate.Add("TARGET_PLANING", "Target planning");
            _translate.Add("SUPPLY_CHAIN", "supply chain");
            _translate.Add("SAFETY_STOCK", "Safety stock");
            _translate.Add("PLANNED_WAREHOUSE", "Planned warehouse stock at the end of the following period (safety stock)");
            _translate.Add("END_WAREHOUSE_STOCK", "Warehouse stock at the end of the passed period");
            _translate.Add("ORDERS_QUEUE", "Orders in the waiting queue");
            _translate.Add("WORK_IN_PROGRESS", "Work in progress");
            _translate.Add("PRODUCTION_ORDERS_FOR_COMMING", "Production orders for the following period");
            _translate.Add("DESCRIPTION", "Description");
            _translate.Add("REAR_WHEEL", "Rear wheel");
            _translate.Add("FRONT_WHEEL", "Front wheel");
            _translate.Add("MUDGUARD_REAR", "Mudguard rear");
            _translate.Add("MUDGUARD_FRONT", "Mudguard front");
            _translate.Add("HANDLE_BAR", "Handle bar");
            _translate.Add("SEAT", "Seat");
            _translate.Add("FRAME", "Frame");
            _translate.Add("PEDAL", "Pedal");
            _translate.Add("FRONT_WHEEL_COMPLETE", "Front wheel complete (clp)");
            _translate.Add("FRAME_AND_WHEELS", "Frame and wheels");
            _translate.Add("BICYCLE_WITHOUT_PEDAL", "Bicycle w/o pedal");
            _translate.Add("BICYCLE_COMPLETE", "Bicycle complete (clp)");
            _translate.Add("CAPACITY_REQ_NEW", "Capacity requirements (new)");
            _translate.Add("SETUP_TIME_NEW", "Setup time (new)");
            _translate.Add("CAP_REQ_PREV", "Cap. req. (backlog prev. periods)");
            _translate.Add("SETUP_TIME_PREV", "Setup time (backlog prev. periods");
            _translate.Add("TOTAL_CAP_REQ", "Total capacity requirements");
            _translate.Add("SHIFTS_OVERTIME", "Shifts and overtime");
            _translate.Add("CAPACITY_PLAN", "Capacity Planning");
            _translate.Add("WORKPLACE", "Workplace");
            _translate.Add("ORDER_QUANTITY", "Order quantity");
            _translate.Add("ITEM_NO", "Item No.");
            _translate.Add("PRODUCTION_PROGRAM", "Production programm");
            _translate.Add("DELIVERY_TIME", "Delivery time");
            _translate.Add("DEVIATION", "Deviation");
            _translate.Add("USED_IN", "Used in");
            _translate.Add("DISCOUNT_QUANTITY", "Discount quantity");
            _translate.Add("INITIAL_STOCK", "Initial stock");
            _translate.Add("GROSS_REQ", "Gross requirements according the prod. progr.");
            _translate.Add("ORDER", "Order");
            _translate.Add("STOCK_AFTER", "Stock after intended goods receipt");
            _translate.Add("PURCH_ITEMS", "Purchased items");
            _translate.Add("DIRECT_SALES", "Direct sales");
            _translate.Add("PURCH_ORDERS", "Purchase orders");
            _translate.Add("FAST", "fast");
            _translate.Add("PRODUCTION_ORDERS", "Production orders");
            _translate.Add("CAP_REQ", "Capacity requirements");
            _translate.Add("QUANTITY", "Quantity");
            _translate.Add("SHIFTS", "Shifts");
            _translate.Add("OVERTIME", "Overtime [Min/Day]");
            _translate.Add("PURCHASING", "Purchasing");
            _translate.Add("CHAIN", "Chain");
            _translate.Add("NUT_three", "Nut 3/8");
            _translate.Add("WASHER", "Washer 3/8");
            _translate.Add("SCREW", "Screw 3/8");
            _translate.Add("TUBE", "Tube 3/8");
            _translate.Add("PAINT", "Paint");
            _translate.Add("RIM", "Rim complete");
            _translate.Add("SPOKE", "Spoke");
            _translate.Add("TAPER", "Taper sleeve");
            _translate.Add("FREE", "Free wheel");
            _translate.Add("FORK", "Fork");
            _translate.Add("AXLE", "Axle");
            _translate.Add("SHEET", "Sheet");
            _translate.Add("NUT_FOUR", "Nut 3/4");
            _translate.Add("HANDLE_GRIP", "Handle grip");
            _translate.Add("SADDLE", "Saddle");
            _translate.Add("BAR", "Bar 1/2");
            _translate.Add("NUT_QUARTER", "Nut 1/4");
            _translate.Add("SCREW_QUARTER", "Screw 1/4");
            _translate.Add("SPROCKET", "Sprocket");
            _translate.Add("WELDING_WIRES", "Welding Wires");
            _translate.Add("ITEM_VALUE", " Item value [€]");
            _translate.Add("STOCK_QUANTITY_PIECE", "Stock quantity [piece]");
            _translate.Add("DISCOUNT_QUANTITY_PIECE", "Discount quantity [piece]");
            _translate.Add("ORDER_COSTS", "Order costs [€]");
            _translate.Add("PROCURE", "Procure lead-time [Period]");
            _translate.Add("DEVIATION_PERIOD", "Deviation +/- [Period]");
            _translate.Add("REAR_WHEEL_GROUP", "Rear wheel group");
            _translate.Add("FRONT_WHEEL_GROUP", "Front wheel group");
            _translate.Add("HANDLE_COMPLETE", "Handle complete");
            _translate.Add("SADDLE_COMPLETE", "Saddle complete");
            _translate.Add("WHERE_USED", "Where used");
            _translate.Add("IN_HOUSE", "In-house manufactured part and component");
            _translate.Add("USED_IN_C", "Used in children's bicycle");
            _translate.Add("USED_IN_L", "Used in ladies bicycle");
            _translate.Add("USED_IN_M", "Used in men's bicycle");
            _translate.Add("SECURITYFACTOR_EMPTY", "Security Facttor");
            _translate.Add("INPUT_VALUE_ERROR","The Input Value is not valid");
            _translate.Add("XML_MALFORMED", "XML is malformed!");
            _translate.Add("INPUT_NOT_COMPLETE", "Please fill all needed Fields.");
            _translate.Add("SUM_TOO_BIG", "The sum is too big! Value should be equal or lower than 1050!");
        }

    }

}