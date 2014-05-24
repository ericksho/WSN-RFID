class CreateVehiculos < ActiveRecord::Migration
  def change
    create_table :vehiculos do |t|
      t.string :patente
      t.string :marca
      t.string :modelo
      t.integer :anho
      t.string :color
      t.string :chasis
      t.string :n_motor
      t.integer :kilometraje
      t.string :tipo_combustible
      t.boolean :es_4x4
      t.string :categoria
      t.integer :n_puertas
      t.boolean :a_c
      t.boolean :gps
      t.boolean :disponible
      t.integer :costo

      t.timestamps
    end
  end
end
