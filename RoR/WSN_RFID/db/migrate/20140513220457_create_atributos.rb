class CreateAtributos < ActiveRecord::Migration
  def change
    create_table :atributos do |t|
      t.string :nombre_at
      t.string :valor
      t.string :tipo_variable

      t.timestamps
    end
  end
end
