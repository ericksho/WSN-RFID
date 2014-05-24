class CreatePersonas < ActiveRecord::Migration
  def change
    create_table :personas do |t|
      t.string :nombre
      t.string :apellido
      t.string :rut
      t.string :email
      t.integer :celular
      t.date :fecha_nacimiento
      t.string :cargo

      t.timestamps
    end
  end
end
