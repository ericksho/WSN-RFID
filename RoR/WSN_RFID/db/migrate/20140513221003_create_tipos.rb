class CreateTipos < ActiveRecord::Migration
  def change
    create_table :tipos do |t|
      t.string :valor

      t.timestamps
    end
  end
end
