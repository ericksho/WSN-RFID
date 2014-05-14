# encoding: UTF-8
# This file is auto-generated from the current state of the database. Instead
# of editing this file, please use the migrations feature of Active Record to
# incrementally modify your database, and then regenerate this schema definition.
#
# Note that this schema.rb definition is the authoritative source for your
# database schema. If you need to create the application database on another
# system, you should be using db:schema:load, not running all the migrations
# from scratch. The latter is a flawed and unsustainable approach (the more migrations
# you'll amass, the slower it'll run and the greater likelihood for issues).
#
# It's strongly recommended that you check this file into your version control system.

ActiveRecord::Schema.define(version: 20140514230036) do

  # These are extensions that must be enabled in order to support this database
  enable_extension "plpgsql"

  create_table "alertas", force: true do |t|
    t.boolean  "desconectada"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "articulos", force: true do |t|
    t.integer  "rfid"
    t.boolean  "estado"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "atributos", force: true do |t|
    t.string   "nombre_at"
    t.string   "valor"
    t.string   "tipo_variable"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "lectors", force: true do |t|
    t.string   "posicion"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "lecturas", force: true do |t|
    t.datetime "fecha"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "paquetes", force: true do |t|
    t.string   "nombre"
    t.string   "valores_dez"
    t.string   "tipo"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "permisos", force: true do |t|
    t.string   "titulo"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "permisos_usuarios", id: false, force: true do |t|
    t.integer "permiso_id"
    t.integer "usuario_id"
  end

  add_index "permisos_usuarios", ["permiso_id", "usuario_id"], name: "index_permisos_usuarios_on_permiso_id_and_usuario_id", unique: true, using: :btree

  create_table "tipos", force: true do |t|
    t.string   "valor"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "usuarios", force: true do |t|
    t.string   "status"
    t.string   "password"
    t.string   "email"
    t.string   "nombre"
    t.string   "apellido"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

end
