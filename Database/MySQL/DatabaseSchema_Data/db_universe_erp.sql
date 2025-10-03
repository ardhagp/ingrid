/*
 Navicat MySQL Dump SQL

 Source Server         : Aiven.io
 Source Server Type    : MySQL
 Source Server Version : 80035 (8.0.35)
 Source Host           : localhost:3306
 Source Schema         : defaultdb

 Target Server Type    : MySQL
 Target Server Version : 80035 (8.0.35)
 File Encoding         : 65001

 Date: 30/09/2025 23:52:20
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for ac_account
-- ----------------------------
DROP TABLE IF EXISTS `ac_account`;
CREATE TABLE `ac_account`  (
  `account_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `account_book` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `account_group` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `account_num` varchar(7) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `account_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `account_enable` tinyint NULL DEFAULT NULL,
  PRIMARY KEY (`account_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for cus_task
-- ----------------------------
DROP TABLE IF EXISTS `cus_task`;
CREATE TABLE `cus_task`  (
  `task_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `task_directive` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `task_priority` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `task_duedate` datetime NULL DEFAULT NULL,
  `task_description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `task_createdby` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `task_appointedperson` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `task_completedby` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `task_statevalue` int NULL DEFAULT NULL,
  `task_iscomplete` bit(1) NULL DEFAULT NULL,
  `task_completedate` datetime NULL DEFAULT NULL,
  PRIMARY KEY (`task_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for dsp_carrier
-- ----------------------------
DROP TABLE IF EXISTS `dsp_carrier`;
CREATE TABLE `dsp_carrier`  (
  `carrier_id` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `carrier_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `carrier_ownership` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `carrier_travelvia` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`carrier_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for eni_miap_bulk
-- ----------------------------
DROP TABLE IF EXISTS `eni_miap_bulk`;
CREATE TABLE `eni_miap_bulk`  (
  `eni_num_paper` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `eni_miap` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `eni_qty` int NULL DEFAULT NULL,
  `eni_num` int UNSIGNED NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`eni_num`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for ext_contractor
-- ----------------------------
DROP TABLE IF EXISTS `ext_contractor`;
CREATE TABLE `ext_contractor`  (
  `mst_contractorid` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mst_contractorcode` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mst_contractorname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mst_contractorphone` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`mst_contractorid`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for log_material
-- ----------------------------
DROP TABLE IF EXISTS `log_material`;
CREATE TABLE `log_material`  (
  `material_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `material_code` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `material_code2` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `material_materialgroup` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `material_materialtype` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `material_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `material_longtext` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `material_partnumber` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `material_manufacturename` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `material_origin` char(3) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT 'Fill this column with Z18 / Z20 / Z78',
  PRIMARY KEY (`material_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for log_materialgroup
-- ----------------------------
DROP TABLE IF EXISTS `log_materialgroup`;
CREATE TABLE `log_materialgroup`  (
  `materialgroup_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `materialgroup_code` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `materialgroup_description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `materialgroup_description2` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `materialgroup_language` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`materialgroup_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for log_materialsoh
-- ----------------------------
DROP TABLE IF EXISTS `log_materialsoh`;
CREATE TABLE `log_materialsoh`  (
  `soh_id` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `soh_code` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `soh_materialid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `soh_slocid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `soh_qty` decimal(18, 2) NULL DEFAULT 0.00,
  `soh_avgprice` decimal(18, 2) NULL DEFAULT 0.00,
  PRIMARY KEY (`soh_id`) USING BTREE,
  INDEX `IDX_soh`(`soh_id` ASC) USING BTREE INVISIBLE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for log_materialtype
-- ----------------------------
DROP TABLE IF EXISTS `log_materialtype`;
CREATE TABLE `log_materialtype`  (
  `materialtype_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `materialtype_code` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `materialtype_description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `materialtype_default` bit(1) NULL DEFAULT NULL,
  PRIMARY KEY (`materialtype_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for log_materialuom
-- ----------------------------
DROP TABLE IF EXISTS `log_materialuom`;
CREATE TABLE `log_materialuom`  (
  `uom_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `uom_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `uom_description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`uom_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for man_company
-- ----------------------------
DROP TABLE IF EXISTS `man_company`;
CREATE TABLE `man_company`  (
  `company_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `company_code` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `company_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `company_searchterm1` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `company_searchterm2` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `company_description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`company_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for man_department
-- ----------------------------
DROP TABLE IF EXISTS `man_department`;
CREATE TABLE `man_department`  (
  `department_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `department_company` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `department_code` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `department_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `department_description` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`department_id`) USING BTREE,
  INDEX `FK_department_company_idx`(`department_company` ASC) USING BTREE,
  CONSTRAINT `FK_department_company` FOREIGN KEY (`department_company`) REFERENCES `man_company` (`company_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for man_employee
-- ----------------------------
DROP TABLE IF EXISTS `man_employee`;
CREATE TABLE `man_employee`  (
  `employee_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `employee_personalid` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`employee_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mat_catalog
-- ----------------------------
DROP TABLE IF EXISTS `mat_catalog`;
CREATE TABLE `mat_catalog`  (
  `mst_id` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `mst_materialcode` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_dcdcode` varchar(17) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_dcdcategory` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_plant` varchar(4) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_sloc` varchar(4) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_materialshorttext` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_materiallongtext` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_sponsor` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_val` int UNSIGNED NULL DEFAULT NULL,
  `mst_batch` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_partnumber` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_valclass` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_manufacturer` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_binloc` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_qty` int UNSIGNED NULL DEFAULT NULL,
  `mst_uom` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_avgprice` decimal(10, 2) NULL DEFAULT NULL,
  `mst_mattype` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_recordtype` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mst_origin` varchar(4) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`mst_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 162224 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mat_distribution
-- ----------------------------
DROP TABLE IF EXISTS `mat_distribution`;
CREATE TABLE `mat_distribution`  (
  `mat_dist_id` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mat_master_maincode` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mat_sloc_id` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mat_dist_qty` decimal(18, 2) NULL DEFAULT NULL,
  `mat_dist_amp` decimal(18, 2) NULL DEFAULT NULL,
  `mat_dist_tvalue` decimal(18, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`mat_dist_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mat_master
-- ----------------------------
DROP TABLE IF EXISTS `mat_master`;
CREATE TABLE `mat_master`  (
  `mat_id` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mat_maincode` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mat_subcode` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mat_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mat_longtext` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mat_uom` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mat_partnumber` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT 'to store part number',
  PRIMARY KEY (`mat_id`) USING BTREE,
  UNIQUE INDEX `UNQ_materialcode`(`mat_maincode` ASC, `mat_subcode` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mat_movement
-- ----------------------------
DROP TABLE IF EXISTS `mat_movement`;
CREATE TABLE `mat_movement`  (
  `mtx_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `mtx_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mtx_plant` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_sponsor` char(3) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_carrier` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_carriedby` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_datedelivery` date NULL DEFAULT NULL,
  `mtx_origin` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_dateexecuted` date NULL DEFAULT NULL,
  `mtx_destination` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_datebast` date NULL DEFAULT NULL,
  `mtx_datencr` date NULL DEFAULT NULL,
  `mtx_datesign` date NULL DEFAULT NULL,
  `mtx_po` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_potype` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_manifest` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_reservation` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_direction` varchar(4) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_totalvalue` decimal(18, 2) NULL DEFAULT 0.00,
  `mtx_revtoprint` int NULL DEFAULT 0,
  `mtx_mvt` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_lastitemcount` int NULL DEFAULT 0,
  `mtx_mrr_skep` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT 'N/A',
  `mtx_mrr_pib` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT 'N/A',
  `mtx_mrr_masterlist` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT 'N/A',
  `mtx_mrr_chk_pdn` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_po` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_certificates` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_deliveryorder` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_warrantyletter` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_safetydatasheet` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_emailprintout` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_leters` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_pib` tinyint NULL DEFAULT 0,
  `mtx_mrr_chk_skepmasterilst` tinyint NULL DEFAULT 0,
  `mtx_bast_receiver` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_acknowledge` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_superintendent` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_totalitem` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_received` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_rejectdiffpn` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_rejectdefect` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_rejectdocs` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_noappearance` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_bast_vendorpic` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_ncr_isactive` tinyint NULL DEFAULT 0,
  `mtx_ncr_whathappen` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `mtx_ncract_receivewosufficentdoc` tinyint NULL DEFAULT 0,
  `mtx_ncract_receivewoposting` tinyint NULL DEFAULT 0,
  `mtx_ncract_transferwosupportingdoc` tinyint NULL DEFAULT 0,
  `mtx_ncract_applycustombonds` tinyint NULL DEFAULT 0,
  `mtx_ncract_postreceivedwomaterialappearance` tinyint NULL DEFAULT 0,
  `mtx_ncrbak_email` tinyint NULL DEFAULT 0,
  `mtx_ncrbak_fax` tinyint NULL DEFAULT 0,
  `mtx_ncrbak_userpurchasingconf` tinyint NULL DEFAULT 0,
  `mtx_ncrimp_inventorynotupdate` tinyint NULL DEFAULT 0,
  `mtx_ncrimp_costincreased` tinyint NULL DEFAULT 0,
  `mtx_ncrimp_goodsissuenotpossible` tinyint NULL DEFAULT 0,
  `mtx_ncrimp_delayplannedoperation` tinyint NULL DEFAULT 0,
  `mtx_ncrimp_supplayingvendorsunpaid` tinyint NULL DEFAULT 0,
  `mtx_ncrimp_delaystransaction` tinyint NULL DEFAULT 0,
  `mtx_ncrsign_authbyname` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_ncrsign_authbydate` date NULL DEFAULT NULL,
  `mtx_ncrsign_fwdbyname` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_ncrsign_department` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_ncrsign_date` date NULL DEFAULT NULL,
  `mtx_ncractaf_completepurchasingsupportingdocument` tinyint NULL DEFAULT 0,
  `mtx_ncractaf_completegoodreceivetransfergoodsissuesinv` tinyint NULL DEFAULT 0,
  `mtx_ncractaf_updatereissuemasterlist` tinyint NULL DEFAULT 0,
  `mtx_ncractaf_closeadinterimcustomspib` tinyint NULL DEFAULT 0,
  `mtx_ncrprev_requestingprocesstobedoneinadvance` tinyint NULL DEFAULT 0,
  `mtx_ncrprev_vendorsareadvisedtoidentifypo` tinyint NULL DEFAULT 0,
  `mtx_ncrprev_anychangeadvisedinadvance` tinyint NULL DEFAULT 0,
  `mtx_ncrprev_followstepoperationallymaterialmanagementprocess` tinyint NULL DEFAULT 0,
  `mtx_ncrprev_apply14daysmaterialcalloffplanningtologistics` tinyint NULL DEFAULT 0,
  `mtx_ncr_closedatetarget` date NULL DEFAULT NULL,
  `mtx_ncr_closedby` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_receiver_title` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_acknowledge_title` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_superintendent_title` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtx_sign_storekeeper` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `mtx_sign_materialman` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `mtx_sign_supervisor` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `mtx_att_link` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `mtx_ispublish` tinyint NULL DEFAULT 0,
  `mtx_publishcode` varchar(4) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_tree_parent` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_tree_type` tinyint NOT NULL DEFAULT 0,
  `mtx_createdby` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtx_createdtime` datetime NULL DEFAULT CURRENT_TIMESTAMP,
  `mtx_additionalnotes` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  PRIMARY KEY (`mtx_id`) USING BTREE,
  INDEX `IDX_rowid`(`mtx_rowid` ASC) USING BTREE,
  INDEX `FK_material_parent_idx`(`mtx_tree_type` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3472 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mat_movement_detail
-- ----------------------------
DROP TABLE IF EXISTS `mat_movement_detail`;
CREATE TABLE `mat_movement_detail`  (
  `mtxd_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `mtxd_mtxid_old` int NULL DEFAULT NULL,
  `mtxd_mtxid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtxd_no` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtxd_miap` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  `mtxd_miapnew` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtxd_dcdcode` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  `mtxd_dcdcodenew` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtxd_materialname` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `mtxd_materialcategory` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_partnumber` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_uom` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_valtype` int NULL DEFAULT 2,
  `mtxd_qstock` tinyint NULL DEFAULT 0,
  `mtxd_qty` decimal(18, 2) NULL DEFAULT 0.00,
  `mtxd_qty_check` decimal(18, 2) NULL DEFAULT 0.00,
  `mtxd_po` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_avgprice` decimal(18, 2) NULL DEFAULT NULL,
  `mtxd_totalvalue` decimal(18, 2) NULL DEFAULT NULL,
  `mtxd_binloc` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_binloc_new` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_destination` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_reference` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_remarks` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `mtxd_materialtype` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `mtxd_ownership` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_sapdoc` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_sapdocdate` date NULL DEFAULT NULL,
  `mtxd_category` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT 'GEN',
  `mtxd_sloc` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_packaging` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '',
  `mtxd_finalcheck` tinyint NULL DEFAULT 0,
  `mtxd_finalcheckby` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtxd_rofinalcheck` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtxd_roplant` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`mtxd_rowid`) USING BTREE,
  UNIQUE INDEX `INC_rowid`(`mtxd_rowid` ASC) USING BTREE,
  INDEX `FK_movement_movementdetail_idx`(`mtxd_mtxid` ASC) USING BTREE,
  CONSTRAINT `FK_movement_movementdetail` FOREIGN KEY (`mtxd_mtxid`) REFERENCES `mat_movement` (`mtx_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 25887 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mat_movement_handle
-- ----------------------------
DROP TABLE IF EXISTS `mat_movement_handle`;
CREATE TABLE `mat_movement_handle`  (
  `mtxh_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `mtxh_movementid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtxh_employeeid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mtxh_check` tinyint NULL DEFAULT 0,
  PRIMARY KEY (`mtxh_rowid`) USING BTREE,
  INDEX `FK_handle_movement_idx`(`mtxh_movementid` ASC) USING BTREE,
  INDEX `FK_employee_movementhandle_idx`(`mtxh_employeeid` ASC) USING BTREE,
  CONSTRAINT `FK_employee_movementhandle` FOREIGN KEY (`mtxh_employeeid`) REFERENCES `wsp_employee` (`employee_id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_movement_movementhandle` FOREIGN KEY (`mtxh_movementid`) REFERENCES `mat_movement` (`mtx_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 48751 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mat_movement_ncr
-- ----------------------------
DROP TABLE IF EXISTS `mat_movement_ncr`;
CREATE TABLE `mat_movement_ncr`  (
  `ncr_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `ncr_id` int NOT NULL,
  `ncr_mtxid_old` int NULL DEFAULT NULL,
  `ncr_mtxid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ncr_no` int NULL DEFAULT NULL,
  `ncr_miap` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '-',
  `ncr_dcd` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  `ncr_materialname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_pn` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_reason` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `ncr_deliveredremarks` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `ncr_qty` int NULL DEFAULT NULL,
  `ncr_uom` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_deliverystatus` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_ncritemstatus` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_ncritemclosedate` date NULL DEFAULT NULL,
  `ncr_attachment` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `ncr_displaystatus` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_displayclosedate` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_closingaction` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_closingnotes` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `ncr_closingevidence` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `ncr_closedby` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ncr_additionalnotes` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `ncr_att_link` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  PRIMARY KEY (`ncr_id`) USING BTREE,
  UNIQUE INDEX `INC_rowid`(`ncr_rowid` ASC) USING BTREE,
  INDEX `FK_movement_movementncr_idx`(`ncr_mtxid` ASC) USING BTREE,
  CONSTRAINT `FK_movement_movementncr` FOREIGN KEY (`ncr_mtxid`) REFERENCES `mat_movement` (`mtx_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for mat_movement_tree
-- ----------------------------
DROP TABLE IF EXISTS `mat_movement_tree`;
CREATE TABLE `mat_movement_tree`  (
  `mtxt_id` tinyint NOT NULL,
  `mtxt_parentdesc` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`mtxt_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for par_relation
-- ----------------------------
DROP TABLE IF EXISTS `par_relation`;
CREATE TABLE `par_relation`  (
  `par_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `par_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `par_plantid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `par_category` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `par_joborder` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT 'WAITING',
  `par_eventname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `par_coverage` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `par_requestby` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `par_requestdatetime` datetime NULL DEFAULT NULL,
  `par_requeststarttime` datetime NULL DEFAULT NULL,
  `par_requestfinishedtime` datetime NULL DEFAULT NULL,
  `par_remarks` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `par_typeofpenalty` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`par_id`) USING BTREE,
  INDEX `IDX_rowid`(`par_rowid` ASC) USING BTREE,
  INDEX `FK_relation_plant_idx`(`par_plantid` ASC) USING BTREE,
  INDEX `FK_relation_relationcategory_idx`(`par_category` ASC) USING BTREE,
  CONSTRAINT `FK_relation_plant` FOREIGN KEY (`par_plantid`) REFERENCES `wsp_plant` (`plant_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_relation_relationcategory` FOREIGN KEY (`par_category`) REFERENCES `par_relation_category` (`par_category_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci COMMENT = 'partner relation' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for par_relation_category
-- ----------------------------
DROP TABLE IF EXISTS `par_relation_category`;
CREATE TABLE `par_relation_category`  (
  `par_category_rowid` int NOT NULL AUTO_INCREMENT,
  `par_category_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `par_category_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`par_category_id`) USING BTREE,
  UNIQUE INDEX `IDX_relation_category`(`par_category_rowid` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for snp_catalog_snapshot
-- ----------------------------
DROP TABLE IF EXISTS `snp_catalog_snapshot`;
CREATE TABLE `snp_catalog_snapshot`  (
  `snap_id` int NOT NULL AUTO_INCREMENT,
  `snap_date` date NULL DEFAULT NULL,
  PRIMARY KEY (`snap_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sys_access_level
-- ----------------------------
DROP TABLE IF EXISTS `sys_access_level`;
CREATE TABLE `sys_access_level`  (
  `accesslevel_id` tinyint UNSIGNED NOT NULL,
  `accesslevel_name` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`accesslevel_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sys_log
-- ----------------------------
DROP TABLE IF EXISTS `sys_log`;
CREATE TABLE `sys_log`  (
  `log_id` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `log_user` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT 'N/A',
  `log_date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `log_message` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
  `log_area` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `log_level` varchar(7) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `log_machine` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `log_os` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `log_appver` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `log_address` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `log_mac` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`log_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2369 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sys_module
-- ----------------------------
DROP TABLE IF EXISTS `sys_module`;
CREATE TABLE `sys_module`  (
  `module_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `module_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `module_code` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`module_id`) USING BTREE,
  UNIQUE INDEX `mod_code_UNIQUE`(`module_code` ASC) USING BTREE,
  INDEX `IDX_MOD`(`module_rowid` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 19 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sys_module_access
-- ----------------------------
DROP TABLE IF EXISTS `sys_module_access`;
CREATE TABLE `sys_module_access`  (
  `moduleaccess_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `moduleaccess_moduleid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `moduleaccess_employeeid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `moduleaccess_accesslevel` tinyint UNSIGNED NOT NULL DEFAULT 0,
  PRIMARY KEY (`moduleaccess_rowid`) USING BTREE,
  INDEX `FK_module_idx`(`moduleaccess_moduleid` ASC) USING BTREE,
  INDEX `FK_accesslevel_idx`(`moduleaccess_accesslevel` ASC) USING BTREE,
  INDEX `FK_employee_moduleaccess_idx`(`moduleaccess_employeeid` ASC) USING BTREE,
  CONSTRAINT `FK_accesslevel` FOREIGN KEY (`moduleaccess_accesslevel`) REFERENCES `sys_access_level` (`accesslevel_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_employee_moduleaccess` FOREIGN KEY (`moduleaccess_employeeid`) REFERENCES `wsp_employee` (`employee_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_module_moduleaccess` FOREIGN KEY (`moduleaccess_moduleid`) REFERENCES `sys_module` (`module_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 1297 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for sys_settings
-- ----------------------------
DROP TABLE IF EXISTS `sys_settings`;
CREATE TABLE `sys_settings`  (
  `sys_id` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `sys_appversion` int UNSIGNED NULL DEFAULT NULL,
  `sys_key` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`sys_id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for wsp_employee
-- ----------------------------
DROP TABLE IF EXISTS `wsp_employee`;
CREATE TABLE `wsp_employee`  (
  `employee_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `employee_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `employee_code` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '<new>',
  `employee_title` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '<new>',
  `employee_fullname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '<new>',
  `employee_password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `employee_password_web` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `employee_password_temporary` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `employee_slocid` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `employee_sponsor` varchar(3) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'I04',
  `employee_role` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'Guest',
  `employee_isadmin` tinyint NOT NULL DEFAULT 0,
  `employee_scopeofwork` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  `employee_islocked` tinyint NOT NULL DEFAULT 0,
  `employee_datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `employee_lastmodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `employee_islogin` tinyint NOT NULL DEFAULT 0,
  `employee_lastlogin` datetime NULL DEFAULT NULL,
  `employee_expiry` datetime NULL DEFAULT NULL,
  `employee_isnew` tinyint NULL DEFAULT 1,
  PRIMARY KEY (`employee_id`) USING BTREE,
  INDEX `FK_user_sloc_idx`(`employee_slocid` ASC) USING BTREE,
  INDEX `ID_user_row`(`employee_rowid` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 30 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for wsp_employee_workingarea
-- ----------------------------
DROP TABLE IF EXISTS `wsp_employee_workingarea`;
CREATE TABLE `wsp_employee_workingarea`  (
  `workingarea_id` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `workingarea_slocid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `workingarea_employeeid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `workingarea_access` tinyint NOT NULL DEFAULT 0,
  PRIMARY KEY (`workingarea_id`) USING BTREE,
  INDEX `FK_workingarea_sloc_idx`(`workingarea_slocid` ASC) USING BTREE,
  INDEX `FK_employee_employeeworkingarea_idx`(`workingarea_employeeid` ASC) USING BTREE,
  CONSTRAINT `FK_employee_employeeworkingarea` FOREIGN KEY (`workingarea_employeeid`) REFERENCES `wsp_employee` (`employee_id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_sloc_workingarea` FOREIGN KEY (`workingarea_slocid`) REFERENCES `wsp_sloc` (`sloc_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 685 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for wsp_plant
-- ----------------------------
DROP TABLE IF EXISTS `wsp_plant`;
CREATE TABLE `wsp_plant`  (
  `plant_rowid` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `plant_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `plant_company` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `plant_code` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `plant_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `plant_address` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  `plant_officeblock` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  `plant_city` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  `plant_phone` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  `plant_fax` varchar(45) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  PRIMARY KEY (`plant_id`) USING BTREE,
  UNIQUE INDEX `mst_plantcode_UNIQUE`(`plant_code` ASC) USING BTREE,
  UNIQUE INDEX `ICM_rowid`(`plant_rowid` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for wsp_sloc
-- ----------------------------
DROP TABLE IF EXISTS `wsp_sloc`;
CREATE TABLE `wsp_sloc`  (
  `sloc_id` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `sloc_code` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `sloc_plantid` char(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `sloc_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `sloc_abbrevation` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '-',
  PRIMARY KEY (`sloc_id`) USING BTREE,
  INDEX `FK_plant_sloc_idx`(`sloc_plantid` ASC) USING BTREE,
  CONSTRAINT `FK_plant_sloc` FOREIGN KEY (`sloc_plantid`) REFERENCES `wsp_plant` (`plant_id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- View structure for q_employee
-- ----------------------------
DROP VIEW IF EXISTS `q_employee`;
CREATE SQL SECURITY DEFINER VIEW `q_employee` AS select "mwu"."employee_rowid" AS "USER_ROWID","mwu"."employee_id" AS "USER_ID","mwu"."employee_code" AS "USER_EMPLOYEEID","mwu"."employee_password" AS "USER_PASSWORD","mwu"."employee_title" AS "USER_TITLE","mwu"."employee_fullname" AS "USER_FULLNAME","mws"."sloc_plantid" AS "USER_PLANTID","mwp"."plant_code" AS "USER_PLANTCODE","mwp"."plant_name" AS "USER_PLANTNAME","mwu"."employee_slocid" AS "USER_SLOCID","mws"."sloc_code" AS "USER_SLOCCODE","mws"."sloc_name" AS "USER_SLOCNAME","mws"."sloc_abbrevation" AS "USER_SLOCABBRV","mwu"."employee_sponsor" AS "USER_SPONSOR",if(("mwu"."employee_isadmin" = -(1)),'Yes','No') AS "USER_ISADMIN",if(("mwu"."employee_islocked" = -(1)),'Yes','No') AS "USER_ISLOCKED","mwu"."employee_lastlogin" AS "USER_LASTLOGIN","mwu"."employee_datecreated" AS "USER_CREATED","mwu"."employee_lastmodified" AS "USER_LASTMODIFIED" from (("wsp_employee" "mwu" join "wsp_sloc" "mws" on(("mwu"."employee_slocid" = "mws"."sloc_id"))) join "wsp_plant" "mwp" on(("mws"."sloc_plantid" = "mwp"."plant_id"))) order by "mwu"."employee_fullname";

-- ----------------------------
-- View structure for q_employee_access
-- ----------------------------
DROP VIEW IF EXISTS `q_employee_access`;
CREATE SQL SECURITY DEFINER VIEW `q_employee_access` AS select "mdc"."moduleaccess_rowid" AS "MODULEACCESS_ROWID","mdl"."module_code" AS "MODULE_CODE","mdc"."moduleaccess_accesslevel" AS "MODULEACCESS_ACCESSLEVEL","mdc"."moduleaccess_employeeid" AS "MODULEACCESS_EMPLOYEEID" from ("sys_module_access" "mdc" join "sys_module" "mdl" on(("mdc"."moduleaccess_moduleid" = "mdl"."module_id")));

-- ----------------------------
-- View structure for q_mat_sum_ncr_dashboard1
-- ----------------------------
DROP VIEW IF EXISTS `q_mat_sum_ncr_dashboard1`;
CREATE SQL SECURITY DEFINER VIEW `q_mat_sum_ncr_dashboard1` AS select count("mat_movement_ncr"."ncr_rowid") AS "NCR_TOTAL",(select count("mat_movement_ncr"."ncr_rowid") from "mat_movement_ncr" where ("mat_movement_ncr"."ncr_ncritemstatus" = 'Open')) AS "NCR_OPEN",(select count("mat_movement_ncr"."ncr_rowid") from "mat_movement_ncr" where ("mat_movement_ncr"."ncr_ncritemstatus" = 'Close')) AS "NCR_CLOSED",(select round(avg(if(("mat_movement_ncr"."ncr_ncritemclosedate" <=> NULL),NULL,(to_days("mat_movement_ncr"."ncr_ncritemclosedate") - to_days("mat_movement"."mtx_datencr")))),0) from ("mat_movement_ncr" join "mat_movement" on(("mat_movement"."mtx_id" = "mat_movement_ncr"."ncr_mtxid"))) where (("mat_movement_ncr"."ncr_ncritemstatus" = 'Close') and (not(("mat_movement_ncr"."ncr_ncritemclosedate" <=> NULL))))) AS "NCR_AVG" from "mat_movement_ncr";

-- ----------------------------
-- View structure for q_mat_sum_ncr_dashboard2
-- ----------------------------
DROP VIEW IF EXISTS `q_mat_sum_ncr_dashboard2`;
CREATE SQL SECURITY DEFINER VIEW `q_mat_sum_ncr_dashboard2` AS select year("mat_movement"."mtx_datencr") AS "YEAR_CREATED",count("mat_movement_ncr"."ncr_id") AS "TOTAL_NCR_CREATED" from ("mat_movement_ncr" join "mat_movement" on(("mat_movement_ncr"."ncr_mtxid" = "mat_movement"."mtx_id"))) where ("mat_movement"."mtx_ncr_isactive" <> 0) group by year("mat_movement"."mtx_datencr") order by year("mat_movement"."mtx_datencr") desc limit 0,5;

-- ----------------------------
-- View structure for q_mat_sum_ncr_dashboard3
-- ----------------------------
DROP VIEW IF EXISTS `q_mat_sum_ncr_dashboard3`;
CREATE SQL SECURITY DEFINER VIEW `q_mat_sum_ncr_dashboard3` AS select year("mat_movement_ncr"."ncr_ncritemclosedate") AS "YEAR_CLOSED",count("mat_movement_ncr"."ncr_id") AS "TOTAL_NCR_CLOSED" from ("mat_movement_ncr" join "mat_movement" on(("mat_movement_ncr"."ncr_mtxid" = "mat_movement"."mtx_id"))) where (("mat_movement_ncr"."ncr_ncritemstatus" = 'Close') and ("mat_movement_ncr"."ncr_ncritemclosedate" is not null)) group by year("mat_movement_ncr"."ncr_ncritemclosedate") order by year("mat_movement_ncr"."ncr_ncritemclosedate") desc limit 0,5;

-- ----------------------------
-- View structure for q_mat_sum_ncr_dashboard4
-- ----------------------------
DROP VIEW IF EXISTS `q_mat_sum_ncr_dashboard4`;
CREATE SQL SECURITY DEFINER VIEW `q_mat_sum_ncr_dashboard4` AS select "mtx"."mtx_origin" AS "ORIGIN_NCR",count("ncr"."ncr_id") AS "TOTAL_NCR_ISSUED",year("mtx"."mtx_datencr") AS "YEAR_NCR_ISSUED" from ("mat_movement_ncr" "ncr" join "mat_movement" "mtx" on(("mtx"."mtx_id" = "ncr"."ncr_mtxid"))) where ("mtx"."mtx_ncr_isactive" = 1) group by "mtx"."mtx_origin",year("mtx"."mtx_datencr") order by year("mtx"."mtx_datencr") desc,count("ncr"."ncr_id") desc;

-- ----------------------------
-- View structure for q_mat_sum_ncr_dashboard_year
-- ----------------------------
DROP VIEW IF EXISTS `q_mat_sum_ncr_dashboard_year`;
CREATE SQL SECURITY DEFINER VIEW `q_mat_sum_ncr_dashboard_year` AS select year("mtx"."mtx_datencr") AS "YEAR_NCR" from ("mat_movement_ncr" "ncr" join "mat_movement" "mtx" on(("mtx"."mtx_id" = "ncr"."ncr_mtxid"))) where (("mtx"."mtx_ncr_isactive" = 1) and ("mtx"."mtx_datencr" is not null)) group by year("mtx"."mtx_datencr") order by year("mtx"."mtx_datencr") desc;

-- ----------------------------
-- View structure for q_sys_db_size
-- ----------------------------
DROP VIEW IF EXISTS `q_sys_db_size`;
CREATE SQL SECURITY DEFINER VIEW `q_sys_db_size` AS select "information_schema"."tables"."TABLE_SCHEMA" AS "DATABASE",round((((sum(("information_schema"."tables"."DATA_LENGTH" + "information_schema"."tables"."INDEX_LENGTH")) / 1024) / 1024) / 1024),3) AS "GB",5 AS "MAX" from "information_schema"."TABLES" "tables" group by "information_schema"."tables"."TABLE_SCHEMA";

-- ----------------------------
-- View structure for q_sys_servertime
-- ----------------------------
DROP VIEW IF EXISTS `q_sys_servertime`;
CREATE SQL SECURITY DEFINER VIEW `q_sys_servertime` AS select convert_tz(now(),'SYSTEM','+07:00') AS "servertime_in_wib";

-- ----------------------------
-- View structure for t_accesslevel
-- ----------------------------
DROP VIEW IF EXISTS `t_accesslevel`;
CREATE SQL SECURITY DEFINER VIEW `t_accesslevel` AS select "acl"."accesslevel_id" AS "ACCESSLEVEL_ID","acl"."accesslevel_name" AS "ACCESSLEVEL_NAME" from "sys_access_level" "acl";

-- ----------------------------
-- View structure for t_employee
-- ----------------------------
DROP VIEW IF EXISTS `t_employee`;
CREATE SQL SECURITY DEFINER VIEW `t_employee` AS select "emp"."employee_rowid" AS "EMPLOYEE_ROWID","emp"."employee_id" AS "EMPLOYEE_ID","emp"."employee_code" AS "EMPLOYEE_CODE","emp"."employee_title" AS "EMPLOYEE_TITLE","emp"."employee_fullname" AS "EMPLOYEE_FULLNAME","emp"."employee_password" AS "EMPLOYEE_PASSWORD","emp"."employee_slocid" AS "EMPLOYEE_SLOCID","emp"."employee_sponsor" AS "EMPLOYEE_SPONSOR","emp"."employee_scopeofwork" AS "EMPLOYEE_SCOPEOFWORK","emp"."employee_isadmin" AS "EMPLOYEE_ISADMIN","emp"."employee_islocked" AS "EMPLOYEE_ISLOCKED","emp"."employee_islogin" AS "EMPLOYEE_ISLOGIN","emp"."employee_lastlogin" AS "EMPLOYEE_LASTLOGIN","emp"."employee_datecreated" AS "EMPLOYEE_DATECREATED","emp"."employee_lastmodified" AS "EMPLOYEE_LASTMODIFIED" from "wsp_employee" "emp";

-- ----------------------------
-- View structure for t_log
-- ----------------------------
DROP VIEW IF EXISTS `t_log`;
CREATE SQL SECURITY DEFINER VIEW `t_log` AS select "ml"."log_id" AS "LOG_ID","ml"."log_date" AS "LOG_DATETIME","ml"."log_message" AS "LOG_MESSAGE","ml"."log_area" AS "LOG_AREA","ml"."log_level" AS "LOG_LEVEL" from "sys_log" "ml" order by "ml"."log_date" desc;

-- ----------------------------
-- View structure for t_material_movement
-- ----------------------------
DROP VIEW IF EXISTS `t_material_movement`;
CREATE SQL SECURITY DEFINER VIEW `t_material_movement` AS select "mtx"."mtx_rowid" AS "TX_ROWID","mtx"."mtx_id" AS "TX_ID","mtx"."mtx_plant" AS "TX_PLANT","mtx"."mtx_sponsor" AS "TX_SPONSOR","mtx"."mtx_carrier" AS "TX_CARRIER","mtx"."mtx_carriedby" AS "TX_CARRIEDBY","mtx"."mtx_datedelivery" AS "TX_DATEDELIVERY","mtx"."mtx_origin" AS "TX_ORIGIN","mtx"."mtx_dateexecuted" AS "TX_DATEEXECUTED","mtx"."mtx_destination" AS "TX_DESTINATION","mtx"."mtx_datebast" AS "TX_DATEBAST","mtx"."mtx_datencr" AS "TX_DATENCR","mtx"."mtx_datesign" AS "TX_DATESIGN","mtx"."mtx_po" AS "TX_PO","mtx"."mtx_potype" AS "TX_POTYPE","mtx"."mtx_manifest" AS "TX_MANIFEST","mtx"."mtx_reservation" AS "TX_RESERVATION","mtx"."mtx_direction" AS "TX_DIRECTION","mtx"."mtx_totalvalue" AS "TX_TOTALVALUE","mtx"."mtx_revtoprint" AS "TX_REV","mtx"."mtx_mvt" AS "TX_MVT","mtx"."mtx_lastitemcount" AS "TX_LASTITEMCOUNT","mtx"."mtx_mrr_skep" AS "TX_MRR_SKEP","mtx"."mtx_mrr_pib" AS "TX_MRR_PIB","mtx"."mtx_mrr_masterlist" AS "TX_MRR_MASTERLIST","mtx"."mtx_mrr_chk_pdn" AS "TX_MRR_CHK_PDN","mtx"."mtx_mrr_chk_po" AS "TX_MRR_CHK_PO","mtx"."mtx_mrr_chk_certificates" AS "TX_MRR_CHK_CERT","mtx"."mtx_mrr_chk_deliveryorder" AS "TX_MRR_CHK_MANIFEST","mtx"."mtx_mrr_chk_warrantyletter" AS "TX_MRR_CHK_WARRANTYLETTER","mtx"."mtx_mrr_chk_safetydatasheet" AS "TX_MRR_CHK_SDS","mtx"."mtx_mrr_chk_pib" AS "TX_MRR_CHK_PIB","mtx"."mtx_mrr_chk_skepmasterilst" AS "TX_MRR_CHK_MASTERLIST","mtx"."mtx_mrr_chk_emailprintout" AS "TX_MRR_CHK_EMAILPRINTOUT","mtx"."mtx_mrr_chk_leters" AS "TX_MRR_CHK_LETTERS","mtx"."mtx_bast_receiver" AS "TX_BAST_RECEIVER","mtx"."mtx_bast_acknowledge" AS "TX_BAST_ACKNOWLEDGE","mtx"."mtx_bast_superintendent" AS "TX_BAST_SUPERINTENDENT","mtx"."mtx_bast_totalitem" AS "TX_BAST_TOTALITEM","mtx"."mtx_bast_received" AS "TX_BAST_RECEIVED","mtx"."mtx_bast_rejectdiffpn" AS "TX_BAST_REJECTDIFFPN","mtx"."mtx_bast_rejectdefect" AS "TX_BAST_REJECTDEFECT","mtx"."mtx_bast_rejectdocs" AS "TX_BAST_REJECTDOCUMENTS","mtx"."mtx_bast_noappearance" AS "TX_BAST_REJECTNOAPPEARANCE","mtx"."mtx_bast_vendorpic" AS "TX_BAST_VENDORPIC","mtx"."mtx_ncr_isactive" AS "TX_NCR_ISACTIVE","mtx"."mtx_ncr_whathappen" AS "TX_NCR_WHATHAPPEN","mtx"."mtx_ncract_receivewosufficentdoc" AS "TX_NCRACT_RECEIVEWOSUFFICIENTDOCS","mtx"."mtx_ncract_receivewoposting" AS "TX_NCRACT_RECEIVEWOPOSTING","mtx"."mtx_ncract_transferwosupportingdoc" AS "TX_NCRACT_TRANSFERWOSUPPORTINGDOCS","mtx"."mtx_ncract_applycustombonds" AS "TX_NCRACT_APPLYCUSTOMBONDS","mtx"."mtx_ncract_postreceivedwomaterialappearance" AS "TX_NCRACT_POSTRECEIVEDWOMATERIALAPPEARANCE","mtx"."mtx_ncrbak_email" AS "TX_NCRBAK_EMAIL","mtx"."mtx_ncrbak_fax" AS "TX_NCRBAK_FAX","mtx"."mtx_ncrbak_userpurchasingconf" AS "TX_NCRBAK_USERPURCHASINGCONF","mtx"."mtx_ncrimp_inventorynotupdate" AS "TX_NCRIMP_INVENTORYNOTUPDATE","mtx"."mtx_ncrimp_costincreased" AS "TX_NCRIMP_COSTINCREASED","mtx"."mtx_ncrimp_goodsissuenotpossible" AS "TX_NCRIMP_GOODSISSUENOTPOSSIBLE","mtx"."mtx_ncrimp_delayplannedoperation" AS "TX_NCRIMP_DELAYPLANNEDOPERATION","mtx"."mtx_ncrimp_supplayingvendorsunpaid" AS "TX_NCRIMP_SUPPLAYINGVENDORSUNPAID","mtx"."mtx_ncrimp_delaystransaction" AS "TX_NCRIMP_DELAYTRANSACTION","mtx"."mtx_ncrsign_authbyname" AS "TX_NCRSIGN_AUTHBYNAME","mtx"."mtx_ncrsign_authbydate" AS "TX_NCRSIGN_AUTHBYDATE","mtx"."mtx_ncrsign_fwdbyname" AS "TX_NCRSIGN_FWDBYNAME","mtx"."mtx_ncrsign_department" AS "TX_NCRSIGN_DEPT","mtx"."mtx_ncrsign_date" AS "TX_NCRSIGN_DATE","mtx"."mtx_ncractaf_completepurchasingsupportingdocument" AS "TX_NCRACTAF_COMPLETEPURCHASINGSUPPORTINGDOCS","mtx"."mtx_ncractaf_completegoodreceivetransfergoodsissuesinv" AS "TX_NCRACTAF_COMPLETEGOODRECEIVETRANSFERGOODSISSUESINV","mtx"."mtx_ncractaf_updatereissuemasterlist" AS "TX_NCRACTAF_UPDATEREISSUEMASTERLIST","mtx"."mtx_ncractaf_closeadinterimcustomspib" AS "TX_NCRACTAF_CLOSEDINTERIMCUSTOMPIB","mtx"."mtx_ncrprev_requestingprocesstobedoneinadvance" AS "TX_NCRPREV_REQUESTINGPROCESSTOBEDONEINADVANCE","mtx"."mtx_ncrprev_vendorsareadvisedtoidentifypo" AS "TX_NCRPREV_VENDORADVISEDTOIDENTIFYPO","mtx"."mtx_ncrprev_anychangeadvisedinadvance" AS "TX_NCRPREV_ANYCHANGEADVISEDINADVANCE","mtx"."mtx_ncrprev_followstepoperationallymaterialmanagementprocess" AS "TX_NCRPREV_FOLLOWSTEPOPERATIONALLYMATERIALMANAGEMENTPROCESS","mtx"."mtx_ncrprev_apply14daysmaterialcalloffplanningtologistics" AS "TX_NCRPREV_APPLY14DAY","mtx"."mtx_ncr_closedatetarget" AS "TX_NCR_CLOSEDATETARGET","mtx"."mtx_ncr_closedby" AS "TX_NCR_CLOSEBY","mtx"."mtx_receiver_title" AS "TX_RECEIVER_TITLE","mtx"."mtx_acknowledge_title" AS "TX_ACKNOWLEDGE_TITLE","mtx"."mtx_superintendent_title" AS "TX_SUPERINTENDENT_TITLE","mtx"."mtx_sign_storekeeper" AS "TX_SIGN_STOREKEEPER","mtx"."mtx_sign_materialman" AS "TX_SIGN_MATERIALMAN","mtx"."mtx_sign_supervisor" AS "TX_SIGN_SUPERVISOR","mtx"."mtx_att_link" AS "TX_ATT_LINK","mtx"."mtx_publishcode" AS "TX_PUBLISHCODE","mtx"."mtx_additionalnotes" AS "TX_ADDITIONALNOTES","mtx"."mtx_createdby" AS "TX_CREATEDBY","mtx"."mtx_createdtime" AS "TX_CREATEDTIME" from "mat_movement" "mtx" order by "mtx"."mtx_rowid";

-- ----------------------------
-- View structure for t_material_movement_detail
-- ----------------------------
DROP VIEW IF EXISTS `t_material_movement_detail`;
CREATE SQL SECURITY DEFINER VIEW `t_material_movement_detail` AS select "mtxd"."mtxd_rowid" AS "D_ROWID","mtxd"."mtxd_mtxid_old" AS "D_TXID_OLD","mtxd"."mtxd_mtxid" AS "D_MTXID","mtxd"."mtxd_no" AS "D_NO","mtxd"."mtxd_miap" AS "D_MIAP","mtxd"."mtxd_miapnew" AS "D_MIAPNEW","mtxd"."mtxd_dcdcode" AS "D_DCDCODE","mtxd"."mtxd_dcdcodenew" AS "D_DCDCODENEW","mtxd"."mtxd_materialname" AS "D_MATERIALNAME","mtxd"."mtxd_materialcategory" AS "D_MATERIALCATEGORY","mtxd"."mtxd_partnumber" AS "D_PARTNUMBER","mtxd"."mtxd_uom" AS "D_UOM","mtxd"."mtxd_valtype" AS "D_VALTYPE","mtxd"."mtxd_qty" AS "D_QTY","mtxd"."mtxd_po" AS "D_PO","mtxd"."mtxd_avgprice" AS "D_AVGPRICE","mtxd"."mtxd_totalvalue" AS "D_TOTALVALUE","mtxd"."mtxd_binloc" AS "D_BINLOC","mtxd"."mtxd_binloc_new" AS "D_BINLOCNEW","mtxd"."mtxd_destination" AS "D_DESTINATION","mtxd"."mtxd_reference" AS "D_REFERENCE","mtxd"."mtxd_remarks" AS "D_REMARKS","mtxd"."mtxd_materialtype" AS "D_MATERIALTYPE","mtxd"."mtxd_ownership" AS "D_OWNERSHIP","mtxd"."mtxd_sapdoc" AS "D_DOCSAP","mtxd"."mtxd_sapdocdate" AS "D_DATEDOCSAP","mtxd"."mtxd_category" AS "D_CATEGORY","mtxd"."mtxd_sloc" AS "D_SLOC","mtxd"."mtxd_packaging" AS "D_PACKAGING","mtxd"."mtxd_finalcheck" AS "D_FINALCHECK","mtxd"."mtxd_rofinalcheck" AS "D_ROFINALCHECK","mtxd"."mtxd_roplant" AS "D_ROPLANT" from "mat_movement_detail" "mtxd" order by "mtxd"."mtxd_rowid";

-- ----------------------------
-- View structure for t_material_movement_handle
-- ----------------------------
DROP VIEW IF EXISTS `t_material_movement_handle`;
CREATE SQL SECURITY DEFINER VIEW `t_material_movement_handle` AS select "mh"."mtxh_rowid" AS "HANDLE_ROWID","mh"."mtxh_movementid" AS "HANDLE_MOVEMENTID","mh"."mtxh_employeeid" AS "HANDLE_EMPLOYEEID","mh"."mtxh_check" AS "HANDLE_CHECK" from "mat_movement_handle" "mh";

-- ----------------------------
-- View structure for t_module
-- ----------------------------
DROP VIEW IF EXISTS `t_module`;
CREATE SQL SECURITY DEFINER VIEW `t_module` AS select "mdl"."module_rowid" AS "MODULE_ROWID","mdl"."module_id" AS "MODULE_ID","mdl"."module_code" AS "MODULE_CODE" from "sys_module" "mdl" order by "mdl"."module_code";

-- ----------------------------
-- View structure for t_moduleaccess
-- ----------------------------
DROP VIEW IF EXISTS `t_moduleaccess`;
CREATE SQL SECURITY DEFINER VIEW `t_moduleaccess` AS select "mdc"."moduleaccess_rowid" AS "MODULEACCESS_ROWID","mdc"."moduleaccess_moduleid" AS "MODULEACCESS_MODULEID","mdc"."moduleaccess_employeeid" AS "MODULEACCESS_EMPLOYEEID","mdc"."moduleaccess_accesslevel" AS "MODULEACCESS_LEVEL" from "sys_module_access" "mdc";

-- ----------------------------
-- View structure for t_plant
-- ----------------------------
DROP VIEW IF EXISTS `t_plant`;
CREATE SQL SECURITY DEFINER VIEW `t_plant` AS select "mwp"."plant_company" AS "COMPANY_CODE","mwp"."plant_id" AS "PLANT_ID","mwp"."plant_code" AS "PLANT_CODE","mwp"."plant_name" AS "PLANT_NAME","mwp"."plant_address" AS "PLANT_ADDRESS","mwp"."plant_officeblock" AS "PLANT_OFFICEBLOCK","mwp"."plant_city" AS "PLANT_CITY","mwp"."plant_phone" AS "PLANT_PHONE","mwp"."plant_fax" AS "PLANT_FAX" from "wsp_plant" "mwp";

-- ----------------------------
-- View structure for t_q_contractor_name
-- ----------------------------
DROP VIEW IF EXISTS `t_q_contractor_name`;
CREATE SQL SECURITY DEFINER VIEW `t_q_contractor_name` AS select "mtx"."mtx_origin" AS "CONTRACTOR_NAME" from "mat_movement" "mtx" where (length("mtx"."mtx_origin") > 0) group by "mtx"."mtx_origin" order by "mtx"."mtx_origin";

-- ----------------------------
-- View structure for t_q_material_movement
-- ----------------------------
DROP VIEW IF EXISTS `t_q_material_movement`;
CREATE SQL SECURITY DEFINER VIEW `t_q_material_movement` AS select "mtx"."mtx_rowid" AS "TX_ROWID","mtx"."mtx_id" AS "TX_ID","mtx"."mtx_plant" AS "TX_PLANT","mtx"."mtx_sponsor" AS "TX_SPONSOR","mtx"."mtx_carrier" AS "TX_CARRIER","mtx"."mtx_datedelivery" AS "TX_DATEDELIVERY","mtx"."mtx_origin" AS "TX_ORIGIN","mtx"."mtx_dateexecuted" AS "TX_DATEEXECUTED","mtx"."mtx_destination" AS "TX_DESTINATION","mtx"."mtx_datebast" AS "TX_DATEBAST","mtx"."mtx_datencr" AS "TX_DATENCR","mtx"."mtx_datesign" AS "TX_DATESIGN","mtx"."mtx_po" AS "TX_PO","mtx"."mtx_potype" AS "TX_POTYPE","mtx"."mtx_manifest" AS "TX_MANIFEST","mtx"."mtx_reservation" AS "TX_RESERVATION","mtx"."mtx_direction" AS "TX_DIRECTION","mtx"."mtx_totalvalue" AS "TX_TOTALVALUE","mtx"."mtx_revtoprint" AS "TX_REV","mtx"."mtx_mvt" AS "TX_MVT","mtx"."mtx_lastitemcount" AS "TX_LASTITEMCOUNT","mtx"."mtx_mrr_skep" AS "TX_MRR_SKEP","mtx"."mtx_mrr_pib" AS "TX_MRR_PIB","mtx"."mtx_mrr_masterlist" AS "TX_MRR_MASTERLIST","mtx"."mtx_mrr_chk_pdn" AS "TX_MRR_CHK_PDN","mtx"."mtx_mrr_chk_po" AS "TX_MRR_CHK_PO","mtx"."mtx_mrr_chk_certificates" AS "TX_MRR_CHK_CERT","mtx"."mtx_mrr_chk_deliveryorder" AS "TX_MRR_CHK_MANIFEST","mtx"."mtx_mrr_chk_warrantyletter" AS "TX_MRR_CHK_WARRANTYLETTER","mtx"."mtx_mrr_chk_safetydatasheet" AS "TX_MRR_CHK_SDS","mtx"."mtx_mrr_chk_pib" AS "TX_MRR_CHK_PIB","mtx"."mtx_mrr_chk_skepmasterilst" AS "TX_MRR_CHK_MASTERLIST","mtx"."mtx_bast_receiver" AS "TX_BAST_RECEIVER","mtx"."mtx_bast_acknowledge" AS "TX_BAST_ACKNOWLEDGE","mtx"."mtx_bast_superintendent" AS "TX_BAST_SUPERINTENDENT","mtx"."mtx_bast_totalitem" AS "TX_BAST_TOTALITEM","mtx"."mtx_bast_received" AS "TX_BAST_RECEIVED","mtx"."mtx_bast_rejectdiffpn" AS "TX_BAST_REJECTDIFFPN","mtx"."mtx_bast_rejectdefect" AS "TX_BAST_REJECTDEFECT","mtx"."mtx_bast_rejectdocs" AS "TX_BAST_REJECTDOCUMENTS","mtx"."mtx_bast_noappearance" AS "TX_BAST_REJECTNOAPPEARANCE","mtx"."mtx_bast_vendorpic" AS "TX_BAST_VENDORPIC","mtx"."mtx_ncr_isactive" AS "TX_NCR_ISACTIVE","mtx"."mtx_ncr_whathappen" AS "TX_NCR_WHATHAPPEN","mtx"."mtx_ncract_receivewosufficentdoc" AS "TX_NCRACT_RECEIVEWOSUFFICIENTDOCS","mtx"."mtx_ncract_receivewoposting" AS "TX_NCRACT_RECEIVEWOPOSTING","mtx"."mtx_ncract_transferwosupportingdoc" AS "TX_NCRACT_TRANSFERWOSUPPORTINGDOCS","mtx"."mtx_ncract_applycustombonds" AS "TX_NCRACT_APPLYCUSTOMBONDS","mtx"."mtx_ncract_postreceivedwomaterialappearance" AS "TX_NCRACT_POSTRECEIVEDWOMATERIALAPPEARANCE","mtx"."mtx_ncrbak_email" AS "TX_NCRBAK_EMAIL","mtx"."mtx_ncrbak_fax" AS "TX_NCRBAK_FAX","mtx"."mtx_ncrbak_userpurchasingconf" AS "TX_NCRBAK_USERPURCHASINGCONF","mtx"."mtx_ncrimp_inventorynotupdate" AS "TX_NCRIMP_INVENTORYNOTUPDATE","mtx"."mtx_ncrimp_costincreased" AS "TX_NCRIMP_COSTINCREASED","mtx"."mtx_ncrimp_goodsissuenotpossible" AS "TX_NCRIMP_GOODSISSUENOTPOSSIBLE","mtx"."mtx_ncrimp_delayplannedoperation" AS "TX_NCRIMP_DELAYPLANNEDOPERATION","mtx"."mtx_ncrimp_supplayingvendorsunpaid" AS "TX_NCRIMP_SUPPLAYINGVENDORSUNPAID","mtx"."mtx_ncrimp_delaystransaction" AS "TX_NCRIMP_DELAYTRANSACTION","mtx"."mtx_ncrsign_authbyname" AS "TX_NCRSIGN_AUTHBYNAME","mtx"."mtx_ncrsign_authbydate" AS "TX_NCRSIGN_AUTHBYDATE","mtx"."mtx_ncrsign_fwdbyname" AS "TX_NCRSIGN_FWDBYNAME","mtx"."mtx_ncrsign_department" AS "TX_NCRSIGN_DEPT","mtx"."mtx_ncrsign_date" AS "TX_NCRSIGN_DATE","mtx"."mtx_ncractaf_completepurchasingsupportingdocument" AS "TX_NCRACTAF_COMPLETEPURCHASINGSUPPORTINGDOCS","mtx"."mtx_ncractaf_completegoodreceivetransfergoodsissuesinv" AS "TX_NCRACTAF_COMPLETEGOODRECEIVETRANSFERGOODSISSUESINV","mtx"."mtx_ncractaf_updatereissuemasterlist" AS "TX_NCRACTAF_UPDATEREISSUEMASTERLIST","mtx"."mtx_ncractaf_closeadinterimcustomspib" AS "TX_NCRACTAF_CLOSEDINTERIMCUSTOMPIB","mtx"."mtx_ncrprev_requestingprocesstobedoneinadvance" AS "TX_NCRPREV_REQUESTINGPROCESSTOBEDONEINADVANCE","mtx"."mtx_ncrprev_vendorsareadvisedtoidentifypo" AS "TX_NCRPREV_VENDORADVISEDTOIDENTIFYPO","mtx"."mtx_ncrprev_anychangeadvisedinadvance" AS "TX_NCRPREV_ANYCHANGEADVISEDINADVANCE","mtx"."mtx_ncrprev_followstepoperationallymaterialmanagementprocess" AS "TX_NCRPREV_FOLLOWSTEPOPERATIONALLYMATERIALMANAGEMENTPROCESS","mtx"."mtx_ncrprev_apply14daysmaterialcalloffplanningtologistics" AS "TX_NCRPREV_APPLY14DAY","mtx"."mtx_ncr_closedatetarget" AS "TX_NCR_CLOSEDATETARGET","mtx"."mtx_ncr_closedby" AS "TX_NCR_CLOSEBY","mtx"."mtx_receiver_title" AS "TX_RECEIVER_TITLE","mtx"."mtx_acknowledge_title" AS "TX_ACKNOWLEDGE_TITLE","mtx"."mtx_superintendent_title" AS "TX_SUPERINTENDENT_TITLE","mtx"."mtx_sign_storekeeper" AS "TX_SIGN_STOREKEEPER","mtx"."mtx_sign_materialman" AS "TX_SIGN_MATERIALMAN","mtx"."mtx_sign_supervisor" AS "TX_SIGN_SUPERVISOR","mtx"."mtx_att_link" AS "TX_ATT_LINK","mtxd"."mtxd_rowid" AS "D_ROWID","mtxd"."mtxd_mtxid_old" AS "D_TXID_OLD","mtxd"."mtxd_mtxid" AS "D_MTXID","mtxd"."mtxd_no" AS "D_NO","mtxd"."mtxd_miap" AS "D_MIAP","mtxd"."mtxd_dcdcode" AS "D_DCDCODE","mtxd"."mtxd_materialname" AS "D_MATERIALNAME","mtxd"."mtxd_materialcategory" AS "D_MATERIALCATEGORY","mtxd"."mtxd_partnumber" AS "D_PARTNUMBER","mtxd"."mtxd_uom" AS "D_UOM","mtxd"."mtxd_valtype" AS "D_VALTYPE","mtxd"."mtxd_qty" AS "D_QTY","mtxd"."mtxd_po" AS "D_PO","mtxd"."mtxd_avgprice" AS "D_AVGPRICE","mtxd"."mtxd_totalvalue" AS "D_TOTALVALUE","mtxd"."mtxd_binloc" AS "D_BINLOCK","mtxd"."mtxd_destination" AS "D_DESTINATION","mtxd"."mtxd_reference" AS "D_REFERENCE","mtxd"."mtxd_remarks" AS "D_REMARKS","mtxd"."mtxd_materialtype" AS "D_MATERIALTYPE","mtxd"."mtxd_ownership" AS "D_OWNERSHIP","mtxd"."mtxd_sapdoc" AS "D_DOCSAP","mtxd"."mtxd_sapdocdate" AS "D_DATEDOCSAP","mtxd"."mtxd_category" AS "D_CATEGORY","mtxd"."mtxd_sloc" AS "D_SLOC","mtxd"."mtxd_packaging" AS "D_PACKAGING","mtxd"."mtxd_finalcheck" AS "D_FINALCHECK","mtxd"."mtxd_rofinalcheck" AS "D_ROFINALCHECK","mtxd"."mtxd_roplant" AS "D_ROPLANT" from ("mat_movement" "mtx" join "mat_movement_detail" "mtxd" on(("mtxd"."mtxd_mtxid" = "mtx"."mtx_id"))) order by "mtx"."mtx_datedelivery" desc;

-- ----------------------------
-- View structure for t_sloc
-- ----------------------------
DROP VIEW IF EXISTS `t_sloc`;
CREATE SQL SECURITY DEFINER VIEW `t_sloc` AS select "mws"."sloc_id" AS "SLOC_ID","mws"."sloc_code" AS "SLOC_CODE","mws"."sloc_plantid" AS "SLOC_PLANT","mws"."sloc_name" AS "SLOC_NAME","mws"."sloc_abbrevation" AS "SLOC_ABBRV" from "wsp_sloc" "mws";

-- ----------------------------
-- View structure for t_sys_settings
-- ----------------------------
DROP VIEW IF EXISTS `t_sys_settings`;
CREATE SQL SECURITY DEFINER VIEW `t_sys_settings` AS select "ss"."sys_id" AS "SYS_ID","ss"."sys_appversion" AS "SYS_APPVERSION","ss"."sys_key" AS "SYS_KEY" from "sys_settings" "ss";

-- ----------------------------
-- View structure for t_workingarea
-- ----------------------------
DROP VIEW IF EXISTS `t_workingarea`;
CREATE SQL SECURITY DEFINER VIEW `t_workingarea` AS select "ewa"."workingarea_id" AS "WORKINGAREA_ROWID","ewa"."workingarea_slocid" AS "WORKINGAREA_SLOCID","ewa"."workingarea_employeeid" AS "WORKINGAREA_EMPLOYEEID","ewa"."workingarea_access" AS "WORKINGAREA_ACCESS" from "wsp_employee_workingarea" "ewa";

-- ----------------------------
-- Procedure structure for xp_login_isexist
-- ----------------------------
DROP PROCEDURE IF EXISTS `xp_login_isexist`;
delimiter ;;
CREATE PROCEDURE `xp_login_isexist`(EmployeeID varchar(255),
    EmployeePassword varchar(255))
BEGIN
	Select count(mwu.usr_userid) as isexist
    from mvu_wsp_user as mwu 
    where mwu.usr_userid = EmployeeID and mwu.usr_password = md5(EmployeePassword) 
    limit 0,1;
END
;;
delimiter ;

-- ----------------------------
-- Event structure for cleaning_table_user
-- ----------------------------
DROP EVENT IF EXISTS `cleaning_table_user`;
delimiter ;;
CREATE EVENT `cleaning_table_user`
ON SCHEDULE
EVERY '15' MINUTE STARTS '2024-09-06 09:03:45'
DO delete from mvu_wsp_user where usr_expiry < now() and usr_isnew = 1
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table log_material
-- ----------------------------
DROP TRIGGER IF EXISTS `log_material_BEFORE_INSERT`;
delimiter ;;
CREATE TRIGGER `log_material_BEFORE_INSERT` BEFORE INSERT ON `log_material` FOR EACH ROW BEGIN
	-- declare hash_materialid varchar(50);
    -- set hash_materialid = MD5(NEW.material_code + NEW.material_code2);
    -- set NEW.material_id = hash_materialid;
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table log_material
-- ----------------------------
DROP TRIGGER IF EXISTS `log_material_AFTER_INSERT`;
delimiter ;;
CREATE TRIGGER `log_material_AFTER_INSERT` AFTER INSERT ON `log_material` FOR EACH ROW BEGIN
	declare varMaterialID char(32);
    set varMaterialID = NEW.material_id;
    
	insert ignore into log_materialsoh(soh_materialid, soh_slocid) select varMaterialID, sloc_id from wsp_sloc;
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table log_materialsoh
-- ----------------------------
DROP TRIGGER IF EXISTS `log_materialsoh_BEFORE_INSERT`;
delimiter ;;
CREATE TRIGGER `log_materialsoh_BEFORE_INSERT` BEFORE INSERT ON `log_materialsoh` FOR EACH ROW BEGIN
	-- SET NEW.soh_code = md5(NEW.soh_materialid + NEW.soh_slocid);
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table mat_master
-- ----------------------------
DROP TRIGGER IF EXISTS `mat_master_BEFORE_INSERT`;
delimiter ;;
CREATE TRIGGER `mat_master_BEFORE_INSERT` BEFORE INSERT ON `mat_master` FOR EACH ROW BEGIN
	-- set new.mat_id = (select md5(mat_maincode & '-' & mat_subcode));
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table mat_movement
-- ----------------------------
DROP TRIGGER IF EXISTS `mat_movement_AFTER_INSERT`;
delimiter ;;
CREATE TRIGGER `mat_movement_AFTER_INSERT` AFTER INSERT ON `mat_movement` FOR EACH ROW BEGIN
	insert into mat_movement_handle(mtxh_movementid, mtxh_employeeid) select NEW.mtx_id, employee_id from wsp_employee where employee_scopeofwork = (SELECT employee_scopeofwork FROM defaultdb.wsp_employee where employee_id = NEW.mtx_createdby) ORDER BY employee_fullname on duplicate key update mtxh_employeeid = employee_id;
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table mat_movement
-- ----------------------------
DROP TRIGGER IF EXISTS `mat_movement_AFTER_UPDATE`;
delimiter ;;
CREATE TRIGGER `mat_movement_AFTER_UPDATE` AFTER UPDATE ON `mat_movement` FOR EACH ROW BEGIN
insert into mat_movement_handle(mtxh_movementid, mtxh_employeeid) select OLD.mtx_id, employee_id from wsp_employee  where employee_scopeofwork = (SELECT employee_scopeofwork FROM defaultdb.wsp_employee where employee_id = OLD.mtx_createdby) ORDER BY employee_fullname on duplicate key update mtxh_employeeid = employee_id;
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table sys_module
-- ----------------------------
DROP TRIGGER IF EXISTS `mvu_module_BEFORE_UPDATE`;
delimiter ;;
CREATE TRIGGER `mvu_module_BEFORE_UPDATE` BEFORE UPDATE ON `sys_module` FOR EACH ROW BEGIN
	insert ignore into sys_module_access(moduleaccess_moduleid, moduleaccess_employeeid) select OLD.module_id, employee_id from wsp_employee on duplicate key update moduleaccess_employeeid = employee_id;
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table wsp_employee
-- ----------------------------
DROP TRIGGER IF EXISTS `wsp_user_BEFORE_INSERT`;
delimiter ;;
CREATE TRIGGER `wsp_user_BEFORE_INSERT` BEFORE INSERT ON `wsp_employee` FOR EACH ROW BEGIN
	set NEW.employee_slocid = (select SLOC_ID from t_sloc WHERE SLOC_NAME <> 'VENDORS' order by SLOC_ABBRV ASC, SLOC_NAME ASC LIMIT 0,1);
    set new.employee_expiry = (SELECT DATE_ADD(now(), INTERVAL 15 MINUTE));
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table wsp_employee
-- ----------------------------
DROP TRIGGER IF EXISTS `wsp_user_BEFORE_UPDATE`;
delimiter ;;
CREATE TRIGGER `wsp_user_BEFORE_UPDATE` BEFORE UPDATE ON `wsp_employee` FOR EACH ROW BEGIN
	set NEW.employee_lastmodified = now();
	set NEW.employee_expiry = null;
    set NEW.employee_isnew = null;
    
    if new.employee_islogin = -1 then begin
		set NEW.employee_lastlogin = now();
        end;
	end if;        
    
    insert ignore into sys_module_access(moduleaccess_moduleid, moduleaccess_employeeid) select module_id, OLD.employee_id from sys_module on duplicate key update moduleaccess_moduleid = module_id;
	insert ignore into wsp_employee_workingarea(workingarea_slocid, workingarea_employeeid) select sloc_id, OLD.employee_id from wsp_sloc on duplicate key update workingarea_slocid = sloc_id;
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table wsp_sloc
-- ----------------------------
DROP TRIGGER IF EXISTS `wsp_sloc_BEFORE_UPDATE`;
delimiter ;;
CREATE TRIGGER `wsp_sloc_BEFORE_UPDATE` BEFORE UPDATE ON `wsp_sloc` FOR EACH ROW BEGIN
	insert ignore into wsp_employee_workingarea(workingarea_slocid, workingarea_employeeid) select OLD.sloc_id, employee_id from wsp_employee on duplicate key update workingarea_employeeid = employee_id;
END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
