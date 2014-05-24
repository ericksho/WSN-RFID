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

ActiveRecord::Schema.define(version: 20140524205848) do

  # These are extensions that must be enabled in order to support this database
  enable_extension "plpgsql"

  create_table "alertas", force: true do |t|
    t.boolean  "desconectada"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "lectura_id"
  end

  add_index "alertas", ["lectura_id"], name: "index_alertas_on_lectura_id", using: :btree

  create_table "articulos", force: true do |t|
    t.integer  "rfid"
    t.boolean  "estado"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "tipo_id"
    t.integer  "vehiculo_id"
    t.integer  "persona_id"
  end

  add_index "articulos", ["tipo_id"], name: "index_articulos_on_tipo_id", using: :btree

  create_table "atributos", force: true do |t|
    t.string   "nombre_at"
    t.string   "valor"
    t.string   "tipo_variable"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "articulo_id"
  end

  add_index "atributos", ["articulo_id"], name: "index_atributos_on_articulo_id", using: :btree

  create_table "lectors", force: true do |t|
    t.string   "posicion"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "lecturas", force: true do |t|
    t.datetime "fecha"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "articulo_id"
    t.integer  "lector_id"
  end

  add_index "lecturas", ["articulo_id"], name: "index_lecturas_on_articulo_id", using: :btree
  add_index "lecturas", ["lector_id"], name: "index_lecturas_on_lector_id", using: :btree

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

  create_table "personas", force: true do |t|
    t.string   "nombre"
    t.string   "apellido"
    t.string   "rut"
    t.string   "email"
    t.integer  "celular"
    t.date     "fecha_nacimiento"
    t.string   "cargo"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "usuarios", force: true do |t|
    t.string   "status"
    t.string   "password_digest"
    t.string   "email"
    t.string   "nombre"
    t.string   "apellido"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "vehiculos", force: true do |t|
    t.string   "patente"
    t.string   "marca"
    t.string   "modelo"
    t.integer  "anho"
    t.string   "color"
    t.string   "chasis"
    t.string   "n_motor"
    t.integer  "kilometraje"
    t.string   "tipo_combustible"
    t.boolean  "es_4x4"
    t.string   "categoria"
    t.integer  "n_puertas"
    t.boolean  "a_c"
    t.boolean  "gps"
    t.boolean  "disponible"
    t.integer  "costo"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

end
